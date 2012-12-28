using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace IvmpDotNet.InterfaceGenerator {
    static class NativeToCLRType {
        public static string Convert(string nativeType, bool retType) {
            string str = nativeType.ToLower().Replace(" ", "");
            if (str.StartsWith("intrespawn_delay"))
                return "Int32";

            switch (str) {
                case "cplayerinterface*":
                case "cvehicleinterface*":
                    return "IntPtr";
                case "void":
                    return "void";
                case "constchar*":
                case "char*":
                case "wchar_t*":
                case "constwchar_t*":
                    if (retType)
                        return "IntPtr";
                    else
                        return "String";
                case "float":
                    return "Single";
                case "double":
                    return "double";
                case "bool":
                    return "Boolean";
                case "void*":
                    return "IntPtr";
                case "unsignedchar":
                case "byte":
                    return "Byte";
                case "short":
                    return "Int16";
                case "unsignedshort":
                    return "UInt16";
                case "unsignedlong":
                case "unsignedint":
                    return "UInt32";
                case "int":
                case "long":
                    return "Int32";
                case "char":
                case "wchar_t":
                    return "char";
                case "cvector3":
                    return "CVector3";
                case "ccontrolstate":
                    return "CControlState";
                case "entityid":
                    return "ushort";
                case "int*":
                case "byte*":
                    return "IntPtr";
                case "":
                    return string.Empty;
            }

            throw new ArgumentException();
        }
    }

    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            string input = inputTxt.Text;
            string className = txtClassName.Text;
            StringBuilder cppOutputBuilder = new StringBuilder();
            StringBuilder csOutputBuilder = new StringBuilder();
            string[] lines = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            cppOutputBuilder.AppendLine("#include \"SDK\\SDK.h\"");
            cppOutputBuilder.AppendLine();

            csOutputBuilder.AppendLine("using IvmpDotNet.SDK;");
            csOutputBuilder.AppendLine("using System;");
            csOutputBuilder.AppendLine("using System.Collections.Generic;");
            csOutputBuilder.AppendLine("using System.Linq;");
            csOutputBuilder.AppendLine("using System.Runtime.InteropServices;");
            csOutputBuilder.AppendLine("using System.Text;");
            csOutputBuilder.AppendLine();
            csOutputBuilder.AppendLine("namespace IvmpDotNet.Imports {");
            csOutputBuilder.AppendLine(string.Format("\tpublic static class {0} {{", className));

            foreach (string line in lines) {
                Match match = Regex.Match(line, Properties.Resources.ParsingPattern);
                if (match.Success) {
                    string returnType = match.Groups[1].Value;
                    string methodName = match.Groups[2].Value;
                    string parameters = match.Groups[3].Value;
                    cppOutputBuilder.AppendLine(string.Format("EXPORT {0} {1}_{2}({3}) {{", returnType, className, methodName, parameters));

                    if (returnType != "void")
                        cppOutputBuilder.Append("\treturn ");
                    else
                        cppOutputBuilder.Append("\t");

                    string paramString = string.Empty;
                    string csParamstring = string.Empty;
                    string[] splitted = parameters.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    int i = 0;
                    foreach (string param in splitted) {
                        Match subMatch = Regex.Match(param, @"((.*)\s)?(\S+)$");
                        if (subMatch.Groups.Count == 4) {
                            paramString += subMatch.Groups[3].Value;
                            csParamstring += NativeToCLRType.Convert(subMatch.Groups[2].Value, false) + " " + subMatch.Groups[3].Value;
                        } else {
                            paramString += "param" + i.ToString();
                            csParamstring += NativeToCLRType.Convert(subMatch.Groups[2].Value, false) + " " + "param" + i.ToString();
                        }

                        if (i + 1 < splitted.Length) {
                            paramString += ", ";
                            csParamstring += ", ";
                        }

                        i++;
                    }

                    cppOutputBuilder.AppendLine(string.Format("IVMP::{0}()->{1}({2});", className, methodName, paramString));
                    cppOutputBuilder.AppendLine("}");
                    cppOutputBuilder.AppendLine();

                    csOutputBuilder.AppendLine("\t\t[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]");
                    csOutputBuilder.AppendLine(string.Format("\t\tpublic static extern {0} {1}_{2}({3});", NativeToCLRType.Convert(returnType, true), className, methodName, csParamstring));
                    csOutputBuilder.AppendLine();
                    /*
                    EXPORT unsigned int Server_GetTickCount() {
	                    return IVMP::Server()->GetTickCount();
                    }*/
                }
            }

            csOutputBuilder.AppendLine("\t}");
            csOutputBuilder.AppendLine("}");

            cppOutput.Text = cppOutputBuilder.ToString();
            csOutput.Text = csOutputBuilder.ToString();
        }
    }
}
