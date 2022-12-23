using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SanityTest.Helpers
{
	public static class SelectUtil
	{
		/// <summary>
		/// Selecting Element by Value
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool SelectElementByValue(IWebElement webElement, string value)
		{
			if (webElement == null)
			{
				LogUtil.Log("Error[SelectOn]Input element is null.");
				return false;
			}
			if (value == null)
			{
				LogUtil.Log("Error[SelectOn]Input value is null.");
				return false;
			}
			try
			{
				SelectElement selectElement = new SelectElement(webElement);
				selectElement.SelectByValue(value);
				LogUtil.Log("Info[SelectOn]:Item has been selected");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Selecting element by text
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool SelectElementByText(IWebElement webElement, string text)
		{
			if (webElement == null)
			{
				LogUtil.Log("Error[SelectOn]Input element is null.");
				return false;
			}
			if (text == null)
			{
				LogUtil.Log("Error[SelectOn]Input text is null.");
				return false;
			}
			try
			{
				SelectElement selectElement = new SelectElement(webElement);
				//selectElement.SelectByText(text);
				selectElement.SelectByValue(text);
				LogUtil.Log("Info[SelectOn]:Item has been selected");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}
		
		/// <summary>
		/// Selecting element by Index
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="byIndex"></param>
		/// <returns></returns>
		public static bool SelectElementByIndex(IWebElement webElement, int byIndex)
		{
			if (webElement == null)
			{
				LogUtil.Log("Error[SelectOn]Input element is null.");
				return false;
			}
			if (TryParse(byIndex))
			{
				LogUtil.Log("Error[SelectOn]Input index is null.");
				return false;
			}
			try
			{
				SelectElement selectElement = new SelectElement(webElement);
				selectElement.SelectByIndex(byIndex);
				LogUtil.Log("Info[SelectOn]:Item has been selected");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[SelectOn]: " + e.Message);
			}
			return false;
		}

		public static bool TryParse(int number)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Sum of Displayed option
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static int AmountOfOption(IWebElement webElement)
		{
			SelectElement selectElement = new SelectElement(webElement);
			if (webElement == null)
			{
				throw new NullReferenceException("Error[SelectOn]Input element is null.");
			}
			var items = selectElement.Options.Count;
			Console.WriteLine(items);
			return items;

		}
	}
}
