using SanityTest.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityTest.Base
{
	public class BasePage
	{
		public static IWebDriver Driver;

		protected BasePage(IWebDriver driver)
		{
			Driver = driver;
		}

		public static bool OpenPage(string url)
		{	
			if (url == null)
			{
				LogUtil.Log("Error[OpenPage]: URL is null");
				return false;
			}
			try
			{
				Driver.Url = url;
				return true;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[OpenPage]: {e.Message}");
			}
			return false;
		}
		
		public static string GetTitle()
		{
			try
			{
				LogUtil.Log($"[Base:GetTitle]: {Driver.Title}");
				return Driver.Title;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[Base:GetTitle]: {e.Message}");
			}
			return null;
		}


		public static string GetURL()
		{
			try
			{
				LogUtil.Log($"[Base:GetURL]: {Driver.Url}");
				return Driver.Url;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[Base:GetURL]: Driver is unkown or null {e.Message}");
			}
			return Driver.Url;
		}

	}
}
