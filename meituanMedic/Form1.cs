using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace meituanMedic
{
    struct GoodInfo
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string FoodName { set; get; }
        /// <summary>
        /// 每月销量
        /// </summary>
        public int SoldCount { set; get; }
        /// <summary>
        /// 销售价格
        /// </summary>
        public decimal SoldPrice { set; get; }
        /// <summary>
        /// 原始价格
        /// </summary>
        public decimal OriginalPrice { set; get; }
        /// <summary>
        /// 到手价格
        /// </summary>
        public decimal EstimatedPrice { set; get; }
    }

    public partial class Form1 : Form
    {
        private AndroidDriver<AndroidElement> driver;

        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, GoodInfo> data = new Dictionary<string, GoodInfo>();

        int GetInteger(string str)
        {
            str = Regex.Replace(str, @"[^0-9]+", "");
            return int.Parse(str);
        }

        decimal GetDecimal(string str)
        {
            str = Regex.Replace(str, @"[^\d.\d]", "");
            // 如果是数字，则转换为decimal类型
            if (Regex.IsMatch(str, @"^[+-]?\d*[.]?\d*$"))
            {
                return decimal.Parse(str);
            }
            return new decimal(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var recycler = driver.FindElementById("com.sankuai.meituan:id/recycler");
                var items = recycler.FindElementsById("com.sankuai.meituan:id/ll_stickyfoodList_adapter_food_food");
                Console.WriteLine(items.Count);
                foreach (var item in items)
                {
                    // FindElementsById 不会抛异常
                    var foodNames = item.FindElementsById("com.sankuai.meituan:id/txt_stickyfoodList_adapter_food_name");
                    var soldCounts = item.FindElementsById("com.sankuai.meituan:id/tv_stickyfood_sold_count");
                    var soldPrices = item.FindElementsById("com.sankuai.meituan:id/txt_stickyfoodList_adapter_food_price_fix");
                    var originalPrices = item.FindElementsById("com.sankuai.meituan:id/txt_stickyfoodList_adapter_food_original_price_fix");
                    var estimatedPrices = item.FindElementsById("com.sankuai.meituan:id/tv_goods_estimated_price");
                    if (foodNames.Count > 0)
                    {
                        var foodName = foodNames.FirstOrDefault()?.Text;
                        var soldCount = soldCounts.FirstOrDefault()?.Text;
                        var soldPrice = soldPrices.FirstOrDefault()?.Text;
                        var originalPrice = originalPrices.FirstOrDefault()?.Text;
                        var estimatedPrice = estimatedPrices.FirstOrDefault()?.Text;
                        var info = new GoodInfo
                        {
                            FoodName = foodName ?? "",
                            SoldCount = GetInteger(soldCount ?? "0"),
                            SoldPrice = GetDecimal(soldPrice ?? "0.0"),
                            OriginalPrice = GetDecimal(originalPrice ?? "0.0"),
                            EstimatedPrice = GetDecimal(estimatedPrice ?? "0.0")
                        };
                        // 没有添加到字典
                        if (!data.ContainsKey(info.FoodName))
                        {
                            data.Add(info.FoodName, info);
                        }
                        Console.WriteLine($"{info.FoodName} 销量：{info.SoldCount} 售价：{info.SoldPrice} 原价：{info.OriginalPrice} 到手价：{info.EstimatedPrice}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.DataSource = data.Values.ToArray<GoodInfo>();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DriverOptions options = new AppiumOptions();
                options.AddAdditionalCapability("deviceName", "127.0.0.1:7555");
                options.AddAdditionalCapability("platformName", "Android");
                options.AddAdditionalCapability("platformVersion", "6.0.1");
                //driverOptions.AddAdditionalCapability("appPackage", "com.sankuai.meituan");
                options.AddAdditionalCapability("appActivity", "com.meituan.android.pt.homepage.activity.MainActivity");
                options.AddAdditionalCapability("noReset", "true");

                driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), options, TimeSpan.FromSeconds(60));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
