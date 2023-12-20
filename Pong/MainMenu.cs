using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pong
{
    public partial class MainMenu : Form
    {
        //If multiplayer are on or not and the same for endless mode
        private bool multiplayer = false, Endless = false;

        string FindPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        SoundPlayer MainTheme;


        public MainMenu()
        {
            InitializeComponent();
            //Find Music
            MainTheme = new SoundPlayer($"{FindPath}\\Sounds\\MainTheme(Original).wav");

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

            //Fast game and Solo mode button are desabled because it is the default mode
            btnFast.Enabled = false;
            btnSolo.Enabled = false;

            //Change the colors to show what is on and off
            btnFast.BackColor = Color.Orange;
            btnSolo.BackColor = Color.Orange;
            btnMulti.BackColor = Color.DimGray;
            btnEnd.BackColor = Color.DimGray;

            //Play music
            MainTheme.Play();


        }

        //When click on multiplayer mode button
        private void btnMulti_Click(object sender, EventArgs e)
        {
            //Enable the Solo mode button and disable button the multiplayer
            btnSolo.Enabled = true;
            btnMulti.Enabled = false;

            //Activate the multiplayer mode
            multiplayer = true;

            //Change colors to reflect change
            btnMulti.BackColor = Color.Orange;
            btnSolo.BackColor = Color.DimGray;


        }

        private void btnSolo_Click(object sender, EventArgs e)
        {
            //Disable the Solo mode button and enable the multiplayer
            btnSolo.Enabled = false;
            btnMulti.Enabled = true;

            //Desactivate the multiplayer mode
            multiplayer = false;

            //Change colors to reflect change
            btnSolo.BackColor = Color.Orange;
            btnMulti.BackColor = Color.DimGray;



        }

        private void btnFast_Click(object sender, EventArgs e)
        {
            //Disable the Fast game button and enable the endless mode
            btnFast.Enabled = false;
            btnEnd.Enabled = true;

            //Disable the endless game
            Endless = false;

            //Change colors to reflect change
            btnFast.BackColor = Color.Orange;
            btnEnd.BackColor = Color.DimGray;


        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //Disable the Fast game button and enable the endless mode
            btnFast.Enabled = true;
            btnEnd.Enabled = false;

            //Enable the endless game
            Endless = true;

            //Change colors to reflect change
            btnFast.BackColor = Color.DimGray;
            btnEnd.BackColor = Color.Orange;

        }

        //button to start game
        private void btnStart_Click(object sender, EventArgs e)
        {
            //Change to tutorial screen
            Tutorial TT = new Tutorial(multiplayer, Endless); //Give the information about wich modes are activated
            TT.Show();
            this.Close();
        }

        //Close music
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainTheme.Stop();
            MainTheme.Dispose();
        }

 
        //Play music again when opened
        private void MainMenu_Shown(object sender, EventArgs e)
        {
            MainTheme.Play();

        }


    
    }
}
