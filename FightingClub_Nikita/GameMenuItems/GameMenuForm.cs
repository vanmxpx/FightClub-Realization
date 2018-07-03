using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightingClub_Nikita.GameMenuItems
{
    public partial class GameMenuForm : Form
    {
        public GameMenuForm()
        {
            InitializeComponent();
        }

        public void AddItemToLog(string message)
        {
            listBoxLog.Items.Add(message);
            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
        }

        public void SetRound(string message)
        {
            lblRound.Text = message; 
        }

        public void SetStatus(string message)
        {
            lblStatus.Text = message;
        }
        #region Forms' events
        private void GameMenuForm_Shown(object sender, EventArgs e)
        {
            int widthMiddle = (Screen.PrimaryScreen.Bounds.Width - Width) / 2;
            int heightMiddle = (Screen.PrimaryScreen.Bounds.Height - Height) / 2;
            Location = new Point(widthMiddle , heightMiddle + 180);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
