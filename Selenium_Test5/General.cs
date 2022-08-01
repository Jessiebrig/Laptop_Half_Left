using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AutoItX3Lib;

namespace Selenium_Test5
{
    public class General
    {
        AutoItX3 Auto = new AutoItX3();

        public void Test()
        {
            Auto.Send("tesewewewt");
        }

        public int Rtime = 15000;
        public String value;
        public String keys;
        public String Myurl;
        public String Dash;
        public String Q;
        public String fblogin;
        public String relogin;
        public String Remoredirecting;
        public String StartXPath;
        //public String ExpiredXPath;
        public String ContinueXPath;
        public String Webtext;
        public String Google;
        //Mouse Coordinates//
        public String Clickside;
        public int X;
        public int Y;
        public int Clicks;
        public int Speed;
        public General()
        {
            Dash = "https://www.remotasks.com/dashboard";
            Q = "https://www.remotasks.com/tasks/lidar";
            Remoredirecting = "https://www.remotasks.com/login?redirect_url=%2Ftasks%2Flidar&clear=1";
            fblogin = "https://www.facebook.com/login.php?skip_api_login=1&api_key=118817275449497&kid_directed_site=0&app_id=118817275449497&signed_next=1&next=https%3A%2F%2Fwww.facebook.com%2Fdialog%2Foauth%3Fresponse_type%3Dcode%26redirect_uri%3Dhttps%253A%252F%252Fapi-internal.scale.ai%252Finternal%252Flogin%252Ffacebook%252Fcallback%26scope%3Demail%252Cuser_location%26client_id%3D118817275449497%26ret%3Dlogin%26fbapp_pres%3D0%26fallback_redirect_uri%3D9df27500-8e6b-4f72-8ddc-79f937e766d0%26logger_id%3D9df27500-8e6b-4f72-8ddc-79f937e766d0&cancel_url=https%3A%2F%2Fapi-internal.scale.ai%2Finternal%2Flogin%2Ffacebook%2Fcallback%3Ferror%3Daccess_denied%26error_code%3D200%26error_description%3DPermissions%2Berror%26error_reason%3Duser_denied%23_%3D_&display=page&locale=en_US%2F";
            relogin = "https://www.remotasks.com/login?redirect_url=%2Ftasks%2Flidar&clear=1";
            StartXPath = ".//div[contains(text(),'Start tasks')]";
            //ExpiredXPath = "//div[contains(text(),'Oops, this task has expired!')]";
            Google = "https://www.google.com/";
            ContinueXPath = ".//a[contains(text(),'Continue')]";

        }
        public static IWebDriver Chrome = new ChromeDriver();       //WEBDRIVER_____WEBDRIVER_____WEBDRIVER_____WEBDRIVER_____WEBDRIVER_____
        public void Chome_Taburnok_Profile()
        {
            Chrome.Quit();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"user-data-dir=D:\Chome_Taburnok_Profile");
            Chrome = new ChromeDriver(options);
            Console.WriteLine("Loading Custom Profile (With_Coordinates_Extension) Successful");
        }
        public void Chome_Josiery_Profile()
        {
            Chrome.Quit();
            ChromeOptions options = new ChromeOptions();
            options.AddArgument(@"user-data-dir=D:\Chrome_Josiery_Profile");
            Chrome = new ChromeDriver(options);
            Console.WriteLine("Loading Custom Profile (With_Coordinates_Extension) Successful");
        }
        public void Laptop_L_Coordinates()
        {
            Clickside = "LEFT";
            X = 340;
            Y = 655;
            Clicks = 2;
            Speed = 1;
        }
        public void Laptop_R_Coordinates()
        {
            Clickside = "LEFT";
            X = 340;
            Y = 655;
            Clicks = 2;
            Speed = 1;
        }
        public void Desktop_L_Coordinates()
        {
            Clickside = "LEFT";
            X = 320;
            Y = 950;
            Clicks = 2;
            Speed = 1;
        }
        public void Desktop_R_Coordinates()
        {
            Clickside = "LEFT";
            X = 955;
            Y = 949;
            Clicks = 2;
            Speed = 1;
        }
        public void Click()
        {
            Auto.MouseClick("LEFT", 340, 655, 2, 1);
            Console.Beep();
        }

        public String Curl()
        {
            PopUp();
            String Curl = Chrome.Url;
            return Curl;
        }
        public void Navi()
        {
        naviagain:
            try
            {
                Chrome.Navigate().GoToUrl(Myurl);
            }
            catch (Exception)
            {
                Thread.Sleep(Rtime);
                goto naviagain;
            }
        }
        public void Refresh()
        {
            Chrome.Navigate().Refresh();
        }
        public void Sendkeys_By_Lname()
        {
            try
            {
                Chrome.FindElement(By.Name(value)).SendKeys(keys);
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No Such Element Exception Occur_in Sendkeys_By_Lname");
                Console.WriteLine("Proceeding to next Comand");
                Thread.Sleep(Rtime);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Web Driver Timeout Exception_in Sendkeys_By_Lname");
                Console.WriteLine("Proceeding to next Comand");
                Thread.Sleep(Rtime);
            }
        }
        public void Click_By_Xpath()
        {
            try
            {
                Chrome.FindElement(By.XPath(StartXPath)).Click();
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("No Such Element Exception Occur_in Click_By_Xpath");
                Console.WriteLine("Proceeding to next Comand");
                Thread.Sleep(Rtime);
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Web Drive rTimeout Exception_in Click_By_Xpath");
                Console.WriteLine("Proceeding to next Comand");
                Thread.Sleep(Rtime);
            }
        }
        public void Find_Start()     //FIND____FIND____FIND____FIND____FIND____FIND____FIND____FIND____FIND____FIND____FIND____FIND____FIND____
        {
            try
            {
                PopUp();
                Chrome.FindElement(By.Name(StartXPath));
                Console.WriteLine("XPath: " + StartXPath + "Found");
                Console.WriteLine(Curl());
                Webtext = "Startfound";
            }
            catch (NoSuchElementException)
            {
                PopUp();
                Console.WriteLine("No Such Element Exception Occur_in Find_Start_By_XPath");
                Console.WriteLine("XPath: " + StartXPath + "Not Found");
                Webtext = "Startnotfound";
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Web Driver Timeout Exception Occur_in Find_Start_By_XPath");
                Console.WriteLine("Proceeding to next Comand");
                Thread.Sleep(Rtime);
            }
            catch (UnhandledAlertException)
            {
                
                Console.WriteLine("Unhandled Alert Exception Occur_in Find_Start_By_XPath");
                Navi();
                Thread.Sleep(Rtime);
            }
        }
        public void Find_Expired() //ExpiredXPath not working//Try ContinueXPath
        {
            try
            {
                PopUp();
                Chrome.FindElement(By.Name(ContinueXPath));
                Console.WriteLine("XPath: " + ContinueXPath + "Found");
                Console.WriteLine(Curl());
                Webtext = "Expired";
            }
            catch (NoSuchElementException)
            {
                PopUp();
                Console.WriteLine("No Such Element Exception Occur_in Find_Expired_By_XPath");
                Console.WriteLine("XPath: " + ContinueXPath + "Not Found");
                Webtext = "NotExpired";
            }
            catch (WebDriverTimeoutException)
            {
                Console.WriteLine("Web Driver Timeout Exception Occur_in Find_Expired_By_XPath");
                Console.WriteLine("Proceeding to next Comand");
                Thread.Sleep(Rtime);
            }
            catch (UnhandledAlertException)
            {
                Console.WriteLine("Unhandled Alert Exception Occur_in Find_Expired_By_XPath");
                Navi();
                Thread.Sleep(Rtime);
            }
        }
        public void PopUp()
        {
            try
            {
                string alertmsg = Chrome.SwitchTo().Alert().Text;
                Console.WriteLine("PopUp Found: " + alertmsg);
                Chrome.SwitchTo().Alert().Dismiss();
            }
            catch (NoAlertPresentException)
            {
                Console.WriteLine("No PopUp Found");
            }
        }


    }
}
