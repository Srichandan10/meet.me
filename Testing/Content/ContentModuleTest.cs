using NUnit.Framework;
using Content;

/*
namespace Content
{
    public class SendMessageData
    {
        /// <summary>
        ///     Message string if MessageType is Chat else file path if MessageType is File
        /// </summary>
        public string Message;

        /// <summary>
        ///     List of ids for receivers, empty in case of broadcast
        /// </summary>
        public int[] ReceiverIds;

        /// <summary>
        ///     Id of the thread if message belongs to an already existing thread else -1
        /// </summary>
        public int ReplyThreadId;

        /// <summary>
        ///     Message Type - File or Chat
        /// </summary>
        public MessageType Type;
    }
} 

using System;
using System.Collections.Generic;

namespace Content
{
    public class ChatContext
    {
        /// <summary>
        ///     Time of creation of thread
        /// </summary>
        public DateTime CreationTime;

        /// <summary>
        ///     List of all the messages in the thread
        /// </summary>
        public List<ReceiveMessageData> MsgList;

        /// <summary>
        ///     Number of messages in the thread
        /// </summary>
        public int NumOfMessages;

        /// <summary>
        ///     Id of the thread
        /// </summary>
        public int ThreadId;
    }
}

using System;

namespace Content
{
    [Serializable]
    public class ReceiveMessageData
    {
        /// <summary>
        ///     Message Event - Update, NewMessage, Star, Download
        /// </summary>
        public MessageEvent Event;

        /// <summary>
        ///     Message string if messageType is Chat else file name for File messageType
        /// </summary>
        public string Message;

        /// <summary>
        ///     Id of the message
        /// </summary>
        public int MessageId;

        /// <summary>
        ///     List of ids for receviers, all if empty
        /// </summary>
        public int[] ReceiverIds;

        /// <summary>
        ///     Id of thread to which this message belongs
        /// </summary>
        public int ReplyThreadId;

        /// <summary>
        ///     User id of the message sender
        /// </summary>
        public int SenderId;

        /// <summary>
        ///     Time at which message was sent
        /// </summary>
        public DateTime SentTime;

        /// <summary>
        ///     True if this message is starred else False
        /// </summary>
        public bool Starred;

        /// <summary>
        ///     Message Type - File or Chat
        /// </summary>
        public MessageType Type;
    }
}
*/
namespace Testing.Content
{
    [TestFixture]
    public class ContentModuleTesting
    {
        [SetUp]
        public void SetUp()
        {

        }


        
        
        [Test]
        public void CSend_PrivateMsgFromUserAToUserBInChatFormat_sentMsgMustBeEqualToRcvMsg()
        {
            Assert.Pass();
        }

        [Test]
        public void CSend_PrivateMsgFromUserAToUserBInFileFormat_sentMsgMustBeEqualToRcvMsg()
        {
            Assert.Pass();
        }
    }
}
