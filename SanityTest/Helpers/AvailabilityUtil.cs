using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SanityTest.Helpers
{
	public static class AvailabilityUtil
	{
		
		// Check is element displayed
		public static bool IsElementDisplayed(IWebElement webElement)
		{
			if (webElement == null)
			{
				LogUtil.Log("[IsDisplayed]: Element is not displayed");
				return true;
			}
			try
			{
				bool wb = webElement.Displayed;
				LogUtil.Log("[IsDisplayed] Element is displayed");
				return wb;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[IsDisplayed]: {e.Message}");
			}
			return false;
		}

		// Check the status of the image using the RestResponse
		//RestResponseValidation
		public static bool GetDataSrcAttribute(IWebElement webElement, IWebDriver driver)
		{
			try
			{
				string datasrc = webElement.GetAttribute("data-src");
				if (datasrc != null)
				{
					LogUtil.Log("Srcset has found");
					return RestResponseValidation.GetStatusCodeHttp(datasrc).Result;
				}
				else
				{
					LogUtil.Log("Srcset has NOT found");
					return false;
				}
				
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[HTTP Status]: {e.Message}");
				return false;
			}
		}

		//Is element enabled
		public static bool IsEnabled(IWebElement webElement)
		{
			if (webElement == null)
			{
				LogUtil.Log("[IsEnabled] input webElement is null");
				return false;
			}
			try
			{
				bool wb = webElement.Enabled;
				return wb;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[IsEnabled]: Element is disabled {e.Message}");
			}
			return false;
		}

		// Check is element Enabled and Displayed
		public static bool IsEnabledAndDisplayed(IWebElement webElement)
		{
			if (webElement == null)
			{
				LogUtil.Log("[IsEnabledAndDisplayed] input webElement is null");
				return false;
			}
			try
			{
				if (webElement.Enabled && webElement.Displayed)
				{
					LogUtil.Log("[IsEnabledAndDisplayed] Field is enabled and displayed");
					return true;
				}
			}
			catch (Exception e)
			{
				LogUtil.Log($"IsEnabledAndDisplayed {e.Message}");
				return false;
			}
			return false;
		}

		//Scroll into the view
		public static void ScrollIntoViewJS(IWebElement webElement, IWebDriver Driver)
		{
			((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", webElement);
			LogUtil.Log("Info[ScrollIntoViewJS]:Scrolled into element");
			System.Threading.Thread.Sleep(1000);
		}
	}
}
