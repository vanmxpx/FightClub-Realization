using FightingClub_Nikita.GameMenuItems;
using FightingClub_Nikita.PlayerItems;
using FightingClub_Nikita.Properties;
using GameProcess.BL;
using GameProcess.BL.Common.Args;
using GameProcess.BL.Common.Constants;
using GameProcess.BL.Fighters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public class Presenter
    {
        private IFighting _process;
    
        private readonly IGameMenuForm _menu;

        List<IPlayerView> _players = new List<IPlayerView>();
        public Presenter(GameMenuController menu, IFighting _process)
        {
            this._process = _process;
            this._menu = menu;

            _players.Add(new PlayerController(_process.Player1, Resources.Fighter1));
            _players.Add(new PlayerController(_process.Player2, Resources.Fighter2));

            _players[0].SetViewPosition(-168);
            _players[1].SetViewPosition(168);

            SuscribeMenu();
            SuscribePlayers();

            _process.StartGame();
        }

        #region Subscriptions
        private void SuscribePlayers()
        {
            _players[0].ProcessStep += ProcessRound;
            _players[1].ProcessStep += ProcessRound;
        }
        private void SuscribeMenu()
        {
            _process.Message += _menu.Message;
            _process.Player1.Blocked += _menu.Block;
            _process.Player1.Wounded += _menu.Wound;
            _process.Player1.Struck += _menu.Struck;
            _process.Player1.Death += _menu.Death;
            _process.Player1.Winner += _menu.Win;

            _process.Player2.Blocked += _menu.Block;
            _process.Player2.Wounded += _menu.Wound;
            _process.Player2.Struck += _menu.Struck;
            _process.Player2.Death += _menu.Death;
            _process.Player2.Winner += _menu.Win;
        }
        #endregion

        private void ProcessRound(object sender, EventArgs e)
        {
            if(_players[0].SelectedPart != BodyParts.None 
                && _players[1].SelectedPart != BodyParts.None)
            {
                _process.MakeStep(_players[0].SelectedPart, _players[1].SelectedPart);
                _players[0].RefreshView();
                _players[1].RefreshView();
            }
        }
    }
}
