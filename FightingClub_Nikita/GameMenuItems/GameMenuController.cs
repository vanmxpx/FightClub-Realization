using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameProcess.BL.Args;
using GameProcess.BL.Common.Args;
using GameProcess.BL.Fighters;

namespace FightingClub_Nikita.GameMenuItems
{
    public class GameMenuController
    {
        public GameMenuForm MenuForm { get; private set; }
        public GameMenuController()
        {
            MenuForm = new GameMenuForm();
        }

        #region Log Messages
        internal void Message(object sender, MessageEventArgs e)
        {
            MenuForm.AddItemToLog(e.Message);
            MenuForm.SetRound($"Round {e.Round}:");
        }

        internal void Block(object sender, FighterEventArgs e)
        {
            MenuForm.AddItemToLog($"Player {e.Name} blocked the hit!");
            MenuForm.SetStatus($"{e.Name} blocked the hit!");
        }

        internal void Wound(object sender, DamageEventArgs e)
        {
            MenuForm.AddItemToLog($"Player {((BasePlayer)sender).Name} received {e.Damage} {e.BodyPart} damage!");
            MenuForm.SetStatus($"{((BasePlayer)sender).Name} get {e.Damage}dmg");
        }

        internal void Struck(object sender, DamageEventArgs e)
        {
            MenuForm.AddItemToLog($"Player {((BasePlayer)sender).Name} hit in {e.BodyPart}.");
        }

        internal void Death(object sender, FighterEventArgs e)
        {
            MenuForm.AddItemToLog($"Player {e.Name} is dead...");
        }

        internal void Win(object sender, FighterEventArgs e)
        {
            MenuForm.AddItemToLog($"Our winner is {e.Name}. Congratulations!");
            MenuForm.SetStatus($"{e.Name} WIN!");
        }
        #endregion
    }

}
