using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationManager
{
    /// <summary>
    /// abstract class to give a similar structure to all children configuration option classes
    /// created to ease the ConfigOptions manipulation in GlobalConfig.cs
    /// </summary>
    public abstract class ConfigOption
    {
        /// <summary>
        /// unique ConfigOption ID
        /// </summary>
        public string ConfigOptionID { get; set; }

        /// <summary>
        /// functon used to build, invoke and display the results of PS commands
        /// The attributes of the class are used to build the commands 
        /// </summary>
        public abstract void InvokePSCmd();
    }
}
