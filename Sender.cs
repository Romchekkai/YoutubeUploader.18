using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeUploader._18
{
    class Sender
    {
        Command Command { get; set; }
        public void SetCommand(Command command)
        {
            Command = command;
        }
        public void Start()
        {
            Command.Start();
        }
        public void Cancel()
        {
            Command.Cancel();
        }
    }
}
