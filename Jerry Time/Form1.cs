using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Reflection;
using System.Windows.Forms;
namespace Jerry_Time
{

    public partial class Form1 : Form
    {
        Random rndTop = new Random();

        int BBCord;
        int TBCord;
        int Distance;
        int Score = 0;
        int HighScore = 0;
        

        Bitmap bmpSmile = new Bitmap("..\\..\\..\\Resources\\Smiley.png");
        Bitmap bmpUnSmile = new Bitmap ("..\\..\\..\\Resources\\UnSmiley.png");
        
        

        public Form1()
        {
            InitializeComponent();

            btnRestart.Enabled = false;
            btnRestart.Visible = false;
        }

        private void myBox_Click(object sender, EventArgs e)
        {
            
        }

        private void PipesTimer_Tick(object sender, EventArgs e)
        {

            TopSquare.Left -= 10;

            BottomSquare.Left -= 10;
            
            if(TopSquare.Left == -100)
            {
                TopSquare.Left = 800;
                TopSquare.Height = 153;

                int NewTop = rndTop.Next(-50, 51);

                TopSquare.Height += NewTop;


                BottomSquare.Left = 800;
                BottomSquare.Height = 276;

                BottomSquare.Height += (NewTop - 0);
                BottomSquare.Top += (NewTop - 0);

                
                if (HighScore == Score)
                {
                    HighScore++;
                    Score++;
                }
                else
                {
                    Score++;
                }

                lblScore.Text = "Score: " + Score.ToString();
                lblHighScore.Text = "High Score: " + HighScore.ToString();

            }

        }

        private void Collision_Tick(object sender, EventArgs e)
        {

            //https://social.msdn.microsoft.com/Forums/en-US/2b815e39-da66-49dd-94b9-13384e424f3e/c-object-following-the-mouse?forum=csharplanguage
            //Point mouse = PointToClient(MousePosition);
            //myBox.Location = new Point(mouse.X - 30, mouse.Y - 30);


            //https://stackoverflow.com/questions/33846662/c-sharp-detect-picturebox-overlap
            bool overlapTop = myBox.Bounds.IntersectsWith(TopSquare.Bounds);
            bool overlapBottom = myBox.Bounds.IntersectsWith(BottomSquare.Bounds);


            TBCord = TopSquare.Bottom;
            BBCord = BottomSquare.Top;

            Distance = BBCord - TBCord;
            lblDistance.Text = Distance.ToString();


            if (overlapTop == true)
            {
                myBox.Top = 380;

                Collision.Enabled = false;
                PipesTimer.Enabled = false;

                btnRestart.Visible = true;
                btnRestart.Enabled = true;

                myBox.Image = bmpUnSmile;
            }

            if (overlapBottom == true)
            {
                myBox.Top = 380;
           
                Collision.Enabled = false;
                PipesTimer.Enabled = false;

                btnRestart.Visible = true;
                btnRestart.Enabled = true;

                myBox.Image = bmpUnSmile;
            }

            if (Distance < 95)
            {
                BottomSquare.Top += 20;
            }

            if (Distance > 160)
            {
                BottomSquare.Top -= 20;
            }

            if (Score >= 100)
            {
                MessageBox.Show("Get a life");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            PipesTimer.Enabled = true;
            PipesTimer.Interval = 1;

            Collision.Enabled = true;
            Collision.Interval = 1;

            Gravity.Enabled = true;
            Gravity.Interval = 2;

            btnStart.Enabled = false;
            btnStart.Visible = false;

            lblControls.Visible = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            TopSquare.Left = 800;
            BottomSquare.Left = 800;

            PipesTimer.Enabled = true;
            PipesTimer.Interval = 1;

            Collision.Enabled = true;
            Collision.Interval = 1;

            Gravity.Enabled = true;
            Gravity.Interval = 2;

            btnRestart.Enabled = false;
            btnRestart.Visible = false;

            Score = 0;
            lblScore.Text = "Score: " + Score.ToString();

            myBox.Image = bmpSmile;
            myBox.Location = new Point(357, 203);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            myBox.Top -= 32;
            
        }

        private void Gravity_Tick(object sender, EventArgs e)
        {
            myBox.Top += 2;
            

            
        }
    }
}