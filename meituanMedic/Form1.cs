using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meituanMedic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AndroidDriver<AndroidElement> driver;


        private void button1_Click(object sender, EventArgs e)
        {
            //DesiredCapabilities capabilities = new DesiredCapabilities();

            //capabilities.SetCapability("deviceName", "127.0.0.1:7555");
            ////capabilities.SetCapability("automationName", "Appium");

            ////capabilities.SetCapability("platformName", "Android");
            ////capabilities.SetCapability("platformVersion", "6.0"); //可以根据自己的模拟器版版本进行修改。
            //capabilities.SetCapability("appPackage", "com.sankuai.meituan"); //安卓自带计算器
            //capabilities.SetCapability("appActivity", "com.meituan.android.pt.homepage.activity.MainActivity");
            //capabilities.SetCapability("platformName", "Android");
            //capabilities.SetCapability("noReset", "true");

            DriverOptions driverOptions = new AppiumOptions();
            driverOptions.AddAdditionalCapability("deviceName", "127.0.0.1:7555");
            driverOptions.AddAdditionalCapability("appPackage", "com.sankuai.meituan"); //安卓自带计算器
            driverOptions.AddAdditionalCapability("appActivity", "com.meituan.android.pt.homepage.activity.MainActivity");
            driverOptions.AddAdditionalCapability("platformName", "Android");
            driverOptions.AddAdditionalCapability("noReset", "true");




            //var driver = new AppiumDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);


            //RemoteWebDriver wd = new RemoteWebDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities,TimeSpan.FromSeconds(60));
            var androidDriver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), driverOptions, TimeSpan.FromSeconds(60));

            try
            {
                

                var result = androidDriver.FindElementsByAccessibilityId("com.sankuai.meituan:id/tv_stickyfood_sold_count");

                //By byAccessibilityId = new ByAccessibilityId("Graphics");
                //wd.FindElement(byAccessibilityId).Text

                //var Soldouts = wd.FindElementsById("com.sankuai.meituan:id/tv_stickyfood_sold_count");
                

                Console.WriteLine(result.Count);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { androidDriver.Quit(); }



        }
    }
}
