/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // random number generator
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "Year: 1870 \nPlace: Frontier \n \nYou" +
                         " are working on the farm with you papa and hear a b" +
                         "ig noise in the distance";
            redLabel.Text = "Tell him";
            blueLabel.Text = "Leave it";
            greenlabel.Text = "";

            //display initial message and options
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 3; }
                if (scene == 3) { scene = 4; }
                if (scene == 4) { scene = 5; }

                

                }
                else if (e.KeyCode == Keys.B)  //blue button press
                {
                    if (scene == 0) { scene = 2; }
                    if (scene == 4) { scene = 5; }
                    if (scene == 3) { scene = 4; }
                }
                else if (e.KeyCode == Keys.C)  //green
                {

                }

                /// Display text and game options to screen based on the current scene
                switch (scene)
                {
                    case 0:  //start scene 
                        outputLabel.Text = "Year: 1870 /n Place: Frontier /n /n You" +
                            " are working on the farm with you papa and hear a b" +
                            "ig noise in the distance";
                        redLabel.Text = "Tell him";
                        blueLabel.Text = "Leave it";
                        break;
                    case 1:
                        outputLabel.Text = "He also hears it but before he can react " +
                            "bandits attack your farm! They shoot papa and all the cows. " +
                            "You notice a scar the eye of the head bandit";
                        redLabel.Text = "continue";
                        blueLabel.Text = "";
                        break;
                    case 2:
                        outputLabel.Text = "bandits attack your farm and shoot papa and all the cows" +
                             "You notice a scar the eye of the head bandits";
                        redLabel.Text = "continue";
                        blueLabel.Text = "";
                        break;
                    case 3:
                        outputLabel.Text = "9 years later";
                        redLabel.Text = "continue";
                        blueLabel.Text = "";
                        break;
                    case 4:
                        outputLabel.Text = "You are sitting in a bar drowning your sorrows" +
                            "when you overhear some guys talking about a crew a bandits named the bad boys." +
                            "You hear one of them mention that the leader of this gang's name has a scar" +
                            "over his eye. 'they call him Scar Face Magee' one of the men said";
                        redLabel.Text = "Be kind and ask";
                        blueLabel.Text = "intimidate";

                        break;
                    case 5:
                        outputLabel.Text = "They tell you to frig off and you drink until you get" +
                              " alcohol posioning";
                        redLabel.Text = "Retart";
                        blueLabel.Text = "Exit";
                        break;
                    case 6:
                        outputLabel.Text = "They tell you about a group called the Bad Boys with a" +
                            " leader they hear has a scar on his eye";

                        redLabel.Text = "continue";
                        blueLabel.Text = "";
                        break;
                    case 7:
                        outputLabel.Text = "an ol man smoking his pipe in the corner looks at you" +
                            "and fixes his hat 'The bad boys burned down my farm... I want" +
                            "nothin more than to take them down";
                        redLabel.Text = "open up to him";
                        blueLabel.Text = "stay to yourself and ask where the hideout is";
                        break;
                    case 8:
                        outputLabel.Text = "you too? the man says as he sits up in his chair, " +
                            "I know where they're hideout is and could tell you where it is as long" +
                            " as I can come with you too get em'";
                        redLabel.Text = "sure";
                        blueLabel.Text = "Nope";
                        break;
                    case 9:
                        outputLabel.Text = "";
                        break;
                    default:
                        break;
                }
            }

         
        }

    }

