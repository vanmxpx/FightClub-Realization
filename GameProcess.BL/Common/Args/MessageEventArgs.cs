using System;

namespace GameProcess.BL.Args
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public int Round { get; private set; }

        public MessageEventArgs(string message, int round)
        {
            Message = message;
            Round = round;
        }
    }
}