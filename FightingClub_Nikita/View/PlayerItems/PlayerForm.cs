using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameProcess.BL.Common.Args;
using GameProcess.BL.Common.Constants;
using GameProcess.BL.Fighters;

namespace FightingClub_Nikita.PlayerItems
{
    public partial class PlayerForm : Form
    {
        public event EventHandler<BodyPartEventArgs> BodyPartSelected;
        public PlayerForm(bool disabled)
        {
            InitializeComponent();

            if (disabled) ToggleButtons(false);
        }

        private void ToggleButtons(bool enabled)
        {
            this.btnBody.Enabled = enabled;
            this.btnHead.Enabled = enabled;
            this.btnLeg.Enabled = enabled;
        }

        public void EndGame(bool winner)
        {
            if (winner)
            {
                this.lblEnd.Text = "Winner!";
                this.lblEnd.ForeColor = Color.Green;
            }
            else
            {
                this.lblEnd.Text = "Dead...";
                this.lblEnd.ForeColor = Color.Red;
            }
            this.lblEnd.Visible = true;
            ToggleButtons(false);
        }

        public void InitializePlayer(BasePlayer player, Bitmap fighterPic)
        {
            this.playerPicture.Image = fighterPic;
            this.lblName.Text = player.Name;
            RefreshPlayer(player);
        }

        internal void RefreshPlayer(BasePlayer player)
        {
            this.lblHP.Text = player.HealthPoints.ToString();
            this.progressBarHealth.Value = player.HealthPoints;
            this.lblStatus.Text = player.RoundAction.ToString();
        }

        private void BodyButton_Clicked(object sender, EventArgs e)
        {
            switch ( ((Button)sender).Text )
            {
                case "Head":
                    BodyPartSelected?.Invoke(this, new BodyPartEventArgs(BodyParts.Head));
                    break;
                case "Body":
                    BodyPartSelected?.Invoke(this, new BodyPartEventArgs(BodyParts.Body));
                    break;
                case "Leg":
                    BodyPartSelected?.Invoke(this, new BodyPartEventArgs(BodyParts.Leg));
                    break;
                default:
                    BodyPartSelected?.Invoke(this, new BodyPartEventArgs(BodyParts.None));
                    break;
            }
        }
    }
}
