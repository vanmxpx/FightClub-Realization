using GameProcess.BL.Common.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingClub_Nikita.PlayerItems
{
    public interface IPlayerView
    {
        BodyParts SelectedPart { get; }
        event EventHandler ProcessStep;

        void RefreshView();
        void SetViewPosition(int offset);
    }
}
