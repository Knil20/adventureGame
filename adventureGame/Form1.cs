using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();
            titleLabel.Text = "You are stuck in a pizzeria with killer animatronics. Do you Hide or do you Look Around";
            option1Label.Text = "Look around";
            option2Label.Text = "Hide";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;

            }
            else if (page == 3)
            {
                page = 5;

            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 11;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 1;

            }
            else if (page == 8)
            {
                page = 1;

            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;

            }
            else if (page == 12)
            {
                page = 13;

            }
            else if (page == 13)
            {
                page = 4;

            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 20;
            }
            else if (page == 17)
            {
                page = 20;

            }
            else if (page == 18)
            {
                page = 1;

            }
            else if (page == 19)
            {
                page = 24;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 21)
            {
                page = 1;

            }
            else if (page == 22)
            {
                page = 20;

            }
            else if (page == 23)
            {
                page = 25;

            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 1;

            }
            else if (page == 28)
            {
                page = 1;

            }

            switch (page)
            {
                case 1:
                    titleLabel.Text = "You are stuck in a pizzeria with killer animatronics. Do you Hide or do you Look Around";
                    option1Label.Text = "Look around";
                    option2Label.Text = "Hide";
                    break;
                case 2:
                    titleLabel.Text = "You find a security office";
                    option1Label.Text = "Stay";
                    option2Label.Text = "Keep Looking";
                    break;
                case 3:
                    titleLabel.Text = "You hide under a table";
                    option1Label.Text = "Stay";
                    option2Label.Text = "Venture Out";
                    break;
                case 4:
                    titleLabel.Text = "The office is full of things that could potentially help you, such as a flashlight, and an odd animal mask. But no time to talk. You hear An animatronic coming towards you";
                    option1Label.Text = "Flashlight";
                    option2Label.Text = "Mask";
                    break;
                case 5:
                    titleLabel.Text = "You hear footsteps";
                    option1Label.Text = "Stay";
                    option2Label.Text = "Check It Out";
                    break;
                case 6:
                    titleLabel.Text = "The animatronic wanders into your room, so you flash the light in its eye temporarily blinding their scanners ";
                    option1Label.Text = "Run";
                    option2Label.Text = "Stay";
                    break;
                case 7:
                    titleLabel.Text = "Why would you do that,You were found and now you're dead";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 8:
                    titleLabel.Text = "You got caught by an animatronic";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 9:
                    titleLabel.Text = "An animatronic saw, chased, and killed you.";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 10:
                    titleLabel.Text = "You run out of the office and bump into a door that was accidentally left unlocked, you escape";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 11:
                    titleLabel.Text = "You stay put and survive the night until the place opens again, congrats, for being lazy. play again";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 12:
                    titleLabel.Text = "You come across an old room full of old animatronic costumes ";
                    option1Label.Text = "Don't Try one on";
                    option2Label.Text = "Try One On";
                    break;
                case 13:
                    titleLabel.Text = "You refuse to put on the suit, you decide to head back to the office";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(500);
                    if (page == 13)
                    {
                        page = 4;

                    }
                    else
                    {
                        page = 4;
                    }

                    break;
                case 14:
                    titleLabel.Text = "The animatronic wanders into your room but sees no sign of life, and wanders back out";
                    Refresh();
                    Thread.Sleep(1000);
                    titleLabel.Text = "with opening time right around the corner, you have no choice but to stay in the office";
                    Refresh();
                    Thread.Sleep(1000);
                    titleLabel.Text = "You discover a camera system that you can use to monitor the animatronics,";
                    option1Label.Text = "Main Hall";
                    option2Label.Text = "Kitchen";
                    break;
                case 15:
                    break;
                    titleLabel.Text = "You find that one of the animatronics is in the kitchen eating trash, despite not having a proper digestive system ";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                case 16:
                    titleLabel.Text = "Two of the animatronics are just walking around the room but one f them looks like its heading towards the office";
                    option1Label.Text = "Keep Searching Cameras";
                    option2Label.Text = "Prepare For Animatronic";
                    break;
                case 17:
                    titleLabel.Text = "You get off the cameras";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(200);
                    if (page == 17)
                    {
                        page = 16;

                    }
                    else
                    {
                        page = 16;
                    }
                    break;
                case 18:
                    titleLabel.Text = "While you are dazzled by the flashy cameras, an animatronic snuck into the office and forced you off the camera and into their mouth, Yikes!";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 19:
                    titleLabel.Text = "You don't hear the animatronic coming yet but decide to prepare anyway";
                    option1Label.Text = "Mask";
                    option2Label.Text = "Flashlight";
                    break;
                case 20:
                    titleLabel.Text = "You go back on the cameras";
                    option1Label.Text = "Right Hall";
                    option2Label.Text = "Left Hall";
                    break;
                case 21:
                    titleLabel.Text = "You put the suit on unaware the the suit has a mechanism that fills the suit with metal to create an animatronic, you trip set mechanism and the suit crushes you. you are dead, play again";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 22:
                    titleLabel.Text = "Nothings There";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(200);
                    if (page == 22)
                    {
                        page = 20;

                    }
                    else
                    {
                        page = 20;
                    }
                    break;
                case 23:
                    titleLabel.Text = "An animatronic is slowly making its way to the office";
                    option1Label.Text = "Keep Searching Cameras";
                    option2Label.Text = "Prepare For Animatronic";
                    break;
                case 24:
                    titleLabel.Text = "You slip on the mask and the animatronic enters, scans, then leaves.";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(500);
                    titleLabel.Text = "Its opening time, you win";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 25:
                    titleLabel.Text = "You go back on the cameras";
                    option1Label.Text = "Show Stage";
                    option2Label.Text = "Parts And Service";
                    break;
                case 26:
                    titleLabel.Text = "Doesn't matter, an animatronic that you may or may not have known about has entered and killed you";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 27:
                    titleLabel.Text = "Animatronic enters and you try and flash it, but the flashlight has died, and now, you have died too";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 28:
                    titleLabel.Text = "Animatronic regains its scanner and finds and kills you";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;




            }

        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 12;

            }
            else if (page == 3)
            {
                page = 9;

            }
            else if (page == 4)
            {
                page = 14;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 28;
            }
            else if (page == 7)
            {
                page = 1;

            }
            else if (page == 8)
            {
                page = 1;

            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;

            }
            else if (page == 12)
            {
                page = 21;

            }
            else if (page == 13)
            {
                page = 4;

            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 17)
            {
                page = 20;

            }
            else if (page == 18)
            {
                page = 1;

            }
            else if (page == 19)
            {
                page = 27;
            }
            else if (page == 20)
            {
                page = 23;
            }
            else if (page == 21)
            {
                page = 1;

            }
            else if (page == 22)
            {
                page = 20;

            }
            else if (page == 23)
            {
                page = 19;

            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 1;

            }
            else if (page == 28)
            {
                page = 1;

            }
            switch (page)
            {
                case 1:
                    titleLabel.Text = "You are stuck in a pizzeria with killer animatronics. Do you Hide or do you Look Around";
                    option1Label.Text = "Look around";
                    option2Label.Text = "Hide";
                    break;
                case 2:
                    titleLabel.Text = "You find a security office";
                    option1Label.Text = "Stay";
                    option2Label.Text = "Keep Looking";
                    break;
                case 3:
                    titleLabel.Text = "You hide under a table";
                    option1Label.Text = "Stay";
                    option2Label.Text = "Venture Out";
                    break;
                case 4:
                    titleLabel.Text = "The office is full of things that could potentially help you, such as a flashlight, and an odd animal mask. But no time to talk. You hear An animatronic coming towards you";
                    option1Label.Text = "Flashlight";
                    option2Label.Text = "Mask";
                    break;
                case 5:
                    titleLabel.Text = "You hear footsteps";
                    option1Label.Text = "Stay";
                    option2Label.Text = "Check It Out";
                    break;
                case 6:
                    titleLabel.Text = "The animatronic wanders into your room, so you flash the light in its eye temporarily blinding their scanners ";
                    option1Label.Text = "Run";
                    option2Label.Text = "Stay";
                    break;
                case 7:
                    titleLabel.Text = "Why would you do that,You were found and now you're dead";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 8:
                    titleLabel.Text = "You got caught by an animatronic";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 9:
                    titleLabel.Text = "An animatronic saw, chased, and killed you.";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 10:
                    titleLabel.Text = "You run out of the office and bump into a door that was accidentally left unlocked, you escape";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 11:
                    titleLabel.Text = "You stay put and survive the night until the place opens again, congrats, for being lazy. play again";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 12:
                    titleLabel.Text = "You come across an old room full of old animatronic costumes ";
                    option1Label.Text = "Don't Try one on";
                    option2Label.Text = "Try One On";
                    break;
                case 13:
                    titleLabel.Text = "You refuse to put on the suit, you decide to head back to the office";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(500);
                    if (page == 13)
                    {
                        page = 4;

                    }
                    else
                    {
                        page = 4;
                    }

                    break;
                case 14:
                    titleLabel.Text = "The animatronic wanders into your room but sees no sign of life, and wanders back out";
                    Refresh();
                    Thread.Sleep(1000);
                    titleLabel.Text = "with opening time right around the corner, you have no choice but to stay in the office";
                    Refresh();
                    Thread.Sleep(1000);
                    titleLabel.Text = "You discover a camera system that you can use to monitor the animatronics,";
                    option1Label.Text = "Main Hall";
                    option2Label.Text = "Kitchen";
                    break;
                case 15:
                    break;
                    titleLabel.Text = "You find that one of the animatronics is in the kitchen eating trash, despite not having a proper digestive system ";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                case 16:
                    titleLabel.Text = "Two of the animatronics are just walking around the room but one f them looks like its heading towards the office";
                    option1Label.Text = "Keep Searching Cameras";
                    option2Label.Text = "Prepare For Animatronic";
                    break;
                case 17:
                    titleLabel.Text = "You get off the cameras";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(200);
                    if (page == 17)
                    {
                        page = 16;

                    }
                    else
                    {
                        page = 16;
                    }
                    break;
                case 18:
                    titleLabel.Text = "While you are dazzled by the flashy cameras, an animatronic snuck into the office and forced you off the camera and into their mouth, Yikes!";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 19:
                    titleLabel.Text = "You don't hear the animatronic coming yet but decide to prepare anyway";
                    option1Label.Text = "Mask";
                    option2Label.Text = "Flashlight";
                    break;
                case 20:
                    titleLabel.Text = "You go back on the cameras";
                    option1Label.Text = "Right Hall";
                    option2Label.Text = "Left Hall";
                    break;
                case 21:
                    titleLabel.Text = "You put the suit on unaware the the suit has a mechanism that fills the suit with metal to create an animatronic, you trip set mechanism and the suit crushes you. you are dead, play again";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 22:
                    titleLabel.Text = "Nothings There";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(200);
                    if (page == 22)
                    {
                        page = 20;

                    }
                    else
                    {
                        page = 20;
                    }
                    break;
                case 23:
                    titleLabel.Text = "An animatronic is slowly making its way to the office";
                    option1Label.Text = "Keep Searching Cameras";
                    option2Label.Text = "Prepare For Animatronic";
                    break;
                case 24:
                    titleLabel.Text = "You slip on the mask and the animatronic enters, scans, then leaves.";
                    option1Label.Text = "Don't Not Not Not Not Press The Button";
                    option2Label.Text = "Don't Not Not Not Not Press The Button";
                    Refresh();
                    Thread.Sleep(500);
                    titleLabel.Text = "Its opening time, you win";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 25:
                    titleLabel.Text = "You go back on the cameras";
                    option1Label.Text = "Show Stage";
                    option2Label.Text = "Parts And Service";
                    break;
                case 26:
                    titleLabel.Text = "Doesn't matter, an animatronic that you may or may not have known about has entered and killed you";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 27:
                    titleLabel.Text = "Animatronic enters and you try and flash it, but the flashlight has died, and now, you have died too";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
                case 28:
                    titleLabel.Text = "Animatronic regains its scanner and finds and kills you";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Dam, I Hate This Game";
                    break;
            }



        }
    }
}
