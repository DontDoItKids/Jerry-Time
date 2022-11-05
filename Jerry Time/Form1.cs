using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Reflection;
using System.Windows.Forms;
namespace Jerry_Time
{

    public partial class Form1 : Form
    {
        
        bool showed = false;

        Random rndTop = new Random();
        Random rndBottom = new Random();

        private void ShowMessageBox(string message)
        {
            if (!showed)
            {
                MessageBox.Show(message);
            }
            showed = true;
        }


        public Form1()
        {
            InitializeComponent();

            PipesTimer.Enabled = true;
            PipesTimer.Interval = 1;

            Collision.Enabled = true;
            Collision.Interval = 1;

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

                BottomSquare.Height -= NewTop;
            }

           
           

        }

        private void Collision_Tick(object sender, EventArgs e)
        {

            //https://social.msdn.microsoft.com/Forums/en-US/2b815e39-da66-49dd-94b9-13384e424f3e/c-object-following-the-mouse?forum=csharplanguage
            Point mouse = PointToClient(MousePosition);
            myBox.Location = new Point(mouse.X - 40, mouse.Y - 40);


            //https://stackoverflow.com/questions/33846662/c-sharp-detect-picturebox-overlap
            bool overlapTop = myBox.Bounds.IntersectsWith(TopSquare.Bounds);
            bool overlapBottom = myBox.Bounds.IntersectsWith(BottomSquare.Bounds);

            if (overlapTop == true)
            {
                myBox.Top = 380;

                Collision.Enabled = false;
                PipesTimer.Enabled = false;
            }

            if (overlapBottom == true)
            {
                myBox.Top = 380;
           
               Collision.Enabled = false;
               PipesTimer.Enabled = false;

            }




            
            
        }
    }
}