using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Settings : Form
    {
        List<string> PlayerNames;
        public Settings()
        {
            PlayerNames = new List<string>();
            if(Globals.PlayerNames != null)
            {
                foreach (string player in Globals.PlayerNames)
                {
                    PlayerNames.Add(player);
                }
            }
            
            InitializeComponent();
            refreshPlayers();
            UIMinimum.Value = Globals.minValue;
            UIMaximum.Value = Globals.maxValue;
        }
        private void refreshPlayers()
        {
            if (UIRemovePlayerBox.Items.Count != 0)
            {
                UIRemovePlayerBox.Items.Clear();
                UIRemovePlayerBox.Text = "";
            }
        UOPlayersTreeView.Nodes.Clear();
            foreach(string player in PlayerNames)
            {
                UOPlayersTreeView.Nodes.Add(player);
                UIRemovePlayerBox.Items.Add(player);
            }
        }

        private void UIAddBut_Click(object sender, EventArgs e)
        {
            string inputName = UIPlayerName.Text;
            UIPlayerName.Text = "";
            UOAddPlayerErrorLabel.Text = "";
            if(inputName == null || inputName == "" || inputName.ToCharArray()[0] == ' ')
            {
                UOAddPlayerErrorLabel.Text = "Empty Space!";
                return;
            }
            if(inputName.Length > 30)
            {
                UOAddPlayerErrorLabel.Text = "Too Lengthy!";
                return ;
            }
            foreach(char c in inputName)
            {
                if(c < 0x30 || (c < 0x41 &&  c > 0x39) || (c < 0x61 && c > 0x5A) || c > 0x7A)
                {
                    UOAddPlayerErrorLabel.Text = "Invalid character(s)!";
                    return;
                }
            }
            PlayerNames.Add(inputName);
            refreshPlayers();
        }

        private void UIRemoveBut_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerNames.RemoveAt(UIRemovePlayerBox.SelectedIndex);
        }
            catch
            {
                return ;
            }
            refreshPlayers();
        }

        private void UISaveBut_Click(object sender, EventArgs e)
        {
            if(PlayerNames.Count == 0) { return ; }
            Globals.minValue = (int)UIMinimum.Value;
            Globals.maxValue = (int)UIMaximum.Value;
            Globals.PlayerNames = PlayerNames;
            Close();
        }
    }
}
