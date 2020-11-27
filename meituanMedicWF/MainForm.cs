using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
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

namespace meituanMedicWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "6");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "127.0.0.1:7555");

            //capabilities.SetCapability("appPackage", "com.sankuai.meituan");
            //capabilities.SetCapability("appActivity", "com.meituan.android.pt.homepage.activity.MainActivity");

            Uri address = new Uri("http://localhost:4723/wd/hub");

            //By.
           

            RemoteWebDriver driver = new RemoteWebDriver(address, capabilities);

            try
            {
                //var result = driver.FindElementsByXPath("//android.view.View[@content-desc=\"买药\"]");
                //var Titles = driver.FindElementsById("com.sankuai.meituan:id/recycler");
                //var result = driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.support.v7.widget.RecyclerView/android.widget.FrameLayout[1]/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.LinearLayout[1]/android.widget.TextView");
                //var childResult = result.FindElements(By.ClassName("android.widget.FrameLayout"));
                //var Titles = driver.FindElementsById("com.sankuai.meituan:id/txt_stickyfoodList_adapter_food_name");
                var Soldouts = driver.FindElementsById("com.sankuai.meituan:id/tv_stickyfood_sold_count");
                //var OrginalPrice = driver.FindElementsById("com.sankuai.meituan:id/txt_stickyfoodList_adapter_food_original_price_fix");
                //var Price = driver.FindElementsById("com.sankuai.meituan:id/txt_stickyfoodList_adapter_food_price_fix");
                //var tvPrice = driver.FindElementsById("com.sankuai.meituan:id/tv_goods_estimated_price");


                //for (int i = 1; i < 7; ++i) {
                //    var TitleElement = driver.FindElementByXPath(getTitleXPathByIndex(i));
                    
                //        Console.WriteLine(TitleElement.Text);

                //}





                Console.WriteLine(Soldouts.Count);

                //if (result.Count>0)
                //{
                //    result[0].
                //    result[0].Click(); 
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { driver.Quit(); }


        }

        private string getTitleXPathByIndex(int index) {
            return "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.support.v7.widget.RecyclerView/android.widget.FrameLayout["
                + index + "]/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.LinearLayout[1]/android.widget.TextView";
        }

        private string getSOldoutXPathByIndex(int index)
        {
            return "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.support.v7.widget.RecyclerView/android.widget.FrameLayout["
                + index + "]/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.LinearLayout[1]/android.widget.RelativeLayout[1]/android.widget.TextView";
        }

        private string getPriceXPathByIndex(int index)
        {
            return "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.support.v7.widget.RecyclerView/android.widget.FrameLayout["
                + index + "]/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.TextView[2]";
        }

        private string getOrginalPriceXPathByIndex(int index)
        {
            return "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.support.v7.widget.RecyclerView/android.widget.FrameLayout["
                + index + "]/android.widget.RelativeLayout/android.widget.RelativeLayout[2]/android.widget.LinearLayout[1]/android.widget.LinearLayout/android.widget.TextView[3]";
        }

        private string getEstimatedPriceXPathByIndex(int index)
        {
            return "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout[1]/android.widget.LinearLayout/android.widget.FrameLayout[2]/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.FrameLayout[2]/android.support.v7.widget.RecyclerView/android.widget.FrameLayout["
                + index + "]/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout/android.widget.TextView[2]";
        }
    }
}
