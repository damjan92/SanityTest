using NUnit.Framework;
using OpenQA.Selenium;
using System;
using SanityTest.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using SanityTest.Helpers;
using SanityTest.Enums;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace SanityTest.Base
{
	public class BaseTest
	{

		public static IWebDriver Driver;

		public static ExtentReports extent = null;

		[OneTimeSetUp]
		public void ExtentStart()
		{
			extent = new ExtentReports();
			var HtmlReporter = new ExtentHtmlReporter(@"C:\Users\DamjanDosen\source\repos\SanityTest\EssityMX\Tests");
			extent.AttachReporter(HtmlReporter);

			LogUtil.Log("--Running OneTimeSetUp--");
		}

		[SetUp]
		public void Setup()
		{
			Driver = BrowserFactory.InitializeDriver(BrowserType.Chrome);
			Driver.Manage().Window.Maximize();
			LogUtil.Log("--SetUp--");
		}

		[TearDown]
		public void Close()
		{
			Driver.Quit();
			LogUtil.Log("--TeadDown--");
		}

		[OneTimeTearDown]
		public void ExtentClose()
		{
			extent.Flush();
		}
	}
}