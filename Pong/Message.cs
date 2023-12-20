using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pong
{

    //Create Massage box
    public static class Message
    {

        //Find sound folder
        private static string FindPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        private static SoundPlayer WinSound = new SoundPlayer($"{FindPath}\\Sounds\\WinSong(Original).wav");


        //Exit Massage box
        public static bool Exit()
        {
            string message = "Do you Want to exit?";
            string title = "Exit Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        // Reset Massage box
        public static bool Reset(int Winner)
        {
            string message;

            WinSound.Play();

            if (Winner == 1)
            {
                message = "Player 1 won, do you Want to play again?";
            }
            else
            {
                message = "Player 2 won, do you Want to play again?";

            }
            string title = "Play Again";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == DialogResult.Yes)
            {
                //Close music
                WinSound.Stop();
                WinSound.Dispose();

                //Return to reset game
                return true;
            }
            else
            {
                //Close music
                WinSound.Stop();
                WinSound.Dispose();

                //Return to go back to main menu
                return false;

            }
        }

    }
}
