using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SanityTest.ConfigFiles;
using SeleniumExtras.WaitHelpers;

namespace SanityTest.Helpers
{
	public static class WaitUtil
	{
		/// <summary>
		/// Custom wait method, wait for appear
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="Driver"></param>
		/// <returns></returns>
		public static bool WaitToBeVisible(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
			try
			{
				wait.Until(d =>
				{
					if (webElement.Displayed)
					{
						LogUtil.Log("[Waits]Element is displayed");
						return webElement;
					}
					return null;
				});
				return true;
			}
			catch (Exception e)
			{
				LogUtil.Log("Error[ClickOn]" + e.Message);
			}
			return false;
		}

		

		//Wait for element be visible and clicable
		public static bool WaitToBeVisibleAndClickable(IWebElement webElement, IWebDriver Driver)
		{
			WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(20));
			try
			{
				wait.Until(ExpectedConditions.ElementToBeClickable(webElement));
				LogUtil.Log("[WaitToBeClickable]: Element is clickable");
				ClickUtil.Click(webElement);
				return true;
			}
			catch (Exception e)
			{
				LogUtil.Log("Error[WaitToBeClickable]" + e.Message);
			}
			return false;
		}


	}
}
