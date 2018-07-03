using GameProcess.BL.Args;
using GameProcess.BL.Common.Constants;
using GameProcess.BL.Fighters;
using System;
using System.Collections.Generic;

namespace GameProcess.BL
{
    public interface IFighting
    {
        BasePlayer Player1
        {
            get;
        }
        BasePlayer Player2
        {
            get;
        }
        int Round
        {
            get;
        }
        
        event EventHandler<MessageEventArgs> Message;
        void StartGame();
        void MakeStep(BodyParts partPlayer1, BodyParts partPlayer2);
    }
}
