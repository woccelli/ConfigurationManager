using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConfigurationManager
{
    /// <summary>
    /// class containing the list of all the specified ConfigOptions, 
    /// used to sequentially launch the PS functions of these configOption classes
    /// </summary>
    public class ConfigGlobal
    {

        /// <summary>
        /// unique Config ID
        /// </summary>
        public string ConfigID { get; set; }

        /// <summary>
        /// list of instances of ConfigOption children classes
        /// XmlArrayItem allows to identify which classes can be present in the xml input file (+ the abstract parent class)
        /// </summary>
        [XmlArray("Configs")]
        [XmlArrayItem("ConfigOption", typeof(ConfigOption))]
        [XmlArrayItem("SubConfigOption", typeof(SubConfigOption))]
        public List<ConfigOption> ConfigList { get; set; }

        /// <summary>
        /// calls the InvokePSCmd (Invoke Powershell Commands) function of each item of the ConfigList List
        /// </summary>
        public void LaunchPSCmds()
        {
            foreach(ConfigOption Cfg in ConfigList)
            {
                Cfg.InvokePSCmd();
            }
        }
    }

}
