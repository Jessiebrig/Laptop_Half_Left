
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Selenium_Test5
{
    class Program
    {
        public static void Main(string[] args)         //MAIN____MAIN____MAIN____MAIN____MAIN____MAIN____MAIN____MAIN____MAIN____MAIN____MAIN____MAIN____
        {
            General Gen = new General();
            
            Option:
            Console.WriteLine("1.Set Chrome to 75% for Laptop and 67% for Desktop");
            Console.WriteLine("1.Start     2.Checkurl     3.Entervalue     4.Methods");
            Console.WriteLine("1.Taburnok   =   to load Chome_Taburnok_Profile");
            Console.WriteLine("1.Josiery    =   to Load Chome_Josiery_Profile");
            Console.WriteLine("1.Test = Test");
            //Console.WriteLine("5.LaptopL   6.DesktopL     7.LaptopR        8.DesktopR");
            String S = Console.ReadLine();
            if (S == "Start")
            {
                goto start;
            }
            else if (S == "Checkurl")
            {
                goto Checkurl;
            }
            else if (S == "Entervalue")
            {
                goto Entervalue;
            }
            if (S == "qq")
            {
                Gen.Laptop_L_Coordinates();
                goto Option;
            }
            else if (S == "qq")
            {
                Gen.Desktop_L_Coordinates();
                goto Option;
            }
            if (S == "qq")
            {
                Gen.Laptop_R_Coordinates();
                goto Option;
            }
            else if (S == "qq")
            {
                Gen.Desktop_R_Coordinates();
                goto Option;
            }
            else if (S == "Methods")
            {
                goto methods;
            }
            else if (S == "Taburnok")
            {
                Gen.Chome_Taburnok_Profile();
                goto Option;
            }
            else if (S == "Josiery")
            {
                Gen.Chome_Josiery_Profile();
                goto Option;
            }
            else if (S == "Test")
            {
                Gen.Test();
                goto Option;
            }
            else
            {
                Console.Beep();
                Gen.Find_Start();
                goto Option;
            }
            start:
            //Gen.Myurl = Gen.fblogin;
            //Gen.Navi();
            //email
            //Gen.value = "email";
            //Gen.keys = "Taburnok.tura@gmail.com";
            //Gen.Sendkeys_By_Lname();
            //pass
            //Gen.value = "pass";
            //Gen.keys = "Taburnokbrigidig";
            //Gen.Sendkeys_By_Lname();
            //login
            //Gen.value = "login";
            //Gen.Click_By_Lname();
            /////////////////////////////

            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            Checkurl:
            Router();
            if (Gen.Curl() == Gen.fblogin)
            {
                goto start;
            }

            //CHECK_____CHECK_____CHECK_____CHECK_____CHECK_____CHECK_____CHECK_____CHECK_____CHECK_____CHECK_____CHECK_____
            Checking_Webtext:
            Gen.Curl();
            Gen.Find_Start();
            Console.WriteLine(Gen.Curl());
            if (Gen.Webtext == "Startfound")
            {
                Gen.Find_Start();
                Console.WriteLine("Start Button Detected!");
            }
            else if (Gen.Curl() == Gen.Dash)
            {
                Gen.Curl();
                goto Option;
            }
            else if (Gen.Curl() == Gen.Google)
            {
                Gen.Curl();
                goto Option;
            }
            else if (Gen.Webtext == "Startnotfound")
            {
                Gen.Find_Expired();
            }
            else if (Gen.Webtext == "Expired")
            {
                Gen.Myurl = Gen.Dash;
                Gen.Navi();
                Thread.Sleep(Gen.Rtime);
                goto Checkurl;
            }
            else if (Gen.Webtext == "NotExpired")
            {
                Console.WriteLine("Task not Expired");
                Console.Beep(1000, 1000);
            }
            else
            {
                Console.WriteLine("Checking for Expired String");
                Console.WriteLine(Gen.Curl());
            }
            Gen.PopUp();
            Thread.Sleep(Gen.Rtime);
            Console.Beep(1000, 1000);
            goto Checking_Webtext;
            //ENTER COMMANDs_____ENTER COMMANDs_____ENTER COMMANDs_____ENTER COMMANDs_____ENTER COMMANDs_____ENTER COMMANDs_____ENTER COMMANDs_____
            Entervalue:
            Console.WriteLine("Enter Element By.Name value");
            Gen.value = Console.ReadLine();
            Console.WriteLine(Gen.value);
            Console.WriteLine("Enter Keys to be sent");
            Gen.keys = Console.ReadLine();
            Console.WriteLine(Gen.keys);

            methods:
            Console.WriteLine("1.Checkurl     2.Lname for Send_Lname     3.LClick for Click_Lname     4.Entervalue" +
                "              5.Option       6.Click");
            String method = Console.ReadLine();
            if (method == "Checkurl")
            {
                goto Checkurl;
            }
            else if (method == "Lname")
            {
                Gen.Sendkeys_By_Lname();
                Console.WriteLine(Gen.value);
            }
            else if (method == "LClick")
            {
                Console.WriteLine(Gen.value);
            }
            else if (method == "Entervalue")
            {
                goto Entervalue;
            }
            else if (method == "Option")
            {
                goto Option;
            }
            else if (method == "Click")
            {
                Gen.Find_Start();
            }
            else
            {
                goto methods;
            }
            goto methods;
        }

        //ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____ROUUTER_____
        public static void Router()
        {
        Check:
            General Gen = new General();

            if (Gen.Curl() == Gen.Dash) // Dashboard
            {
                Gen.Myurl = Gen.Q;
                Gen.Navi();
                goto Check;
            }
            else if (Gen.Curl() == Gen.Q) //Lidar Queue
            {
                //Gen.refresh(); this method needs further test
                Thread.Sleep(Gen.Rtime);
                Gen.Myurl = Gen.Q;
                Gen.Navi();
                goto Check;
            }
            else if (Gen.Curl() == Gen.fblogin) // routed to fblogin senario
            {
                Console.WriteLine("In fblogin page");
            }
            else if (Gen.Curl() == Gen.relogin) // occurs when refreshing many times
            {
                Console.WriteLine("In Relogin page");
                Gen.Myurl = Gen.fblogin;
                Gen.Navi();
                Thread.Sleep(Gen.Rtime);
                goto Check;
            }
            else if (Gen.Curl() == Gen.Remoredirecting)
            {
                Console.WriteLine("Redirecting");
                Thread.Sleep(Gen.Rtime);
                goto Check;
            }
            else
            {
                Console.Beep(1000, 500);
                Gen.Myurl = Gen.Curl();
                Gen.Find_Start();
                Gen.Click_By_Xpath();
                Console.WriteLine("Else Statement under Router Method Initiated");
            }
            Thread.Sleep(Gen.Rtime);
        }
    }
}
