using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Tutorial : Form
    {

        //Save the information about the other modes
        bool multi;
        bool endless;

        public Tutorial(bool Multi, bool Endless)
        {
            //receive the status of the modes
            multi = Multi;
             endless = Endless; 

            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //arrange the tutorial text
            label.Text = text();
        }

        //Create the tutorial text
        public String text()
        {
            //Player one tutorial text
            string TextPlayer1 = "Player 1: You are on the right. Up Arrow - Move up, Down Arrow - Move Down\n";

            String TextPlayer2 = "";
            //If multiplayer mode is enabled, it create the second player tutorial texte
            if (multi)
            {
                TextPlayer2 = "Player 2: You are on the left. W - Move up, S - Move Down\n";

            }

            string mode = "";

            //It creates the text about endless or fast mode
            if (endless == false)
            {
                mode = "Fast mode - First to make 10 points wins \n";
            }
            else
            {
                mode = "Endless mode - Endless game \n";

            }

            //explain how to exit the game
            string exit = "Press Esc to exit\n";

            //Forms the final text fusing the other texts
            string finalText = TextPlayer1 + TextPlayer2 + mode + exit;
            return finalText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Button te really start the game
        private void button1_Click(object sender, EventArgs e)
        {
            //Pass the information about the mode
            Game GM = new Game(multi,endless);
            GM.Show();
            this.Close();
        }
    }
}
