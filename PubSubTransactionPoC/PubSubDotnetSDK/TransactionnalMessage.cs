using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PubSubDotnetSDK
{

    [DataContract]
    class TransactionnalMessage
    {
        /// <summary>
        /// unique ID of dequeue transaction
        /// </summary>
        public Guid TransactionID { get; set; }


        // TODO : Replace  
        /// <summary>
        /// Message poped from output queue,and waiting for tx commit
        /// </summary>
        public PubSubMessage Message { get; set; }

        /// <summary>
        /// tiem when message was dequeue from topic output queue
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// True if subscriber commited the message
        /// </summary>
        public bool Commited { get; set; }


    }
}
