using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hjælp_Jakob
{
    // I made thís interface to contain all messages and fields from 
    // the "Message"-class

    public interface IMessage
    {
       string To { get; set; }
       string From { get; set; }
       string MessageBody { get; set; }
       string Subject { get; set; }
       string Cc { get; set; }
    }
}
