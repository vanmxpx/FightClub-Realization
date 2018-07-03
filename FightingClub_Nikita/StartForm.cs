using FightingClub_Nikita.Properties;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }


        private void butStart_Click(object sender, System.EventArgs e)
        {
            Settings.Default.Name = textBoxSetName.Text;
            Close();
        }

        private void textBoxSetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode || Keys.Escape == e.KeyCode)
            {
                Settings.Default.Name = textBoxSetName.Text;
                Close();
            }
        }
    }
}
