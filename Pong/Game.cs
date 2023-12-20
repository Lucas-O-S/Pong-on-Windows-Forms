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

    public partial class Game : Form
    {
        //Try find the path of the program
        string FindPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

        //Create the ball object
        Ball Ball = new Ball();

        //Create a object for each player
        Player player1 = new Player();
        Player player2 = new Player();

        //if multiplayer mode is off enable the ai
            bool player2ON,
        //If the player pressed up or down button
            MoveUpP1 = false, MoveUpP2 = false,
            MoveDownP1 = false, MoveDownP2 = false,
        //If endless mode are enabled or not
            endless; 

        //Center point of the screen
        Point center;

        //Sons
        SoundPlayer MakePoint;
        SoundPlayer TouchPlayer;


        //Start Components
        public Game(bool Multi, bool Endless)
        {
            //get the status of the modes
            player2ON = Multi;
            endless = Endless;
            InitializeComponent();
            //Find Sounds
            MakePoint = new SoundPlayer($"{FindPath}\\Sounds\\Points.wav");
            TouchPlayer = new SoundPlayer($"{FindPath}\\Sounds\\PlayerTouchBall.wav");


        }

        private void Game_Load(object sender, EventArgs e)
        {
            //Find the center to place the ball
            center = new Point(RightLimit.Location.X / 2, Chao.Location.Y / 2);
        }

        //Make Ball Move
        private void BallMov()
        {
            Bola.Top += Ball.YVelocity ;
            Bola.Left += Ball.XVelocity;

        }

        //Start Timer
        private void TimeAction(object sender, EventArgs e)
        {
            //Call move action
            BallMov();

            //Call Change direction
            ChangeDirection();

            //Block players to exit the screen
            BlockPlayer(Jogador1);
            BlockPlayer(Jogador2);

            //Make the """Ai""" work
            if(player2ON == false)
            {
                Player2AI();

            }

            //Move the player
            MovePlayer();

            //Verify if the limit is touched
            TouchLimit();


        }


        //This makes the direction of the ball change when the ball hits roof, Floor or Player
        private void ChangeDirection()
        {

            //Bal touche floor or roof
            if(Chao.Bounds.IntersectsWith(Bola.Bounds) || Teto.Bounds.IntersectsWith(Bola.Bounds))
            {
                //Invert the movement
                Ball.InvertY();

                if (Ball.YVelocity > 0)
                {
                    //push against the Roof to not pass through
                    Bola.Top += 10;

                }
                else
                {
                    //push against the Floor to not pass through
                    Bola.Top -= 10;

                }
                TouchPlayer.Play();


            }

            //Ball hits player
            if (Bola.Bounds.IntersectsWith(Jogador1.Bounds) || Bola.Bounds.IntersectsWith(Jogador2.Bounds))
            {
                //Acelerates ball
                Ball.Acellerate();
                //Change Y velocity
                Ball.ChangeVY();

                //Invert both
                Ball.InvertX();
                Ball.InvertY();

                //Push the ball against player to not pass through
                if (Ball.XVelocity > 0)
                {
                    Bola.Left += 10;

                }
                else
                {
                    Bola.Left -= 10;

                }
                TouchPlayer.Play();
            }


        }

        //prevent player to pass through floor or roof
        private void BlockPlayer(PictureBox Jogador)
        {
            if (Jogador.Bounds.IntersectsWith(Teto.Bounds))
            {
                Jogador.Top += 10;
            }
            if (Jogador.Bounds.IntersectsWith(Chao.Bounds))
            {
                Jogador.Top -= 10;
            }


        }

        //verify if a key was pressed
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
                //Up arrow move player 1  up
                if (e.KeyCode == Keys.Up)
                {
                    MoveUpP1 = true;
                }

                //Down arrow move player 1 down
                if (e.KeyCode == Keys.Down)
                {
                    MoveDownP1 = true;

                }

                //Verify if ai is on
                if (player2ON)
                {
                    //W move Player 2 move Up
                    if (e.KeyCode == Keys.W)
                    {
                        MoveUpP2 = true;
                    }

                //S move Player 2 move Down
                if (e.KeyCode == Keys.S)
                    {
                        MoveDownP2 = true;

                    }
                }

            //If press asc call the exit screen
            if (e.KeyCode == Keys.Escape)
            {
                //Stop timer(so all movent)
                Tempo.Stop();
                if (Message.Exit())
                {
            

                    //Exit the menu if you say yes
                    MainMenu MM = new MainMenu();
                    MM.Show();
                    this.Close();
                        
                }
                else {
                    //Timer continues
                    Tempo.Start();
                }
      
            }

            


        }

        //Move player
        private void MovePlayer()
        {
            //If Some of the values are true make the player move 
            if (MoveDownP1)
            {
                Jogador1.Top += player1.Velocity;

            }

            if (MoveUpP1)
            {
                Jogador1.Top -= player1.Velocity;

            }

            if (MoveDownP2)
            {
                Jogador2.Top += player2.Velocity;

            }

            if (MoveUpP2)
            {
                Jogador2.Top -= player2.Velocity;

            }


        }

        //Close music
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            MakePoint.Stop();
            TouchPlayer.Stop();

            MakePoint.Dispose();
            TouchPlayer.Dispose();
        }

        //The same of the key down, but disable the movement
        private void TestBall_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                MoveUpP1 = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                MoveDownP1 = false;

            }

            if (player2ON)
            {
                if (e.KeyCode == Keys.W)
                {
                    MoveUpP2 = false;
                }

                if (e.KeyCode == Keys.S)
                {
                    MoveDownP2 = false;

                }
            }
        }

        //Prevent the player to change screen size(CAN BREAK THE GAME WHE SIZE CHANGE)
        private void Game_SizeChanged(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        //Player 2 """AI"""
        private void Player2AI()
        {
            //Error chance
            Random error = new Random();

            //
            //Ball moving towards Player 1, player 2 go slow in the same high of the ball
            if (Ball.XVelocity > 0)
            {
                if (Ball.YVelocity > 0)
                {
                    Jogador2.Top += 2;

                }
                else
                {
                    Jogador2.Top -= 2;

                }
            }
            //Ball moving towards Player 2, it goes in normal speed to the ball + error chance
            if (Jogador2.Location.Y < Bola.Location.Y)
            {
                Jogador2.Top += error.Next(0, 10);

            }
            else
            {
                Jogador2.Top -= error.Next(0, 10);

            }

        }
            
  
        //If the ball touch the goal/ horizontal Limit
        private void TouchLimit()
        {
            //Touch right limit(Player 2 win one point)
            if (Bola.Bounds.IntersectsWith(RightLimit.Bounds))
            {
                //Ball go to center
                Bola.Location = center;
                
                //Invert the movement
                Ball.InvertX();
                Ball.InvertY();

                //Reset base speed
                Ball.ResetBase();

                //One point to player 2
                player2.AddPoint();
                
                //Show how many points the player have
                textP2Points.Text = $"{player2.GetPoints()}";
                MakePoint.Play();



            }

            //Touch Left limit(Player 1 win one point)
            if (Bola.Bounds.IntersectsWith(LeftLimit.Bounds))
            {
                //Ball go to center
                Bola.Location = center;

                //Invert the movement
                Ball.InvertX();
                Ball.InvertY();

                //Reset base speed
                Ball.ResetBase();

                //One point to player 1
                player1.AddPoint();

                //Show how many points the player have
                textP1Points.Text = $"{player1.GetPoints()}";
                MakePoint.Play();

            }


            //Verify if the game ended
            EndGame();

        }

        //Make the game end(If fast game is enabled)
        private void EndGame()
        {
            
            if (endless == false)
            {
                if (player1.GetPoints() >= 10 || player2.GetPoints() >= 10)
                {
          
                    //Verify who won
                    int winner;

                    if(player1.GetPoints() > player2.GetPoints()){
                        winner = 1;
                    }
                    else
                    {
                        winner = 2;

                    }

                    //Stop timer
                    Tempo.Stop();

                    //Reset Game
                    if (Message.Reset(winner))
                    {
  
                        Game GM = new Game(player2ON, endless);
                        GM.Show();
                        this.Close();
                    }

                    //Back to main menu
                    else
                    {
                        MainMenu MM = new MainMenu();
                        MM.Show();
                        this.Close();
                    }
                }

            }

        }

    }
}
