using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Plugin;

namespace Plugin_CMD
{
    [Export(typeof(IPlugin))] // Needed as we are using the MEF framework for plugins
    public class Plugin_CMD : IPlugin
    {
        public void Message(string topic, string message)
        {
            // This is where you do all your program logic
            Console.WriteLine("Topic: " + topic);
            Console.WriteLine("Message: " + message);
            //TODO: switch/case on the message and topic where topic=Command and message is the command to execute

        }

        public string Name
        {
            // This will be the name of the Plugin that M2MCaster knows it by
            get {return "Command Executor"; }
        }
    }
}
