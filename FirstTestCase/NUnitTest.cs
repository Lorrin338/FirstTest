using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestCase
{
	class NUnitTest
	{
		IWebDriver driver;

		[SetUp]
		public void Initialize()
		{
			driver = new FirefoxDriver();
		}

		[Test]
		public void OpenAppTest()
		{
			driver.Url = "https://www.futbin.com/";
		}

		[Test]
		public void TitleAndPageDetails()
		{
			driver.Url = "https://www.futbin.com/";
			String Title = driver.Title;
			int TitleLength = driver.Title.Length;
			Console.WriteLine("Title of the page is: " + Title);
			Console.WriteLine("Length of the Title is: " + TitleLength);

			String PageURL = driver.Url;
			int URLLength = PageURL.Length;
			Console.WriteLine("URL of the page is: " + PageURL);
			Console.WriteLine("URL length is: " + URLLength);

			String PageSource = driver.PageSource;
			int PageSourceLength = driver.PageSource.Length;
			Console.WriteLine("Page Source of the page is: " + PageSource);
			Console.WriteLine("Length of the Page Source is: " + PageSourceLength);



		}

		[Test]
		public void ClickOnPlayerDB()
		{
			driver.Url = "https://www.futbin.com/";
			driver.FindElement(By.XPath("/html/body/div[7]/div[4]/div/div[1]/a[1]")).Click();
		}

		[Test]
		public void NavigationFunctions()
		{
			driver.Url = "https://www.futbin.com/";
			driver.FindElement(By.XPath("/html/body/div[7]/div[4]/div/div[1]/a[1]")).Click();
			driver.Navigate().Back();
			driver.Navigate().Forward();
			driver.Navigate().Refresh();
			driver.Close();
		}

		[TearDown]
		public void EndTest()
		{
			driver.Close();
		}
	}
}
