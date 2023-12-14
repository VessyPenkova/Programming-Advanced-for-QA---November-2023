using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp___03___03.Chat
{
    public class ChatRoom
    {
        private readonly List<ChatMessage> _chatMessages = new();

        public void SendMessage(string sender, string message)
        {
            ChatMessage newMessage = new(sender, message);
            this._chatMessages.Add(newMessage);
        }

        public string DisplayChat()
        {
            StringBuilder sb = new();

            if (this._chatMessages.Count == 0)
            {
                return string.Empty;
            }

            sb.AppendLine("Chat Room Messages:");
            foreach (ChatMessage message in this._chatMessages)
            {
                sb.AppendLine($"{message.Sender}: {message.Message} - Sent at {message.Timestamp}");
            }

            return sb.ToString().Trim();
        }
    }

}
