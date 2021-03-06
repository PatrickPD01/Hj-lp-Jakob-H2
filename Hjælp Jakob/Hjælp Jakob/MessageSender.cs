using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
    class MessageSender
    {
        //This class simulates sending messages to one person or to everyone
        public class msgSender 
        {
            public bool sendMessage(MessageCarrier type, Message m, bool isHTML)
            {
                bool isSent = false;
                //herinde sendes der en email ud til modtageren
                if (type.Equals(MessageCarrier.Smtp))
                {
                    if (isHTML)
                        m.MessageBody = ConvertText.ConvertBodyToHTML(m.MessageBody);
                    //her implementeres alt koden til at sende via Smtp
                    isSent = true;
                }

                if (type.Equals(MessageCarrier.VMessage))
                {
                    if (isHTML)
                        m.MessageBody = ConvertText.ConvertBodyToHTML(m.MessageBody);
                    //her implementeres alt koden til at sende via VMessage
                    isSent = true;
                }
                return isSent;
            }
            public bool sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
            {
                bool isSent = false;
                if (type.Equals(MessageCarrier.Smtp))
                {
                    if (isHTML)
                        m.MessageBody = ConvertText.ConvertBodyToHTML(m.MessageBody);
                    //her implementeres alt koden til at sende via Smtp
                    isSent = true;
                }

                if (type.Equals(MessageCarrier.VMessage))
                {
                    if (isHTML)
                        m.MessageBody = ConvertText.ConvertBodyToHTML(m.MessageBody);
                    //her implementeres alt koden til at sende via VMessage
                    isSent = true;
                }
                return isSent;
            }
        }
    }
}
