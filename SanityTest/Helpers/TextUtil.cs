using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SanityTest.Enums;

namespace SanityTest.Helpers
{
	
	public static class TextUtil
	{

		public static IWebDriver Driver;

		/// <summary>
		/// Send keys on webelement
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="text"></param>
		/// <returns></returns>
		public static bool SendKeys(IWebElement webElement, string text)
		{
			if (webElement == null)
			{
				return false;
				throw new NoSuchElementException("Error[OnSendKeys]: Element is unavailable");
				throw new NullReferenceException("Error[OnSendKeys]: Element is null");
			}
			try
			{
				webElement.SendKeys(text);
				LogUtil.Log("Info[OnSendKeys]: Keys has been sent");
			}
			catch (Exception e)
			{
				Console.WriteLine("Error[OnSendKeys]: " + e.Message);
			}
			return false;
		}

		//Actions Send keys
		public static string ActionSendKeys(string keys, IWebElement webElement)
		{
			Actions action = new Actions(Driver);
			try
			{
				action.MoveToElement(webElement).SendKeys(keys).Build().Perform();
				LogUtil.Log("Info[ActionSendKeys]: Text is sent");
				return TextUtil.GetText(webElement);
			}
			catch (Exception e)
			{
				LogUtil.Log("Error[ActionSendKeys]: " + e.Message);
			}
			return null;

		}

		/// <summary>
		/// Get text by attribute
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		/// 
		public static string GetTextByValue(IWebElement webElement,  Attributes attributes)
		{
			if (webElement.Displayed)
			{
				LogUtil.Log("The text is: " + webElement.GetAttribute(attributes.ToString()));
				return webElement.GetAttribute(attributes.ToString());
			}
			else
			{
				throw new NoSuchElementException("Error[OnGetText]: Element is unavailable");
			}
		}


		/// <summary>
		/// Get text by Selenium method
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static string GetText(IWebElement webElement)
		{
			try
			{
				LogUtil.Log($"[GetText]The text is: {webElement.Text}");
				return webElement.Text;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[GetText]The text is: {e.Message}");
				return null;
			}
		}

		/// <summary>
		/// Clear text from fields
		/// </summary>
		/// <param name="webElement"></param>
		/// <returns></returns>
		public static bool ClearText(IWebElement webElement)
		{
			if (webElement == null)
			{
				throw new NullReferenceException("Error[ClickOn]: Element is null");
				throw new NoSuchElementException("Error[ClickOn]Input element is not available.");
			}
			try
			{
				webElement.Clear();
			}
			catch (Exception e)
			{
				LogUtil.Log("Error[ClickOn]: " + e.Message);
			}
			return false;
		}

		/// <summary>
		/// Return is element contain provided string
		/// </summary>
		/// <param name="webElement"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static bool TextContain(IWebElement webElement, string name)
		{
			if (webElement.Text.Contains(name))
			{
				LogUtil.Log("String contain provided string");
				LogUtil.Log(webElement.Text);
				return true;
			}
			else
			{
				return false;
				throw new NoSuchElementException
					("Error[TextContain]: Element is not displayed");
			}
		}
	}
}
