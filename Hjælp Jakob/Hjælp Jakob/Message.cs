using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
    public class Message
    {
        private string to;
        public string To
        {
            get { return to; }
            set { to = value; }
        }
        private string from;
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        private string messageBody;
        public string MessageBody
        {
            get { return messageBody; }
            set { messageBody = value; }
        }
        private string subject;
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        private string cc;
        public string Cc
        {
            get { return cc; }
            set { cc = value; }
        }

        public Message(string to, string from, string msgBody, string subject, string cc)
        {
            this.To = to;
            this.From = from;
            this.MessageBody = msgBody;
            this.Subject = subject;
            this.Cc = cc;
        }
    }
}
