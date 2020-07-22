using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //West
        int Redtimer;
        int Yellowtimer;
        int Greentimer;
        bool TurnRedCompleted = false;
        bool TurnYellowCompleted = false;
        bool TurnGreenCompleted = false;
        int Redcount;
        int Yellowcount;
        int Greencount;
        // South
        int Redtimer_South;
        int Greentimer_South;
        int Yellowtimer_South;
        bool TurnGreenCompleted_South = false;
        bool TurnYellowCompleted_South = false;
        bool TurnRedCompleted_South = false;
        int Redcount_South;
        int Greencount_South;
        int Yellowcount_South;


        //East


        int Redtimer_East;
        int Greentimer_East;
        int Yellowtimer_East;
        bool TurnGreenCompleted_East = false;
        bool TurnYellowCompleted_East = false;
        bool TurnRedCompleted_East = false;
        int Redcount_East;
        int Greencount_East;
        int Yellowcount_East;



        //North



        int Redtimer_North;
        int Greentimer_North;
        int Yellowtimer_North;
        bool TurnGreenCompleted_North = false;
        bool TurnYellowCompleted_North = false;
        bool TurnRedCompleted_North = false;
        int Redcount_North;
        int Greencount_North;
        int Yellowcount_North;



        //A new enemy approach!

        int enemycar;
        bool resetTrafficLight;
        //testing

        int testamount;
        int testamount2;
        bool testturn;



        bool testturn_South;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

          
                UpdateTimePseudo.Start();
            
            // UpdateTimePseudoSouth.Start();
            //  UpdateTimePseudoEast.Start();
            //  UpdateTimePseudoNorth.Start();
            
        }

        private void timerYellow_Tick(object sender, EventArgs e)
        {
          
            YellowLight.BackColor = Color.Yellow;
            Yellowtimer++;
            if (Yellowtimer == 2)
            {
                YellowLight.BackColor = Color.Gray;
                timerYellow.Stop();
                Yellowtimer = 0;
                Yellowcount++;
            }
        }
        private void timerRed_Tick(object sender, EventArgs e)
        {
            RedLight.BackColor = Color.Red;
            Redtimer++;
            if (Redtimer == 4)
            {
                RedLight.BackColor = Color.Gray;
                timerRed.Stop();
                Redtimer = 0;
                Redcount++;
            }
        }
        private void timerGreen_Tick(object sender, EventArgs e)
        {
            GreenLight.BackColor = Color.Green;
                Greentimer++;
                if (Greentimer == 4)
                {
                    GreenLight.BackColor = Color.Gray;
                    timerGreen.Stop();
                    Greentimer = 0;
                    Greencount++;
                }
        }

        //private void testing(object sender)
        //{
             
        //            Button b = (Button)sender;
        //            b.BackColor = Color.Red;
        //            Redtimer++;
        //            if (Redtimer == 4)
        //            {
        //                b.BackColor = Color.Gray;
        //                Redtimer = 0;
        //            Redcount++;
        //            }
        //}
        private void Pseudo_UpdateTick(object sender, EventArgs e)
        {
            // remember its an update function who is tickign 1 per sec!

            //testamount++;

            //if (testamount < 3)
            //{
            //    testing(RedLightEast);
            //}


            //if (testamount < 1)
            //{

            //    testing(RedLightSouth);

            //}

            {

                if (Redcount == 2)
                {
                    TurnRedCompleted = true;
                }
                if (Greencount == 1)
                {
                    TurnGreenCompleted = true;
                }
                if (Yellowcount == 1)
                {
                    TurnYellowCompleted = true;
                }
                // Order
                if (!TurnRedCompleted)
                {
                    timerRed.Start();
                }
                else if (!TurnGreenCompleted)
                {
                    timerGreen.Start();
                }
                else if (!TurnYellowCompleted)
                {
                    timerYellow.Start();
                }
                else
                {
                    TurnRedCompleted = false;
                    TurnYellowCompleted = false;
                    TurnGreenCompleted = false;
                    Redcount = 0;
                    Yellowcount = 0;
                    Greencount = 0;
                }
            }

            // South 
            if (Redcount_South == 2)
            {
                TurnRedCompleted_South = true;
            }
            if (Greencount_South == 1)
            {
                TurnGreenCompleted_South = true;
            }
            if (Yellowcount_South == 1)
            {
                TurnYellowCompleted_South = true;
            }
            if (!TurnGreenCompleted_South)
            {
                timerGreen_South.Start();
            }

            else if (!TurnYellowCompleted_South)
            {
                timerYellow_South.Start();
            }
            else if (!TurnRedCompleted_South)
            {
                timerRed_South.Start();
            }
            else
            {
                TurnGreenCompleted_South = false;
                TurnYellowCompleted_South = false;
                TurnRedCompleted_South = false;
                Redcount_South = 0;
                Greencount_South = 0;
                Yellowcount_South = 0;
                resetTrafficLight = true;
            }

            //  EAST

            if (Redcount_East == 2)
            {
                TurnRedCompleted_East = true;
            }
            if (Greencount_East == 1)
            {
                TurnGreenCompleted_East = true;
            }
            if (Yellowcount_East == 1)
            {
                TurnYellowCompleted_East = true;
            }


            if (!TurnRedCompleted_East)
            {
                timerRed_East.Start();
            }
            else if (!TurnGreenCompleted_East)
            {
                timerGreen_East.Start();
            }
            else if (!TurnYellowCompleted_East)
            {
                timerYellow_East.Start();
            }
            else
            {
                TurnGreenCompleted_East = false;
                TurnYellowCompleted_East = false;
                TurnRedCompleted_East = false;
                Redcount_East = 0;
                Greencount_East = 0;
                Yellowcount_East = 0;
            }



            enemycar++;
            ///North


            if (Greencount_North == 1)
            {
                TurnGreenCompleted_North = true;
            }
            if (Yellowcount_North == 1)
            {
                TurnYellowCompleted_North = true;
            }


            if (Redcount_North == 2)
            {
                TurnRedCompleted_North = true;
            }
            if (!TurnGreenCompleted_North)
            {
                timerGreen_North.Start();
            }
            else if (!TurnYellowCompleted_North)
            {
                timerYellow_North.Start();
            }
            else if (!TurnRedCompleted_North)
            {
                timerRed_North.Start();
            }
            else
            {
                Greencount_North = 0;
                Yellowcount_North = 0;
                Redcount_North = 0;
                TurnGreenCompleted_North = false;
                TurnRedCompleted_North = false;
                TurnYellowCompleted_North = false;
            }
        }

        private void timerRed_Tick_South(object sender, EventArgs e)
        {
            RedLightSouth.BackColor = Color.Red;
            Redtimer_South++;
            if (Redtimer_South == 4)
            {
                RedLightSouth.BackColor = Color.Gray;
                timerRed_South.Stop();
                Redtimer_South = 0;
                Redcount_South++;
            }
        }

        private void timerGreen_Tick_South(object sender, EventArgs e)
        {
            GreenLightSouth.BackColor = Color.Green;
            Greentimer_South++;
            if (Greentimer_South == 4)
            {
                GreenLightSouth.BackColor = Color.Gray;
                timerGreen_South.Stop();
                Greentimer_South = 0;
                Greencount_South++;
            }
        }

        private void timerYellow_Tick_South(object sender, EventArgs e)
        {
            YellowLightSouth.BackColor = Color.Yellow;
            Yellowtimer_South++;
            if (Yellowtimer_South == 2)
            {
                YellowLightSouth.BackColor = Color.Gray;
                timerYellow_South.Stop();
                Yellowtimer_South = 0;
                Yellowcount_South++;
            }
        }

        private void timerRed_Tick_East(object sender, EventArgs e)
        {
            RedLightEast.BackColor = Color.Red;
            Redtimer_East++;
            if (Redtimer_East == 4)
            {
                RedLightEast.BackColor = Color.Gray;
                timerRed_East.Stop();
                Redtimer_East = 0;
                Redcount_East++;
            }
        }

        private void timerGreen_Tick_East(object sender, EventArgs e)
        {
            GreenLightEast.BackColor = Color.Green;
            Greentimer_East++;
            if (Greentimer_East == 4)
            {
                GreenLightEast.BackColor = Color.Gray;
                timerGreen_East.Stop();
                Greentimer_East = 0;
                Greencount_East++;
            }
        }

        private void timerYellow_Tick_East(object sender, EventArgs e)
        {
            YellowLightEast.BackColor = Color.Yellow;
            Yellowtimer_East++;
            if (Yellowtimer_East == 2)
            {
                YellowLightEast.BackColor = Color.Gray;
                timerYellow_East.Stop();
                Yellowtimer_East = 0;
                Yellowcount_East++;
            }
        }

        private void timerGreen_Tick_North(object sender, EventArgs e)
        {

            GreenLightNorth.BackColor = Color.Green;
            Greentimer_North++;
            if (Greentimer_North == 4)
            {
                GreenLightNorth.BackColor = Color.Gray;
                timerGreen_North.Stop();
                Greentimer_North = 0;
                Greencount_North++;
            }
        }

        private void timerYellow_Tick_North(object sender, EventArgs e)
        {
            YellowLightNorth.BackColor = Color.Yellow;
            Yellowtimer_North++;
            if (Yellowtimer_North == 2)
            {
                YellowLightNorth.BackColor = Color.Gray;
                timerYellow_North.Stop();
                Yellowtimer_North = 0;
                Yellowcount_North++;
            }
        }

        private void timerRed_Tick_North(object sender, EventArgs e)
        {
            RedLightNorth.BackColor = Color.Red;
            Redtimer_North++;
            if (Redtimer_North == 4)
            {
                RedLightNorth.BackColor = Color.Gray;
                timerRed_North.Stop();
                Redtimer_North = 0;
                Redcount_North++;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
