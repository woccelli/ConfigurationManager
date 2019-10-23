using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.IO;

namespace ConfigurationManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the serializer
            Serializer ser = new Serializer();
            string path = string.Empty;
            string xmlInputData = string.Empty;
            string xmlOutputData = string.Empty;

            //specify the .xml filepath and read the content of the file
            path = Directory.GetCurrentDirectory() + @"\..\..\XMLFile1.xml";
            xmlInputData = File.ReadAllText(path);

            //construct a ConfigGlobal Object from th xml data
            ConfigGlobal cg1 = ser.Deserialize<ConfigGlobal>(xmlInputData);
            xmlOutputData = ser.Serialize<ConfigGlobal>(cg1);

            //build and invoke the PS commands of the different ConfigOptions
            cg1.LaunchPSCmds();
            
        }
    }
}
