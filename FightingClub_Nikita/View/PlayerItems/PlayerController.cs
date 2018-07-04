using System;
using System.Drawing;
using System.Windows.Forms;
using GameProcess.BL.Common.Args;
using GameProcess.BL.Common.Constants;
using GameProcess.BL.Fighters;

namespace FightingClub_Nikita.PlayerItems
{
    public class PlayerController: IPlayerView
    {
        public BodyParts SelectedPart { get; private set; } = BodyParts.None;
        public event EventHandler ProcessStep;

        private BasePlayer _player;
        private PlayerForm _form;
        private bool _computer;
        public PlayerController(BasePlayer player, Bitmap fighterPic)
        {
            // Настройка игрока
            this._player = player;
            this._player.Death += ViewDead;
            this._player.Winner += ViewWin;

            _computer = player is CPUPlayer;
            if (_computer) SelectedPart = BodyParts.Random;

            // Подключение формы
            _form = new PlayerForm(_computer);
            _form.InitializePlayer(player, fighterPic);
            _form.BodyPartSelected += FinishStep;
            _form.Show();
        }

        public void RefreshView()
        {
            _form.RefreshPlayer(_player);
            if(!_computer)
                SelectedPart = BodyParts.None;
        }

        public void SetViewPosition(int offset)
        {
            int widthMiddle = (Screen.PrimaryScreen.Bounds.Width - _form.Width) / 2;
            int heightMiddle = (Screen.PrimaryScreen.Bounds.Height - _form.Height) / 2;
            _form.Location = new Point(widthMiddle + offset, heightMiddle - 200);
        }

        private void ViewWin(object sender, FighterEventArgs e)
        {
            _form.EndGame(true);
        }

        private void ViewDead(object sender, FighterEventArgs e)
        {
            _form.EndGame(false);
        }
        private void FinishStep(object sender, BodyPartEventArgs e)
        {
            SelectedPart = e.Part;
            ProcessStep?.Invoke(sender, EventArgs.Empty);
        }
    }
}