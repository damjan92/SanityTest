using OpenQA.Selenium;
using SanityTest.Base;
using SanityTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssityMX.Pages.HomePage
{
	public class AcceptCoockies : BasePage
	{
		public AcceptCoockies(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		public static IWebElement AcceptCoockieSelector => Driver.FindElement(By.CssSelector("#onetrust-accept-btn-handler"));

		public static bool ClickOnAcceptCoockies()
		{
			try
			{
				return WaitUtil.WaitToBeVisibleAndClickable(AcceptCoockieSelector, Driver);
			}
			catch (Exception e)
			{
				Console.WriteLine($"[Coockie]Is not visible:  {e.Message}");
				return false;
			}
		}

	}
}
