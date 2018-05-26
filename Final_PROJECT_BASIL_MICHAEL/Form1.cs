using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_PROJECT_BASIL_MICHAEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbBoard.Focus();
            
            
       

           KeyDown += new KeyEventHandler(Form1_KeyDown);
        this.KeyPreview = true;
    }
        
        void Form1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.W)
        {
            if (mySnake.direction != 2)
            {
                mySnake.direction = 1;
            }

        }
        else if (e.KeyCode == Keys.S)
        {
            if (mySnake.direction != 1)
            {
                mySnake.direction = 2;
            }

        }
        else if (e.KeyCode == Keys.A)
        {
            if (mySnake.direction != 4)
            {
                mySnake.direction = 3;
            }

        }
        else if (e.KeyCode == Keys.D)
        {
            if (mySnake.direction != 3)
            {
                mySnake.direction = 4;
            }
        }
        
    }


        int highscore = 0;
        bool paused = false;

        Snake mySnake = new Snake();

        public class Snake
        {
            public int currentscore = 0;
            public List<SnakeParts> Nagini = new List<SnakeParts>();
            public int direction; // 1: up  2: down 3: Left  4:Right
            public bool gameover = false;

            //Default Constructor
            public Snake()
            {
                SnakeParts head = new SnakeParts();
                Nagini.Add(head);
                direction = 1;               
            }

            public bool Move()   //return true successful move else false
            {
                int CurrentHeadX, CurrentHeadY, NewHeadX=0, NewHeadY=0;

                CurrentHeadX = Nagini[0].GetXPosition();
                CurrentHeadY = Nagini[0].GetYPosition();

                if (direction == 1)  // up
                {

                    NewHeadX = CurrentHeadX;

                    NewHeadY = CurrentHeadY - 1;
                    
                }
                else if (direction == 2)  //down
                {
                    NewHeadX = CurrentHeadX;

                    NewHeadY = CurrentHeadY +1;
                }
                else if (direction == 3) //left
                {
                    NewHeadX = CurrentHeadX-1;

                    NewHeadY = CurrentHeadY ;
                }
                else if (direction ==4)  // right
                {
                    NewHeadX = CurrentHeadX+1;

                    NewHeadY = CurrentHeadY ;

                }

                if (NewHeadX < 0 || NewHeadX > 63 || NewHeadY < 0 || NewHeadY > 24)
                {
                    gameover = true;
                    return false;
                }
                else
                {
                    SnakeParts newHead = new SnakeParts(NewHeadX, NewHeadY);

                    Nagini.Insert(0, newHead);
                    Nagini.RemoveAt(Nagini.Count - 1);
                    gameover = false;
                    return true;
                }
            }

          
            public void DrawSnake(Graphics g)
            {
                for (int i=0; i<Nagini.Count;i++)
                {
                    SolidBrush Brush = new SolidBrush(Nagini[i].clr);

                    g.FillRectangle(Brush, Nagini[i].GetXPosition()*20, Nagini[i].GetYPosition()*20, 20, 20);
                }
            }
            public bool SelfCollide()
            {
                
               for(int a = 1; a < Nagini.Count; a++)
               {
                   if (Nagini[0].GetXPosition() == Nagini[a].GetXPosition() && Nagini[0].GetYPosition() == Nagini[a].GetYPosition())
                   {
                       gameover = true;
                       return true;                                            
                   }
                 
                }
               return false;
            }

            public void StartGame()
            {
                gameover = false;
                currentscore = 0;
                direction = 1;
                Nagini.Clear();
                Snake head = new Snake();
                int NewPartX = 32, NewPartY = 13;
                SnakeParts newPart = new SnakeParts(NewPartX, NewPartY);
                Nagini.Insert(0,newPart);
                Food food = new Food();
                food.GenerateFood();
            }

            public void Grow()
            {
              int NewPartX = 0, NewPartY = 0, CurrentPartX, CurrentPartY;
              
                CurrentPartX = Nagini[0].GetXPosition();
                CurrentPartY = Nagini[0].GetYPosition();

                if (direction == 1)  // up
                {

                    NewPartX = CurrentPartX;

                    NewPartY = CurrentPartY - 1;
                }
                else if (direction == 2)  //down
                {
                    NewPartX = CurrentPartX;

                    NewPartY = CurrentPartY +1;

                }
                else if (direction == 3) //left
                {
                    NewPartX = CurrentPartX-1;

                    NewPartY = CurrentPartY ;
                }
                else if (direction == 4)  // right
                {
                    NewPartX = CurrentPartX+1;

                    NewPartY = CurrentPartY ;

                }

                SnakeParts newPart = new SnakeParts(NewPartX, NewPartY);

                Nagini.Insert(0, newPart);
            }
            public int getXPosition()
            {
               int x = Nagini[0].GetXPosition();
               return x;
            }
            public int getYPosition()
            {
                int y = Nagini[0].GetYPosition();
                return y;
            }
            public int setXPostition(int x)
            {
                x = Nagini[0].GetXPosition();

                return x;
            }
            public int setYPosition(int y)
            {
                y = Nagini[0].GetYPosition();
                return y;
            }
        }

        public void GameOver()
        {
            int currentscore;
            currentscore = mySnake.currentscore;
            if(currentscore > highscore)
            {
                highscore = currentscore;
                lbHighScore.Text = Convert.ToString(currentscore);
            }
            GameTimer.Stop();           
        }
       

        public class Food
        {
            public int X;
            public int Y;
            public bool Eaten;
            Color clr;
            Random rnd = new Random();
            Snake snake = new Snake();
            public Food()
            {
                X = 20;
                Y = 20;
                clr = Color.Orange;
                Eaten = false;
            }
            public void DrawFood(Graphics g)
            {
                SolidBrush Brush = new SolidBrush(Color.Orange);

                g.FillEllipse(Brush, X*20, Y*20, 20, 20);
            }
            public void GenerateFood()
            {
                int max_steps_x = 64;
                int max_steps_y = 25;
                X = rnd.Next(0, max_steps_x);
                Y = rnd.Next(0, max_steps_y);
            }
         
        }
        
        public class SnakeParts
        {
            protected int xPosition;
            protected int yPosition;
            public Color clr;

            //Default Constructor creates initial head
            public SnakeParts()
            {
                xPosition = 32;
                yPosition = 12;
                clr = Color.Black;
            }


            // Constructor to create body parts given the coordinated
            public SnakeParts(int X, int Y)
            {
                xPosition = X;
                yPosition = Y;
                clr = Color.Black;
            }
            public int GetXPosition()
            {
                return xPosition;
            }
            public void SetXPosition(int Px)
            {
                xPosition = Px;                
            }
             public int GetYPosition()
            {
                return yPosition;
            }
            public void SetYPosition(int Py)
             {
                 yPosition = Py;
             }
        }
        Food food = new Food();
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;
            btnStop.Enabled = true;
            btnRestart.Enabled = true;
            GameTimer.Start();
            paused = false;
            rbFast.Enabled = false;
            rbSlow.Enabled = false;
            rbMedium.Enabled = false;
            
        }

        private void pbBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            mySnake.DrawSnake(g);
            food.DrawFood(g);
            bool bhighscore = false;
            if (mySnake.gameover == true)
            {
                using (Font myFont = new Font("Arial", 30))
                {
                    e.Graphics.DrawString("GAMEOVER!", myFont, Brushes.Red, new Point(580, 250));
                    btnRestart.Enabled = true;
                    btnPause.Enabled = false;

                }
                using (Font myFont = new Font("Arial", 10))
                {
                    e.Graphics.DrawString("Press Restart then Start to continue!", myFont, Brushes.Black, new Point(600, 300));

                }
            }

            if(paused ==true)
            {
                using (Font myFont = new Font("Arial", 30))
                {
                    e.Graphics.DrawString("PAUSED!", myFont, Brushes.Purple, new Point(520, 250));

                }
                using (Font myFont = new Font("Arial", 10))
                {
                    e.Graphics.DrawString("Press Start to continue Playing!", myFont, Brushes.Black, new Point(530, 300));

                }
            }

            if (mySnake.currentscore - 10 == (highscore))
            {
                HighscoreTimer.Start();
                bhighscore = true;
            }
            else
            {
                HighscoreTimer.Stop();
                bhighscore = false;
            }

            if(bhighscore == true)
            {

                using (Font myFont = new Font("Arial", 30))
                {
                    e.Graphics.DrawString("NEW HIGH SCORE!", myFont, Brushes.Purple, new Point(520, 100));

                }
            }


        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            paused = true;
            pbBoard.Invalidate();
            rbFast.Enabled = true;
            rbSlow.Enabled = true;
            rbMedium.Enabled = true;

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            bool SafeMove;


            SafeMove=mySnake.Move();
            pbBoard.Invalidate();


            if (SafeMove == false)
            {
                GameTimer.Stop();
                GameOver();

                
            }
            else if(mySnake.SelfCollide() == true)
            {
                GameOver();
            }
            else
            {
               
                if(mySnake.currentscore > 0)
                {
                    mySnake.SelfCollide();
                }

                if (mySnake.getXPosition() == food.X && mySnake.getYPosition() == food.Y)
                {

                    food.Eaten = true;
                    mySnake.currentscore = mySnake.currentscore + 10;
                    mySnake.Grow();
                    lbCurrentScore.Text = mySnake.currentscore.ToString();
                }
                else
                {
                    food.Eaten = false;
                }

                if (food.Eaten == true)
                {
                    food.GenerateFood();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mySnake.StartGame();
            btnPause.Enabled = false;
            btnRestart.Enabled = false;
            btnStart.Enabled = true;
            GameTimer.Stop();
            paused = false;
            rbFast.Enabled = true;
            rbSlow.Enabled = true;
            rbMedium.Enabled = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            mySnake.StartGame();
            btnRestart.Enabled = false;
            btnStop.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            GameTimer.Stop();
            mySnake.currentscore = 0;
            lbCurrentScore.Text = mySnake.currentscore.ToString();
            paused = false;
            rbFast.Enabled = true;
            rbSlow.Enabled = true;
            rbMedium.Enabled = true;
            food.GenerateFood();
        }

        private void pbBoard_Click(object sender, EventArgs e)
        {

        }

        private void rbSlow_CheckedChanged(object sender, EventArgs e)
        {
            GameTimer.Interval = 200;
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            GameTimer.Interval = 100;
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbFast_CheckedChanged_1(object sender, EventArgs e)
        {
            GameTimer.Interval = 60;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Highscore.snk|*.snk";
                saveFileDialog1.Title = "Save Highscore";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);

                    BinaryWriter binWriter = new BinaryWriter(fs);
                    int score = Convert.ToInt32(lbHighScore.Text);
                    binWriter.Write(score);
                    fs.Close();
                    binWriter.Close();

                }
            }
            catch
            {
                MessageBox.Show("ERROR: File save error, try again!");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Highscore.snk|*.snk";
                openFileDialog1.Title = "Load Highscore";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    BinaryReader binReader = new BinaryReader(fs);

                    int score = binReader.ReadInt32();

                    lbHighScore.Text = score.ToString();
                    highscore = score;

                    fs.Close();
                    binReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("ERROR: File read error, try again!");
            }
        }
    }
}