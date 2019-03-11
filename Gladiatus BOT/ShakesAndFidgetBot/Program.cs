using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ShakesAndFidgetBot
{
    class Program
    {
        

        static void Main(string[] args)
        {

            
            IWebDriver driver = new FirefoxDriver();
            string mail = "https://10minutemail.net/?lang=pl";
            driver.Navigate().GoToUrl(mail);
            var copymail = driver.FindElement(By.Id("copy-button"));
            copymail.Click();

            string shakeServer = "https://pl.gladiatus.gameforge.com/game/";
            driver.Navigate().GoToUrl(shakeServer);
            Actions Drag = new Actions (driver);
            int timeout3s = 3000;
            int timeout = 10000;
            int timer = 0;
            int waitforpoints = 3600000;
            // closing advertisement
            try
            {
                var ExitAd = driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div/div[1]/a"));
                ExitAd.Click();
            }
            catch
            {

            }
            var AcceptCookies = driver.FindElement(By.Id("accept_btn"));
            AcceptCookies.Click();
            var RegisterSeverBox = driver.FindElement(By.Id("register_server"));
            SelectElement server2 = new SelectElement(RegisterSeverBox);
            server2.SelectByValue("s39-pl.gladiatus.gameforge.com");

            var RegisterEmail = driver.FindElement(By.Id("email"));
            RegisterEmail.SendKeys(Keys.Control + "v");


            
            var RegisterNick = driver.FindElement(By.Id("name"));
            RegisterNick.SendKeys(Keys.Control + "v");
            RegisterNick.SendKeys(Keys.Backspace + Keys.Backspace+ Keys.Backspace + Keys.Backspace+ Keys.Backspace + Keys.Backspace+ Keys.Backspace + Keys.Backspace+ Keys.Backspace + Keys.Backspace+Keys.Backspace);
            RegisterNick.SendKeys(Keys.Control + "c");

            

            var RegisterPassword = driver.FindElement(By.Id("password"));
            RegisterPassword.SendKeys("kolorowymotyl");
            var RegisterSubmit = driver.FindElement(By.Id("registersubmit"));
            RegisterSubmit.Click();

            System.Threading.Thread.Sleep(timeout3s);

            try
            {
                var Ok = driver.FindElement(By.Id("linknotification"));
                Ok.Click();
            }
            catch
            {

            }
            try
            {
                var ChooseSEX = driver.FindElement(By.ClassName("button2"));
                ChooseSEX.Click();
            }
            catch
            {

            }

            //numero uno
            var inventoryFood = driver.FindElement(By.CssSelector(".item-i-7-1"));
            var inventoryFood2 = driver.FindElement(By.CssSelector(".item-i-7-2"));
            var ShieldInventory = driver.FindElement(By.CssSelector(".item-i-2-2"));
            var Shield = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div[2]/table/tbody/tr/td[2]/div[2]/div[3]"));
            Actions acs = new Actions(driver);
            acs.ClickAndHold(ShieldInventory);
            acs.MoveToElement(Shield);
            acs.Click().Build().Perform();
            var confirmequip = driver.FindElement(By.Id("linksoulboundConfirm"));
            confirmequip.Click();
            
            System.Threading.Thread.Sleep(timeout3s);
            try
            {
                var LoginBonus = driver.FindElement(By.Id("linkLoginBonus"));
                LoginBonus.Click();
            }
            catch (Exception)
            {

            }
            try
            {
                var submitOK = driver.FindElement(By.Id("linknotification"));
                submitOK.Click();
            }
            catch
            {

            }
            try
            {
                var notificationOk = driver.FindElement(By.Id("linkcancelnotification"));
                notificationOk.Click();
            }
            catch (Exception)
            {
            }

            var ExpeditionPoints = driver.FindElement(By.Id("expeditionpoints_value_pointmax")).Text;
            var expeditionPointleft = driver.FindElement(By.Id("expeditionpoints_value_point")).Text;
            var level = driver.FindElement(By.Id("header_values_level")).Text;


            var city = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div[1]/div[1]/div/div[1]/div[1]/a"));
            city.Click();
            var Trening = driver.FindElement(By.CssSelector("#submenu1 > a:nth-child(1)"));
            Trening.Click();
            var strength = driver.FindElement(By.CssSelector("#training_box > div:nth-child(2) > div:nth-child(2) > a:nth-child(2)"));
            strength.Click();
            var wieldingWeapon = driver.FindElement(By.CssSelector("#training_box > div:nth-child(3) > div:nth-child(2) > a:nth-child(2)"));
            wieldingWeapon.Click();
            var skill = driver.FindElement(By.CssSelector("#training_box > div:nth-child(4) > div:nth-child(2) > a:nth-child(2)"));
            skill.Click();
            var physicalConstruction = driver.FindElement(By.CssSelector("#training_box > div:nth-child(5) > div:nth-child(2) > a:nth-child(2)"));
            physicalConstruction.Click();
            var charisma = driver.FindElement(By.CssSelector("#training_box > div:nth-child(6) > div:nth-child(2) > a:nth-child(2)"));
            charisma.Click();

            var Panteon = driver.FindElement(By.CssSelector("#mainmenu > a:nth-child(2)"));
            Panteon.Click();
            var firstQuest = driver.FindElement(By.CssSelector("div.contentboard_slot:nth-child(2) > a:nth-child(4)"));
            firstQuest.Click();
            System.Threading.Thread.Sleep(timeout);
            var secondQuest = driver.FindElement(By.CssSelector("div.contentboard_slot:nth-child(3) > a:nth-child(4)"));
            secondQuest.Click();



            if (expeditionPointleft != "0")
            {
                

               
                do
                {

                 
                    for (int i = 0; i < 11; i++)

                    {
                        level = driver.FindElement(By.Id("header_values_level")).Text;

                        if (level == "1")
                        {

                            timer = 5000;
                        }
                        else if (level == "2")
                        {
                            timer = 10000;
                        }
                        else if (level == "3")
                        {
                            timer = 20000;
                        }
                        else if (level == "4")
                        {
                            timer = 40000;
                        }
                        else if (level == "5")
                        {
                            timer = 61000;
                        }
                        else if (level == "6")
                        {
                            timer = 120000;
                        }
                        else if (level == "7")
                        {
                            timer = 240000;
                        }
                        else if (level == "8")
                        {
                            timer = 360000;
                        }
                        var ExpeditionButton = driver.FindElement(By.CssSelector("#cooldown_bar_expedition > .cooldown_bar_link"));
                        ExpeditionButton.Click();
                        try
                        {
                            var submitOK = driver.FindElement(By.Id("linknotification"));
                            submitOK.Click();
                        }
                        catch
                        {

                        }
                        try
                        {
                            var notificationOk = driver.FindElement(By.Id("linkcancelnotification"));
                            notificationOk.Click();
                        }
                        catch (Exception)
                        {
                        }

                        ExpeditionButton = driver.FindElement(By.CssSelector("#cooldown_bar_expedition > .cooldown_bar_link"));
                        ExpeditionButton.Click();
                        var ChooseMonster = driver.FindElement(By.CssSelector(".expedition_box:nth-child(1) .expedition_button"));
                        ChooseMonster.Click();
                        try
                        {
                            var submitOK = driver.FindElement(By.Id("linknotification"));
                            submitOK.Click();
                        }
                        catch
                        {

                        }
                        try
                        {
                            var notificationOk = driver.FindElement(By.Id("linkcancelnotification"));
                            notificationOk.Click();
                        }
                        catch (Exception)
                        {
                        }
                        try
                        {
                            var notificationOk = driver.FindElement(By.Id("linkcancelnotification"));
                            notificationOk.Click();
                        }
                        catch (Exception)
                        {
                        }
                        var Hero = driver.FindElement(By.CssSelector("#mainmenu > a:nth-child(1)"));
                        Hero.Click();
                        try
                        {
                            var submitOK = driver.FindElement(By.Id("linknotification"));
                            submitOK.Click();
                        }
                        catch
                        {

                        }
                        try
                        {
                            var notificationOk = driver.FindElement(By.Id("linkcancelnotification"));
                            notificationOk.Click();
                        }
                        catch (Exception)
                        {
                        }
                        Hero = driver.FindElement(By.CssSelector("#mainmenu > a:nth-child(1)"));
                        Hero.Click();

                        var hpStatus = driver.FindElement(By.Id("char_leben")).Text;
                        hpStatus = hpStatus.Replace(" %", string.Empty);
                        int totalHpStatus = Int32.Parse(hpStatus);
                        if (totalHpStatus < 30)
                        {

                            var inventory = driver.FindElement(By.Id("avatar"));
                           

                            bool IsElementPresent(By by)
                            {
                                try
                                {
                                    driver.FindElement(by);
                                    return true;
                                }
                                catch (NoSuchElementException)
                                {
                                    return false;
                                }
                            }
                            if (IsElementPresent(By.CssSelector(".item-i-7-1")))
                            {
                                inventoryFood = driver.FindElement(By.CssSelector(".item-i-7-1"));
                                Actions ac = new Actions(driver);
                                ac.ClickAndHold(inventoryFood);
                                ac.MoveToElement(inventory);
                                ac.Click().Build().Perform();
                            }
                            else if(IsElementPresent(By.CssSelector(".item-i-7-2")))
                            {
                                inventoryFood2 = driver.FindElement(By.CssSelector(".item-i-7-2"));
                                Actions acss = new Actions(driver);
                                acss.ClickAndHold(inventoryFood2);
                                acss.MoveToElement(inventory);
                                acss.Click().Build().Perform();
                            }
                            else if (IsElementPresent(By.CssSelector(".item-i-7-3")))
                            {
                                inventoryFood2 = driver.FindElement(By.CssSelector(".item-i-7-3"));
                                Actions acss = new Actions(driver);
                                acss.ClickAndHold(inventoryFood2);
                                acss.MoveToElement(inventory);
                                acss.Click().Build().Perform();
                            }
                            else if (IsElementPresent(By.CssSelector(".item-i-7-4")))
                            {
                                inventoryFood2 = driver.FindElement(By.CssSelector(".item-i-7-4"));
                                Actions acss = new Actions(driver);
                                acss.ClickAndHold(inventoryFood2);
                                acss.MoveToElement(inventory);
                                acss.Click().Build().Perform();
                            }
                            else if (IsElementPresent(By.CssSelector(".item-i-7-5")))
                            {
                                inventoryFood2 = driver.FindElement(By.CssSelector(".item-i-7-5"));
                                Actions acss = new Actions(driver);
                                acss.ClickAndHold(inventoryFood2);
                                acss.MoveToElement(inventory);
                                acss.Click().Build().Perform();
                            }

                        }


                        try
                        {
                            var submitOK = driver.FindElement(By.Id("linknotification"));
                            submitOK.Click();
                        }
                        catch
                        {

                        }
                        try
                        {
                            var notificationOk = driver.FindElement(By.Id("linkcancelnotification"));
                            notificationOk.Click();
                        }
                        catch (Exception)
                        {
                        }


                        expeditionPointleft = driver.FindElement(By.Id("expeditionpoints_value_point")).Text;
                        if (expeditionPointleft == "0")
                        {
                            System.Threading.Thread.Sleep(waitforpoints);
                            //System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }

                        if (totalHpStatus <= 10)
                        {
                            System.Diagnostics.Process.GetCurrentProcess().Kill();
                        }
                        System.Threading.Thread.Sleep(timer);



                    }
                    
                        if (level == "2")
                        {
                            var arena = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[10]/a"));
                            arena.Click();
                            System.Threading.Thread.Sleep(timeout3s);
                            city = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div[1]/div[1]/div/div[1]/div[1]/a"));
                            city.Click();
                            Trening = driver.FindElement(By.CssSelector("#submenu1 > a:nth-child(2)"));
                            Trening.Click();
                            strength = driver.FindElement(By.CssSelector("#training_box > div:nth-child(2) > div:nth-child(2) > a:nth-child(2)"));
                            strength.Click();
                            wieldingWeapon = driver.FindElement(By.CssSelector("#training_box > div:nth-child(3) > div:nth-child(2) > a:nth-child(2)"));
                            wieldingWeapon.Click();
                            skill = driver.FindElement(By.CssSelector("#training_box > div:nth-child(4) > div:nth-child(2) > a:nth-child(2)"));
                            skill.Click();
                            physicalConstruction = driver.FindElement(By.CssSelector("#training_box > div:nth-child(5) > div:nth-child(2) > a:nth-child(2)"));
                            physicalConstruction.Click();
                            charisma = driver.FindElement(By.CssSelector("#training_box > div:nth-child(6) > div:nth-child(2) > a:nth-child(2)"));
                            charisma.Click();
                        }
                        else if (level == "3")
                        {
                            var arena = driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[10]/a"));
                            arena.Click();
                            System.Threading.Thread.Sleep(timeout3s);
                            city = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div[1]/div[1]/div/div[1]/div[1]/a"));
                            city.Click();
                            Trening = driver.FindElement(By.CssSelector("#submenu1 > a:nth-child(3)"));
                            Trening.Click();
                            strength = driver.FindElement(By.CssSelector("#training_box > div:nth-child(2) > div:nth-child(2) > a:nth-child(2)"));
                            strength.Click();
                            wieldingWeapon = driver.FindElement(By.CssSelector("#training_box > div:nth-child(3) > div:nth-child(2) > a:nth-child(2)"));
                            wieldingWeapon.Click();
                            skill = driver.FindElement(By.CssSelector("#training_box > div:nth-child(4) > div:nth-child(2) > a:nth-child(2)"));
                            skill.Click();
                            physicalConstruction = driver.FindElement(By.CssSelector("#training_box > div:nth-child(5) > div:nth-child(2) > a:nth-child(2)"));
                            physicalConstruction.Click();
                            charisma = driver.FindElement(By.CssSelector("#training_box > div:nth-child(6) > div:nth-child(2) > a:nth-child(2)"));
                            charisma.Click();
                        }
                    
                } while (expeditionPointleft != "0");
                

            }

        }
    }
    }


