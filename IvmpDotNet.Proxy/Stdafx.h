// stdafx.h : Includedatei f�r Standardsystem-Includedateien
// oder h�ufig verwendete projektspezifische Includedateien,
// die nur in unregelm��igen Abst�nden ge�ndert werden.

#pragma once

#ifndef _LINUX
#define EXPORT extern "C" __declspec(dllexport)
#else
#define EXPORT extern "C"
#endif