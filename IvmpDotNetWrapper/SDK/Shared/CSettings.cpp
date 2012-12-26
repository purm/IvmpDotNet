//============== IV: Multiplayer - http://code.iv-multiplayer.com ==============
//
// File: CSettings.cpp
// Project: Shared
// Author(s): jenksta
//            mabako
// License: See LICENSE in root directory
//
//==============================================================================

#include "CSettings.h"
#include "SharedUtility.h"
#include "CLogFile.h"

std::map<String, SettingsValue *> CSettings::m_values;
bool                              CSettings::m_bOpen = false;
bool                              CSettings::m_bSave = false;
TiXmlDocument                     CSettings::m_XMLDocument;

void CSettings::LoadDefaults()
{
	// jenksta: HACKY, find another way
#ifdef _SERVER
	AddString("logfile", "ivmp-svr.log");
	AddInteger("port", 9999, 1024, 65535);
	AddInteger("httpport", 9998, 80, 65535);
	AddString("httpserver", "");
	AddInteger("maxplayers", MAX_PLAYERS, 1, MAX_PLAYERS);
	AddInteger("maxvehicles", MAX_VEHICLES, 0, MAX_VEHICLES);
	AddString("password", "");
	AddBool("query", true);
	AddBool("listed", false);
	AddBool("guinametags",false);
	AddBool("headmovement",true);
	AddString("hostname", VERSION_IDENTIFIER_2 " Server");
	AddString("hostaddress", "");
	AddBool("frequentevents", false);
	AddBool("kickoldplayers", true);
	AddBool("paynspray", true);
	AddBool("autoaim", true);
	AddInteger("weather", 1, 1, 10);
	AddFloat("wind",0.0,0.0,50.0);
	AddBool("silent", false);
	AddBool("timestamp", true);
	AddList("script");
	AddList("clientscript");
	AddList("clientresource");
	AddList("module");
	AddList("config");
#else
	AddString("ip", "127.0.0.1");
	AddInteger("port", 9999, 1024, 65535);
	//AddString("nick", "kyefag");
	//AddString("nick", "jenksta");
	AddString("nick", "player");
	AddString("pass", "");
	AddBool("windowed", false);
	AddBool("fps", false);
	AddString("chatfont", "tahoma-bold");
	AddInteger("chatsize", 10, 1, 100);
	AddInteger("chatbga", 0, 0, 255);
	AddInteger("chatbgr", 0, 0, 255);
	AddInteger("chatbgg", 0, 0, 255);
	AddInteger("chatbgb", 0, 0, 255);
#endif
}

SettingsValue * CSettings::GetSetting(String strSetting)
{
	for(std::map<String, SettingsValue *>::iterator iter = m_values.begin(); iter != m_values.end(); iter++)
	{
		if(iter->first == strSetting)
			return iter->second;
	}

	return NULL;
}

bool CSettings::Open(String strPath, bool bCreate, bool bSave)
{
	// Flag we are not allowed to save the file by default
	m_bSave = false;

	// Load the default settings
	LoadDefaults();

	// Does the settings file not exist?
	bool bExists = true;

	if(!SharedUtility::Exists(strPath.Get()))
	{
		if(!bCreate)
		{
			CLogFile::Printf("ERROR: Settings file %s does not exist.", strPath.Get());
			return false;
		}
		else
		{
			CLogFile::Printf("WARNING: Settings file %s does not exist, it will now be created.", strPath.Get());

			// Attempt to open the file for write
			FILE * fFile = fopen(strPath.Get(), "w");

			// Ensure the file was opened
			if(!fFile)
			{
				CLogFile::Printf("WARNING: Failed to create settings file %s, no settings will be loaded or saved.", strPath.Get());

				// Flag the settings file as does not exist
				bExists = false;
			}
			else
			{
				// Write the default contents to the file
				fprintf(fFile, "<settings />");

				// Close the file
				fclose(fFile);
			}
		}
	}

	// Load the settings file
	if(bExists)
	{
		// Attempt to load the XML file
		if(m_XMLDocument.LoadFile(strPath.Get()))
		{
			// Flag ourselves as open
			m_bOpen = true;

			// Loop through all XML nodes
			for(TiXmlNode * pNode = m_XMLDocument.RootElement()->FirstChildElement(); pNode; pNode = pNode->NextSibling())
			{
				// Is this not an element node?
				if(pNode->Type() != TiXmlNode::ELEMENT)
					continue;

				// Get the setting and value
				String strSetting = pNode->Value();
				String strValue = pNode->ToElement()->GetText();

				// Does the setting not exist?
				if(!Exists(strSetting))
					CLogFile::Printf("WARNING: Log file setting %s does not exist.", strSetting.Get());
				else
					SetEx(strSetting, strValue);
			}

			// Flag if we are allowed to save the file
			m_bSave = bSave;

			// Save the XML file
			Save();
		}
		else
		{
			if(bCreate)
			{
				CLogFile::Printf("ERROR: Failed to open settings file %s.", strPath.Get());
				return false;
			}
			else
				CLogFile::Printf("WARNING: Failed to open settings file %s, no settings will be loaded or saved.", strPath.Get());
		}
	}

	return true;
}

bool CSettings::Close()
{
	// Are we flagged as open?
	if(m_bOpen)
		return true;

	return false;	
}

bool CSettings::Save()
{
	// Are we not flagged as open?
	if(!m_bOpen)
		return false;

	// Are we not flagged as allowed to save the file?
	if(!m_bSave)
		return false;

	// Loop through all values
	for(std::map<String, SettingsValue *>::iterator iter = m_values.begin(); iter != m_values.end(); iter++)
	{
		// Get the setting pointer
		SettingsValue * setting = iter->second;

		// Find all nodes for this value
		bool bFoundNode = false;

		for(TiXmlNode * pNode = m_XMLDocument.RootElement()->FirstChildElement(iter->first.Get()); pNode; pNode = pNode->NextSibling())
		{
			// Is this not an element node?
			if(pNode->Type() != TiXmlNode::ELEMENT)
				continue;

			// Is this not the node we are looking for?
			if(iter->first.Compare(pNode->Value()))
				continue;

			// Is this a list node?
			if(setting->IsList())
			{
				// Remove the node
				m_XMLDocument.RootElement()->RemoveChild(pNode);
			}
			else
			{
				// Clear the node
				pNode->Clear();

				// Get the node value
				String strValue = GetEx(iter->first);

				// Create a new node value
				TiXmlText * pNewNodeValue = new TiXmlText(strValue.Get());

				// Add the new node value to the new node
				pNode->LinkEndChild(pNewNodeValue);
			}

			// Flag as found a node
			bFoundNode = true;
			break;
		}

		// Is this a list value?
		if(setting->IsList())
		{
			// Loop through each list item
			for(std::list<String>::iterator iter2 = setting->listValue.begin(); iter2 != setting->listValue.end(); iter2++)
			{
				// Create a new node
				TiXmlElement * pNewNode = new TiXmlElement(iter->first.Get());

				// Create a new node value
				TiXmlText * pNewNodeValue = new TiXmlText((*iter2).Get());

				// Add the new node value to the new node
				pNewNode->LinkEndChild(pNewNodeValue);

				// Add the new node to the XML document
				m_XMLDocument.RootElement()->LinkEndChild(pNewNode);
			}
		}
		else
		{
			// Do we need to create a new node?
			if(!bFoundNode)
			{
				// Create a new node
				TiXmlElement * pNewNode = new TiXmlElement(iter->first.Get());

				// Get the node value
				String strValue = GetEx(iter->first);

				// Create a new node value
				TiXmlText * pNewNodeValue = new TiXmlText(strValue.Get());

				// Add the new node value to the new node
				pNewNode->LinkEndChild(pNewNodeValue);

				// Add the new node to the XML document
				m_XMLDocument.RootElement()->LinkEndChild(pNewNode);
			}
		}
	}

	// Save the XML document
	return m_XMLDocument.SaveFile();
}

bool CSettings::AddBool(String strSetting, bool bDefaultValue)
{
	if(Exists(strSetting))
		return false;

	SettingsValue * setting = new SettingsValue;
	setting->cFlags = 0;
	SET_BIT(setting->cFlags, SETTINGS_FLAG_BOOL);
	setting->bValue = bDefaultValue;
	m_values[strSetting] = setting;
	
	// Save the XML file
	Save();
	return true;
}

bool CSettings::AddInteger(String strSetting, int iDefaultValue, int iMinimumValue, int iMaximumValue)
{
	if(Exists(strSetting))
		return false;

	SettingsValue * setting = new SettingsValue;
	setting->cFlags = 0;
	SET_BIT(setting->cFlags, SETTINGS_FLAG_INTEGER);
	setting->iValue = iDefaultValue;
	setting->iMinimumValue = iMinimumValue;
	setting->iMaximimValue = iMaximumValue;
	m_values[strSetting] = setting;

	// Save the XML file
	Save();
	return true;
}

bool CSettings::AddFloat(String strSetting, float fDefaultValue, float fMinimumValue, float fMaximumValue)
{
	if(Exists(strSetting))
		return false;

	SettingsValue * setting = new SettingsValue;
	setting->cFlags = 0;
	SET_BIT(setting->cFlags, SETTINGS_FLAG_FLOAT);
	setting->fValue = fDefaultValue;
	setting->fMinimumValue = fMinimumValue;
	setting->fMaximimValue = fMaximumValue;
	m_values[strSetting] = setting;

	// Save the XML file
	Save();
	return true;
}

bool CSettings::AddString(String strSetting, String strDefaultValue)
{
	if(Exists(strSetting))
		return false;

	SettingsValue * setting = new SettingsValue;
	setting->cFlags = 0;
	SET_BIT(setting->cFlags, SETTINGS_FLAG_STRING);
	setting->strValue = strDefaultValue;
	m_values[strSetting] = setting;

	// Save the XML file
	Save();
	return true;
}

bool CSettings::AddList(String strSetting)
{
	if(Exists(strSetting))
		return false;

	SettingsValue * setting = new SettingsValue;
	setting->cFlags = 0;
	SET_BIT(setting->cFlags, SETTINGS_FLAG_LIST);
	m_values[strSetting] = setting;
	return true;
}

bool CSettings::SetBool(String strSetting, bool bValue)
{
	if(IsBool(strSetting))
	{
		GetSetting(strSetting)->bValue = bValue;

		// Save the XML file
		Save();
		return true;
	}

	return false;
}

bool CSettings::SetInteger(String strSetting, int iValue)
{
	if(IsInteger(strSetting))
	{
		SettingsValue * setting = GetSetting(strSetting);

		if(iValue < setting->iMinimumValue || iValue > setting->iMaximimValue)
			return false;

		setting->iValue = iValue;

		// Save the XML file
		Save();
		return true;
	}

	return false;
}

bool CSettings::SetFloat(String strSetting, float fValue)
{
	if(IsFloat(strSetting))
	{
		SettingsValue * setting = GetSetting(strSetting);

		if(fValue < setting->fMinimumValue || fValue > setting->fMaximimValue)
			return false;

		setting->fValue = fValue;

		// Save the XML file
		Save();
		return true;
	}

	return false;
}

bool CSettings::SetString(String strSetting, String strValue)
{
	if(IsString(strSetting))
	{
		GetSetting(strSetting)->strValue = strValue;

		// Save the XML file
		Save();
		return true;
	}

	return false;
}

bool CSettings::AddToList(String strSetting, String strValue)
{
	if(IsList(strSetting))
	{
		GetSetting(strSetting)->listValue.push_back(strValue);

		// Save the XML file
		Save();
		return true;
	}

	return false;
}

bool CSettings::SetEx(String strSetting, String strValue)
{
	if(IsBool(strSetting))
		SetBool(strSetting, strValue.ToBoolean());
	else if(IsInteger(strSetting))
		SetInteger(strSetting, strValue.ToInteger());
	else if(IsFloat(strSetting))
		SetFloat(strSetting, strValue.ToFloat());
	else if(IsString(strSetting))
		SetString(strSetting, strValue);
	else if(IsList(strSetting))
		AddToList(strSetting, strValue);
	else
		return false;

	return true;
}

bool CSettings::GetBool(String strSetting)
{
	if(IsBool(strSetting))
		return GetSetting(strSetting)->bValue;

	return false;
}

int CSettings::GetInteger(String strSetting)
{
	if(IsInteger(strSetting))
		return GetSetting(strSetting)->iValue;

	return 0;
}

float CSettings::GetFloat(String strSetting)
{
	if(IsFloat(strSetting))
		return GetSetting(strSetting)->fValue;

	return 0.0f;
}

String CSettings::GetString(String strSetting)
{
	if(IsString(strSetting))
		return GetSetting(strSetting)->strValue;

	return "";
}

std::list<String> CSettings::GetList(String strSetting)
{
	if(IsList(strSetting))
		return GetSetting(strSetting)->listValue;

	return std::list<String>();
}

String CSettings::GetEx(String strSetting)
{
	String strValue;

	// Get the setting
	SettingsValue * setting = GetSetting(strSetting);

	// Does the setting exist?
	if(setting)
	{
		if(setting->IsBool())
			strValue.FromBoolean(setting->bValue);
		else if(setting->IsInteger())
			strValue.FromInteger(setting->iValue);
		else if(setting->IsFloat())
			strValue.FromFloat(setting->fValue);
		else if(setting->IsString())
			strValue = setting->strValue;
	}

	return strValue;
}

bool CSettings::Exists(String strSetting)
{
	return (GetSetting(strSetting) != NULL);
}

bool CSettings::IsBool(String strSetting)
{
	SettingsValue * setting = GetSetting(strSetting);

	if(setting && setting->IsBool())
		return true;

	return false;

}

bool CSettings::IsInteger(String strSetting)
{
	SettingsValue * setting = GetSetting(strSetting);

	if(setting && setting->IsInteger())
		return true;

	return false;
}

bool CSettings::IsFloat(String strSetting)
{
	SettingsValue * setting = GetSetting(strSetting);

	if(setting && setting->IsFloat())
		return true;

	return false;
}

bool CSettings::IsString(String strSetting)
{
	SettingsValue * setting = GetSetting(strSetting);

	if(setting && setting->IsString())
		return true;

	return false;
}

bool CSettings::IsList(String strSetting)
{
	SettingsValue * setting = GetSetting(strSetting);

	if(setting && setting->IsList())
		return true;

	return false;
}

bool CSettings::Remove(String strSetting)
{
	if(!Exists(strSetting))
		return false;

	for(std::map<String, SettingsValue *>::iterator iter = m_values.begin(); iter != m_values.end(); iter++)
	{
		if(iter->first == strSetting)
		{
			delete iter->second;
			m_values.erase(iter);
			break;
		}
	}

	// Save the XML file
	Save();
	return true;
}

void CSettings::ParseCommandLine(int argc, char ** argv)
{
	for(int i = 0; i < argc; i++)
	{
		// Is the current char a '-'?
		if(argv[i][0] == '-')
		{
			// Is there a value?
			if((i + 1) < argc)
			{
				// Get the setting and value pointers
				String strSetting = (argv[i] + 1);
				String strValue = argv[i + 1];

				// Set the setting and value
				if(!SetEx(strSetting, strValue))
					CLogFile::Printf("WARNING: Command line setting %s does not exist.", strSetting.Get());

				CLogFile::Printf("argv/argc command line: setting %s value %s", strSetting.Get(), strValue.Get());
			}
		}
	}
}

void CSettings::ParseCommandLine(char * szCommandLine)
{
	// Loop until we reach the end of the command line string
	while(*szCommandLine)
	{
		// Is the current char not a space?
		if(!isspace(*szCommandLine))
		{
			// Is the current char a '-'?
			if(*szCommandLine == '-')
			{
				// Skip the '-'
				szCommandLine++;

				// Collect the setting string
				String strSetting;

				while(*szCommandLine && !isspace(*szCommandLine))
				{
					strSetting += *szCommandLine;
					szCommandLine++;
				}

				// If we have run out of command line to process break out of the loop
				if(!(*szCommandLine))
					break;

				// Skip the spaces between the option and the value
				while(*szCommandLine && isspace(*szCommandLine))
					szCommandLine++;

				// If we have run out of command line to process break out of the loop
				if(!(*szCommandLine))
					break;

				// Collect the value string
				String strValue;

				while(*szCommandLine && !isspace(*szCommandLine))
				{
					strValue += *szCommandLine;
					szCommandLine++;
				}

				// Set the setting and value
				if(!SetEx(strSetting, strValue))
					CLogFile::Printf("WARNING: Command line setting %s does not exist.", strSetting.Get());

				CLogFile::Printf("argv/argc command line: setting %s value %s", strSetting.Get(), strValue.Get());

				// If we have run out of command line to process break out of the loop
				if(!(*szCommandLine))
					break;
			}
		}

		// Increment the command line string pointer
		szCommandLine++;
	}
}
