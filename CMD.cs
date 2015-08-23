using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLIFoundation
{
    /// <summary>
    /// Wrapper class for creating a new CLICommand instance
    /// </summary>
    public sealed class CMD
    {
        /// <summary>
        /// Returns a new instance of CLICommand from input
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static CLICommand parse(String command)
        {
            CLICommand cmd = new CLICommand(command);
            return cmd;
        }
    }
}
