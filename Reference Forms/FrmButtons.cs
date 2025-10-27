using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Practice__Windows_Form_App_What_I_know_so_far__
{
    public partial class FrmButtons : Form
    {
        public FrmButtons()
        {
            InitializeComponent();
        }
        
        private void FrmButtons_Load(object sender, EventArgs e)
        {
            TxtBoxScore.Visible = false;
            LblScore.Visible = false;
            btnSubCount.Visible = true;
            BtnAddCount.Visible = true;
        }

        //This variable tracks the number of button clicks.
        int BtnClickCount = 0;
        int endBtnClickCount = 0;
        /*----------------------------------------------------------------------------------------------------*/
        //Stage 1 button clicked bools.
        bool Btn1Clicked = false, Btn2Clicked = false, Btn3Clicked = false,
            Btn4Clicked = false, Btn5Clicked = false, Btn6Clicked = false,
            Btn7Clicked = false, Btn8Clicked = false, Btn9Clicked = false,
            Btn10Clicked = false;
        /*----------------------------------------------------------------------------------------------------*/
        //Stage 2 button clicked bools.
        bool Btn11Clicked = false, Btn12Clicked = false, Btn13Clicked = false,
            Btn14Clicked = false, Btn15Clicked = false, Btn16Clicked = false,
            Btn17Clicked = false, Btn18Clicked = false, Btn19Clicked = false,
            Btn20Clicked = false;
        /*----------------------------------------------------------------------------------------------------*/
        bool Btn21Clicked = false, Btn22Clicked = false, Btn23Clicked = false,
            Btn24Clicked = false, Btn25Clicked = false, Btn26Clicked = false,
            Btn27Clicked = false, Btn28Clicked = false, Btn29Clicked = false,
            Btn30Clicked = false;
        /*----------------------------------------------------------------------------------------------------*/
        //Messages used in the game.
        string loadingMessage = "Loading Game...";
        string loadingStageOneMessage = "Loading Stage 1...";
        string loadingStageTwoMessage = "Loading Stage 2...";
        string loadingStageThreeMessage = "Loading Stage 3...";
        string welcomeMessage = "Welcome to the Button Clicking Game!\n\n"
            + "Instructions:\n"
            + "1. Click the 'Start' button to begin Stage 1 (Easy).\n"
            + "2. In each stage, click all buttons within the allowed number of clicks to proceed to the next stage.\n"
            + "3. If you exceed the allowed clicks, you will lose and can reset the stage.\n"
            + "4. Use the 'Reset Stage' buttons to restart a specific stage or 'Reset All Stages' to start over from Stage 1.\n"
            + "5. Good luck and have fun!";
        string resetStageMessage = "Resetting current stage...";
        string resetStage1Message = "Stage 1 has been reset.";
        string resetStage2Message = "Stage 2 has been reset.";
        string resetStage3Message = "Stage 3 has been reset.";
        string resetAllStagesMessage = "Resetting all stages...";
        string resetAllStagesCompleteMessage = "All stages have been reset.";
        string stageOneWinMessage = "You won Stage 1! \n";
        string stageTwoWinMessage = "You won Stage 2! \n";
        string stageThreeWinMessage = "You won Stage 3! \n";
        string winGameMessage = "Congratulations! \nYou win!\nI hope you enjoyed my button clicker game! :)";
        string loseMessage = "You lose!\nTry again.";
        string stageOneInstruct = "Stage 1 (Easy):\nClick all buttons in 10 clicks or less\nto proceed to Stage 2.";
        string stageTwoInstruct = "Stage 2 (Hard):\nClick all buttons in 20 clicks or less\nto proceed to Stage 3.";
        string stageThreeInstruct = "Stage 3: (Impossible):\nClick all buttons in 30 clicks or less\nto win the game!";
        string endBtnClickScore = "Your score is: ";

        private void BtnStart_Click(object sender, EventArgs e)
        {   //Display loading message.
            MessageBox.Show(loadingMessage);
            //Show stage 1 group box, Score & reset buttons.
            GrpBox1.Visible = true;
            LblScore.Visible = true;
            TxtBoxScore.Visible = true;
            BtnResetStage1.Visible = true;
            BtnLvlAllReset.Visible = true;
            //Hide other reset buttons.
            BtnResetStage2.Visible = false; BtnResetStage3.Visible = false;
            //Hide other group boxes and start button.
            GrpBox2.Visible = false; GrpBox3.Visible = false; BtnStart.Visible = false;
            //Display welcome message & instructions.
            MessageBox.Show(welcomeMessage);
            //Show stage 1 reset button.
            MessageBox.Show(stageOneInstruct);
            //Reset click count.
            BtnClickCount = 0;
        }


        //This section contains the button click events for stage 1.
        //Refer to comments in (Btn1_Click-Btn10_Click) for explanation of code logic for other buttons.
        /*----------------------------------------------------------------------------------------------------*/
        private void Btn1_Click(object sender, EventArgs e)
        {   
            Btn1.Visible = false;       //Hide clicked button.
            Btn1Clicked = true;         //Mark button as clicked.
            BtnClickCount++;            //Increment score by 1.
            //BtnClickCount++;          //Simulate extra click for testing lose condition.
            //Update score display.
            TxtBoxScore.Text = BtnClickCount.ToString();    
            // Check for win condition.
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked &&Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {   //Hide GrpBox1 and GrpBox3.
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                //User wins stage 1.
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                //Show stage 2 reset button and hide others.
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                //Notify user stage 2 is loading.
                MessageBox.Show(loadingStageTwoMessage);
                //Show stage 2 group box.
                GrpBox2.Visible = true;
                //Inform user of stage 2 instructions.
                MessageBox.Show(stageTwoInstruct);
            }
                // Check for lose condition.
            else if (TxtBoxScore.Text == "10")      
            {   
                MessageBox.Show(loseMessage);       //User loses stage 1.
                BtnResetStage1_Click(sender, e);    //Reset stage 1.
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Btn2.Visible = false;
            Btn2Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage); 
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Btn3.Visible = false;
            Btn3Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Btn4.Visible = false;
            Btn4Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            Btn5.Visible = false;
            Btn5Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            Btn6.Visible = false;
            Btn6Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            Btn7.Visible = false;
            Btn7Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            Btn8.Visible = false;
            Btn8Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            Btn9.Visible = false;
            Btn9Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }
        private void Btn10_Click(object sender, EventArgs e)
        {
            Btn10.Visible = false;
            Btn10Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn1Clicked && Btn2Clicked && Btn3Clicked && Btn4Clicked
                && Btn5Clicked && Btn6Clicked && Btn7Clicked && Btn8Clicked
                && Btn9Clicked && Btn10Clicked && BtnClickCount <= 10)
            {
                GrpBox1.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = true; BtnResetStage3.Visible = false;
                MessageBox.Show(loadingStageTwoMessage);
                GrpBox2.Visible = true;
                MessageBox.Show(stageTwoInstruct);

            }
            else if (TxtBoxScore.Text == "10")
            {
                MessageBox.Show(loseMessage);
                BtnResetStage1_Click(sender, e);
            }
        }




        //This section contains the button click events for stage 2.
        //Refer to comments in (Btn11_Click-Btn20_Click) for explanation of code logic.
        /*----------------------------------------------------------------------------------------------------*/
        private void Btn11_Click(object sender, EventArgs e)
        {
            Btn11.Visible = false;      //Hide clicked button.
            Btn11Clicked = true;        //Mark button as clicked.
            BtnClickCount++;            //Increment score by 1.
            //BtnClickCount++;          //Simulate extra click for testing lose condition.
            //Update score display.
            TxtBoxScore.Text = BtnClickCount.ToString();
            // Check for win condition.
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {   //Hide GrpBox1 and GrpBox2.
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                //User wins stage 2.
                MessageBox.Show(stageTwoWinMessage + endBtnClickScore + BtnClickCount.ToString());
                //Show stage 3 reset button and hide others.
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                //Notify user stage 3 is loading.
                MessageBox.Show(loadingStageThreeMessage);
                //Show stage 3 group box.
                GrpBox3.Visible = true;
                //Inform user of stage 2 instructions.
                MessageBox.Show(stageThreeInstruct);
            }
            // Check for lose condition.
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;             //Show group box 2.
                MessageBox.Show(loseMessage);       //User loses stage 2.
                BtnResetStage2_Click(sender, e);    //Reset stage 2.           
                BtnClickCount = 10;                 //Reset click count to 10 for stage 2.
            }
        }
        private void Btn12_Click(object sender, EventArgs e)
        {
            Btn12.Visible = false;     
            Btn12Clicked = true;        
            BtnClickCount++;           
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {   
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);       
                BtnResetStage2_Click(sender, e);            
                BtnClickCount = 10;                
            }
        }
        private void Btn13_Click(object sender, EventArgs e)
        {
            Btn13.Visible = false;
            Btn13Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }
        private void Btn14_Click(object sender, EventArgs e)
        {
            Btn14.Visible = false;
            Btn14Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }
        private void Btn15_Click(object sender, EventArgs e)
        {
            Btn15.Visible = false;
            Btn15Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }
        private void Btn16_Click(object sender, EventArgs e)
        {
            Btn16.Visible = false;
            Btn16Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }
        private void Btn17_Click(object sender, EventArgs e)
        {
            Btn17.Visible = false;
            Btn17Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }
        private void Btn18_Click(object sender, EventArgs e)
        {
            Btn18.Visible = false;
            Btn18Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }
        private void Btn19_Click(object sender, EventArgs e)
        {
            Btn19.Visible = false;
            Btn19Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }
        private void Btn20_Click(object sender, EventArgs e)
        {
            Btn20.Visible = false;
            Btn20Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn11Clicked && Btn12Clicked && Btn13Clicked && Btn14Clicked
                && Btn15Clicked && Btn16Clicked && Btn17Clicked && Btn18Clicked
                && Btn19Clicked && Btn20Clicked && BtnClickCount <= 20)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false;
                MessageBox.Show(stageOneWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = true;
                MessageBox.Show(loadingStageThreeMessage);
                GrpBox3.Visible = true;
                MessageBox.Show(stageThreeInstruct);
            }
            else if (TxtBoxScore.Text == "20")
            {
                GrpBox2.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage2_Click(sender, e);
                BtnClickCount = 10;
            }
        }





        //This section contains the button click events for stage 3.
        //Refer to comments in (Btn21_Click-Btn30_Click) for explanation of code logic.
        /*----------------------------------------------------------------------------------------------------*/
        private void Btn21_Click(object sender, EventArgs e)
        {
            Btn21.Visible = false;      //Hide clicked button.
            Btn21Clicked = true;        //Mark button as clicked.
            BtnClickCount++;            //Increment score by 1.
            //BtnClickCount++;          //Simulate extra click for testing lose condition.
            //Update score display.
            TxtBoxScore.Text = BtnClickCount.ToString();
            // Check for win condition.
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {   //Hide all group boxes.
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                //User wins stage 3.
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                //Show stage 3 reset button and hide others.
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                //Inform user of winning the game.
                MessageBox.Show(winGameMessage);
                //Reset score display.
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                //Shows Play Again button.
                BtnPlayAgain.Visible = true;
            }
            // Check for lose condition.
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;             //Show group box 3.
                MessageBox.Show(loseMessage);       //User loses stage 3.
                BtnResetStage3_Click(sender, e);    //Reset stage 3.           
                BtnClickCount = 20;                 //Reset click count to 20 for stage 3.
            }
        }
        private void Btn22_Click(object sender, EventArgs e)
        {
            Btn22.Visible = false;
            Btn22Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {   
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;    
                MessageBox.Show(loseMessage);      
                BtnResetStage3_Click(sender, e);           
                BtnClickCount = 20;              
            }
        }
        private void Btn23_Click(object sender, EventArgs e)
        {
            Btn23.Visible = false;
            Btn23Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }
        private void Btn24_Click(object sender, EventArgs e)
        {
            Btn24.Visible = false;
            Btn24Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }
        private void Btn25_Click(object sender, EventArgs e)
        {
            Btn25.Visible = false;
            Btn25Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }
        private void Btn26_Click(object sender, EventArgs e)
        {
            Btn26.Visible = false;
            Btn26Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }

        private void Btn27_Click(object sender, EventArgs e)
        {
            Btn27.Visible = false;
            Btn27Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }
        private void Btn28_Click(object sender, EventArgs e)
        {
            Btn28.Visible = false;
            Btn28Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }
        private void Btn29_Click(object sender, EventArgs e)
        {
            Btn29.Visible = false;
            Btn29Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }
        private void Btn30_Click(object sender, EventArgs e)
        {
            Btn30.Visible = false;
            Btn30Clicked = true;
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
            if (Btn21Clicked && Btn22Clicked && Btn23Clicked && Btn24Clicked
                && Btn25Clicked && Btn26Clicked && Btn27Clicked && Btn28Clicked
                && Btn29Clicked && Btn30Clicked && BtnClickCount <= 30)
            {
                GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
                MessageBox.Show(stageThreeWinMessage + endBtnClickScore + BtnClickCount.ToString());
                BtnResetStage1.Visible = false; BtnResetStage2.Visible = false;
                BtnResetStage3.Visible = false; BtnLvlAllReset.Visible = false;
                MessageBox.Show(winGameMessage);
                BtnClickCount = 0;
                TxtBoxScore.Text = "0";
                BtnPlayAgain.Visible = true;
            }
            else if (TxtBoxScore.Text == "30")
            {
                GrpBox3.Visible = true;
                MessageBox.Show(loseMessage);
                BtnResetStage3_Click(sender, e);
                BtnClickCount = 20;
            }
        }



        //This section resets each stage individually or all stages at once.
        /*----------------------------------------------------------------------------------------------------*/
        private void BtnResetStage1_Click(object sender, EventArgs e)
        {   //Reset all stage 1 BtnXClicked bools to false.
            Btn1Clicked = false; Btn2Clicked = false; Btn3Clicked = false; Btn4Clicked = false; Btn5Clicked = false;
            Btn6Clicked = false; Btn7Clicked = false; Btn8Clicked = false; Btn9Clicked = false; Btn10Clicked = false;
            //Make all buttons visible.
            Btn1.Visible = true; Btn2.Visible = true; Btn3.Visible = true; Btn4.Visible = true; Btn5.Visible = true;
            Btn6.Visible = true; Btn7.Visible = true; Btn8.Visible = true; Btn9.Visible = true; Btn10.Visible = true;
            //Hide stage 1 group boxes.
            GrpBox1.Visible = false;
            //Reset click count and score display.
            TxtBoxScore.Text = "0";
            BtnClickCount = 0;
            TxtBoxScore.Text = BtnClickCount.ToString();
            //Notify user of reset in progress.
            MessageBox.Show(resetStageMessage);
            //Show stage 1 group box.
            GrpBox1.Visible = true;
            //Notify user of reset completeion.
            MessageBox.Show(resetStage1Message);
        }
        private void BtnResetStage2_Click(object sender, EventArgs e)
        {   //Reset all stage 2 BtnXClicked bools to false.
            Btn11Clicked = false; Btn12Clicked = false; Btn13Clicked = false; Btn14Clicked = false; Btn15Clicked = false;
            Btn16Clicked = false; Btn17Clicked = false; Btn18Clicked = false; Btn19Clicked = false; Btn20Clicked = false;
            //Make all stage 1 buttons visible.
            Btn11.Visible = true; Btn12.Visible = true; Btn13.Visible = true; Btn14.Visible = true; Btn15.Visible = true;
            Btn16.Visible = true; Btn17.Visible = true; Btn18.Visible = true; Btn19.Visible = true; Btn20.Visible = true;
            //Hide stage 2 group boxes.
            GrpBox2.Visible = false;
            //Reset click count and score display.
            TxtBoxScore.Text = "10";
            BtnClickCount = 10;
            TxtBoxScore.Text = BtnClickCount.ToString();
            //Notify user of reset in progress.
            MessageBox.Show(resetStageMessage);
            //Show stage 2 group box.
            GrpBox2.Visible = true;
            //Notify user of reset completeion.
            MessageBox.Show(resetStage2Message);
        }

        private void BtnResetStage3_Click(object sender, EventArgs e)
        {   //Reset all stage 3 BtnXClicked bools to false.
            Btn21Clicked = false; Btn22Clicked = false; Btn23Clicked = false; Btn24Clicked = false; Btn25Clicked = false;
            Btn26Clicked = false; Btn27Clicked = false; Btn28Clicked = false; Btn29Clicked = false; Btn30Clicked = false;
            //Make all stage 2 buttons visible.
            Btn21.Visible = true; Btn22.Visible = true; Btn23.Visible = true; Btn24.Visible = true; Btn25.Visible = true;
            Btn26.Visible = true; Btn27.Visible = true; Btn28.Visible = true; Btn29.Visible = true; Btn30.Visible = true;
            //Hide stage 3 group boxes.
            GrpBox3.Visible = false;
            //Reset click count and score display.
            TxtBoxScore.Text = "20";
            BtnClickCount = 20;
            TxtBoxScore.Text = BtnClickCount.ToString();
            //Notify user of reset in progress.
            MessageBox.Show(resetStageMessage);
            //Show stage 3 group box.
            GrpBox3.Visible = true;
            //Notify user of reset completeion.
            MessageBox.Show(resetStage3Message);
        }
        private void BtnLvlAllReset_Click(object sender, EventArgs e)
        {   //Reset all stage 1, 2 & 3 BtnXClicked bools to false.
            Btn1Clicked = false; Btn2Clicked = false; Btn3Clicked = false; Btn4Clicked = false; Btn5Clicked = false;
            Btn6Clicked = false; Btn7Clicked = false; Btn8Clicked = false; Btn9Clicked = false; Btn10Clicked = false;
            Btn11Clicked = false; Btn12Clicked = false; Btn13Clicked = false; Btn14Clicked = false; Btn15Clicked = false;
            Btn16Clicked = false; Btn17Clicked = false; Btn18Clicked = false; Btn19Clicked = false; Btn20Clicked = false;
            Btn21Clicked = false; Btn22Clicked = false; Btn23Clicked = false; Btn24Clicked = false; Btn25Clicked = false;
            Btn26Clicked = false; Btn27Clicked = false; Btn28Clicked = false; Btn29Clicked = false; Btn30Clicked = false;
            //Make all stage 1, 2 & 3 buttons visible.
            Btn1.Visible = true; Btn2.Visible = true; Btn3.Visible = true; Btn4.Visible = true; Btn5.Visible = true;
            Btn6.Visible = true; Btn7.Visible = true; Btn8.Visible = true; Btn9.Visible = true; Btn10.Visible = true;
            Btn11.Visible = true; Btn12.Visible = true; Btn13.Visible = true; Btn14.Visible = true; Btn15.Visible = true;
            Btn16.Visible = true; Btn17.Visible = true; Btn18.Visible = true; Btn19.Visible = true; Btn20.Visible = true;
            Btn21.Visible = true; Btn22.Visible = true; Btn23.Visible = true; Btn24.Visible = true; Btn25.Visible = true;
            Btn26.Visible = true; Btn27.Visible = true; Btn28.Visible = true; Btn29.Visible = true; Btn30.Visible = true;
            //Hide all group boxes.
            GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
            //Hide reset buttons.
            BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = false;
            //Reset click count and score display.
            BtnClickCount = 0;
            TxtBoxScore.Text = "0";
            TxtBoxScore.Text = BtnClickCount.ToString();
            //Hide reset all button.
            BtnLvlAllReset.Visible = false;
            //Notify user of reset in progress.
            MessageBox.Show(resetAllStagesMessage);
            //Notify user of reset completion.
            MessageBox.Show(resetAllStagesCompleteMessage);
            //Show start button.
            BtnStart.Visible = true;
            
        }
        //This section acts as a "resetAll" AFTER willing the game.
        /*----------------------------------------------------------------------------------------------------*/
        private void BtnPlayAgain_Click(object sender, EventArgs e)
        {
            //Reset all stage 1, 2 & 3 BtnXClicked bools to false.
            Btn1Clicked = false; Btn2Clicked = false; Btn3Clicked = false; Btn4Clicked = false; Btn5Clicked = false;
            Btn6Clicked = false; Btn7Clicked = false; Btn8Clicked = false; Btn9Clicked = false; Btn10Clicked = false;
            Btn11Clicked = false; Btn12Clicked = false; Btn13Clicked = false; Btn14Clicked = false; Btn15Clicked = false;
            Btn16Clicked = false; Btn17Clicked = false; Btn18Clicked = false; Btn19Clicked = false; Btn20Clicked = false;
            Btn21Clicked = false; Btn22Clicked = false; Btn23Clicked = false; Btn24Clicked = false; Btn25Clicked = false;
            Btn26Clicked = false; Btn27Clicked = false; Btn28Clicked = false; Btn29Clicked = false; Btn30Clicked = false;
            //Make all stage 1, 2 & 3 buttons visible.
            Btn1.Visible = true; Btn2.Visible = true; Btn3.Visible = true; Btn4.Visible = true; Btn5.Visible = true;
            Btn6.Visible = true; Btn7.Visible = true; Btn8.Visible = true; Btn9.Visible = true; Btn10.Visible = true;
            Btn11.Visible = true; Btn12.Visible = true; Btn13.Visible = true; Btn14.Visible = true; Btn15.Visible = true;
            Btn16.Visible = true; Btn17.Visible = true; Btn18.Visible = true; Btn19.Visible = true; Btn20.Visible = true;
            Btn21.Visible = true; Btn22.Visible = true; Btn23.Visible = true; Btn24.Visible = true; Btn25.Visible = true;
            Btn26.Visible = true; Btn27.Visible = true; Btn28.Visible = true; Btn29.Visible = true; Btn30.Visible = true;
            //Hide all group boxes.
            GrpBox1.Visible = false; GrpBox2.Visible = false; GrpBox3.Visible = false;
            //Hide reset buttons.
            BtnResetStage1.Visible = false; BtnResetStage2.Visible = false; BtnResetStage3.Visible = false;
            //Reset click count and score display.
            BtnClickCount = 0;
            TxtBoxScore.Text = "0";
            TxtBoxScore.Text = BtnClickCount.ToString();
            //Hide reset all button.
            BtnLvlAllReset.Visible = false;
            //Hides Play Agian button.
            BtnPlayAgain.Visible = false;
            //Notify user of reset in progress.
            MessageBox.Show(resetAllStagesMessage);
            //Notify user of reset completion.
            MessageBox.Show(resetAllStagesCompleteMessage);
            //Show start button.
            BtnStart.Visible = true;
            
        }
        private void BtnAddCount_Click(object sender, EventArgs e)
        {
            BtnClickCount++;
            TxtBoxScore.Text = BtnClickCount.ToString();
        }
        private void BtnSubCount_Click(object sender, EventArgs e)
        {
            BtnClickCount--;
            TxtBoxScore.Text = BtnClickCount.ToString();
        }
        private void TxtBoxScore_TextChanged(object sender, EventArgs e)
        {
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {   //Closes the form/application.
            Close();
        }
    }
}
