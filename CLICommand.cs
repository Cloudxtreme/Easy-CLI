using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIFoundation
{
    /// <summary>
    /// A class for the command object this library works with
    /// </summary>
    public class CLICommand
    {
        public String name { get; set; }
        public String[] parameters { get; set; }

        /// <summary>
        /// Construct class
        /// </summary>
        /// <param name="command"></param>
        public CLICommand(String command)
        {
            // Split the command string into segments by space
            String[] cmd = command.Split(' ');
            // Set the name property
            this.name = cmd[0];

            // If there are no parameters, set parameters to null
            if (cmd.Length < 2)
            {
                parameters = null;
            }
            else
            {
                // Iterate over parameters and save them into the parameters array
                parameters = new String[cmd.Length - 1];
                for (int i = 1; i < cmd.Length; i++)
                {
                    parameters[i - 1] = cmd[i];
                }
            }
        }

        /// <summary>
        /// Return true if the command's name matches the input
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool Equals(String text)
        {
            if (this.name.Equals(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Return true i the command's name matches the input (ignoring case)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool EqualsIgnoreCase(String text)
        {
            if (this.name.ToLower().Equals(text.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Return true if the command has parameters
        /// </summary>
        /// <returns></returns>
        public bool hasParams()
        {
            if (this.parameters != null && this.parameters.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
