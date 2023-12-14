using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp___03___03
{
    public class ChatMessage
    {
        public ChatMessage(string sender, string message)
        {
            this.Sender = sender;
            this.Message = message;
            this.Timestamp = DateTime.Now.Date.ToString("d");
        }

        public string Timestamp { get; set; }

        public string Message { get; set; }

        public string Sender { get; set; }
    }
}
