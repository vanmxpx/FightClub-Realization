using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProcess.BL.Args;
using GameProcess.BL.Common.Args;
using GameProcess.BL.Fighters;

namespace FightingClub_Nikita.GameMenuItems
{
    public interface IGameMenuForm
    {
        void Message(object sender, MessageEventArgs e);
        void Block(object sender, FighterEventArgs e);
        void Wound(object sender, DamageEventArgs e);
        void Struck(object sender, DamageEventArgs e);
        void Death(object sender, FighterEventArgs e);
        void Win(object sender, FighterEventArgs e);
    }
}
