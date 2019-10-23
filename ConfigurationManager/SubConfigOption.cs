using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace ConfigurationManager
{
    /// <summary>
    /// Exemple of a configuration option
    /// Each attribute of the class will complete the PS commands/parameters launched in the InvokePSCmd function
    /// </summary>
    public class SubConfigOption : ConfigOption
    {
        /// <summary>
        /// first arttribute corresponding to a PS Command
        /// </summary>
        public string Attr1 { get; set; }
        /// <summary>
        /// second attribute corresponding to a PS parameter name
        /// </summary>
        public string Attr2 { get; set; }
        /// <summary>
        /// third attribute corresponding to a PS parameter value
        /// </summary>
        public string Attr3 { get; set; }

        /// <summary>
        /// uses the class attributes to build a Get-Date command and display the result in the console
        /// </summary>
        public override void InvokePSCmd()
        {
            using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                //build the PS command with parameters
                PowerShellInstance.AddCommand(Attr1).AddParameter(Attr2, Attr3);

                // invoke execution on the pipeline (collecting output)
                Collection<PSObject> PSOutput = PowerShellInstance.Invoke();

                // loop through each output object item
                foreach (PSObject outputItem in PSOutput)
                {
                    // if null object was dumped to the pipeline during the script then a null
                    // object may be present here. check for null to prevent potential NRE.
                    if (outputItem != null)
                    {
                        //TODO: do something with the output item 
                        Console.WriteLine(outputItem.BaseObject.ToString() + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Empty \n");
                    }
                    //wait for the user to interact
                    Console.WriteLine("Press a key to continue ...");
                    Console.ReadKey();
                }
            }
        }
    }
}
