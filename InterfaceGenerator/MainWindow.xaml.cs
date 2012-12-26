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

namespace InterfaceGenerator {
    public class MethodInfo {
        public string Name { get; set; }
        public int ParameterCount { get; set; }
        public string Parameters { get; set; }
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
            StringBuilder outputBuilder = new StringBuilder();
            string[] lines = input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, List<MethodInfo>> methods = new Dictionary<string, List<MethodInfo>>();

            outputBuilder.AppendLine("namespace IvmpDotNet.Sdk {");

            foreach (string line in lines) {
                Match m = Regex.Match(line, Properties.Resources.ParsingPattern);
                if (m.Success) {
                    List<MethodInfo> methodList;
                    if (!methods.TryGetValue(m.Groups[1].Value, out methodList))
                        methods.Add(m.Groups[1].Value, methodList = new List<MethodInfo>());

                    methods[m.Groups[1].Value].Add(new MethodInfo() {
                        Name = m.Groups[2].Value,
                        ParameterCount = Convert.ToInt32(m.Groups[3].Value),
                        Parameters = m.Groups[4].Value
                    });
                }
            }

            foreach (KeyValuePair<string, List<MethodInfo>> methodGroup in methods) {
                outputBuilder.AppendLine(string.Format("\tpublic interface {0} {{", methodGroup.Key));

                foreach (MethodInfo method in methodGroup.Value) {
                    StringBuilder paramStringBuilder = new StringBuilder();
                    int paramCount = 1;
                    foreach (char param in method.Parameters) {
                        switch (param) {
                            case 'f':
                                paramStringBuilder.Append("float");
                                break;
                        }

                        paramStringBuilder.Append(string.Format("param{0}", paramCount));

                        if (method.Parameters.Length > paramCount)
                            paramStringBuilder.Append(", ");

                        paramCount++;
                    }

                    outputBuilder.AppendLine(string.Format("\t\tobject {0}({1});", method.Name, paramStringBuilder.ToString()));
                }

                outputBuilder.AppendLine("\t}");
                outputBuilder.AppendLine();
            }

            outputBuilder.AppendLine("}");

            outputTxt.Text = outputBuilder.ToString();
        }
    }
}
