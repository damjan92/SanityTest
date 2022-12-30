using OpenQA.Selenium;
using SanityTest.Base;
using System;
using SanityTest.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssityMX.Pages.LandingPages
{
	public class BoletinesDePrensa : BasePage
	{
		public BoletinesDePrensa(IWebDriver driver) : base(driver)
		{
		}

		//Collections
		IReadOnlyCollection<IWebElement> PressReleasesItemsInListView => Driver.FindElements(By.CssSelector("div[class='result-item']"));
		IReadOnlyCollection<IWebElement> PressReleasesItemsInGridView => Driver.FindElements(By.CssSelector("div[class='masonry-item']"));

		//Filters
		IWebElement SelectYearFilter => Driver.FindElement(By.XPath("//body/div[7]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/section[1]/section[1]/div[1]/div[1]/select[1]"));
		IWebElement SelectMonthFilter => Driver.FindElement(By.CssSelector("span[title*='Select month (all)']"));
		IWebElement SelectTopicFilter => Driver.FindElement(By.CssSelector("span[title='Select topic (all)']"));
		IWebElement SearchField => Driver.FindElement(By.CssSelector("#press-release-search"));

		IWebElement Pagination => Driver.FindElement(By.CssSelector("nav[class='pagination']"));
		IWebElement ListViewButton => Driver.FindElement(By.CssSelector("i[class='i i-list']"));
		IWebElement GridViewButton => Driver.FindElement(By.CssSelector("i[class='i i-grid']"));

		//Checkers
		IReadOnlyCollection<IWebElement> YearFiltersChecker => Driver.FindElements(By.XPath("//p[contains(text(),' de 2021 ')]"));
		IWebElement YearInPress => Driver.FindElement(By.XPath("//p[contains(text(),' de 2021 ')]"));
		IReadOnlyCollection<IWebElement> MonthFiltersChecker => Driver.FindElements(By.XPath("//p[contains(text(),' de noviembre ')]"));
		IWebElement ReportExampleCheck => Driver.FindElement(By.XPath("//span[contains(text(),'Year-end Report 2021')]"));

		IList<IWebElement> PressResults => Driver.FindElements(By.CssSelector("a[href*='cdp']"));

		//Verifying number of presses on the page in List view
		public bool CheckNumOfPressInListView()
		{
			try
			{
				WaitUtil.WaitToBeVisibleAndClickable(ListViewButton, Driver);
				System.Threading.Thread.Sleep(1000);
				if (PressReleasesItemsInListView.Count == 10)
				{
					LogUtil.Log("Info[PressReleases]: Number of press releases in list view is 10");
					return true;
				}
				else
				{
					LogUtil.Log("Warning[PressReleases]: Number of press releases in list view is NOT 10");
					return false;
				}
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[PressReleases] {e.Message}");
				return false;
			}
		}

		//Verifying number of presses on the page in Grid view
		public bool CheckNumOfPressInGridView()
		{
			try
			{
				WaitUtil.WaitToBeVisibleAndClickable(GridViewButton, Driver);
				System.Threading.Thread.Sleep(1000);
				if (PressReleasesItemsInGridView.Count == 10)
				{
					LogUtil.Log("Info[PressReleases]: Number of press releases in grid view is 10");
					return true;
				}
				else
				{
					LogUtil.Log("Warning[PressReleases]: Number of press releases in grid view is NOT 10");
					return false;
				}
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[PressReleases] {e.Message}");
				return false;
			}
		}
		//AvailabilityUtil.IsElementDisplayed(items);
		//Search for press
		public bool IsSearchFieldWorkAsExpected(string searchedItem)
		{
			try
			{
				AvailabilityUtil.ScrollIntoViewJS(SearchField, Driver);
				TextUtil.SendKeys(SearchField, searchedItem);

				foreach (IWebElement items in PressResults)
				{
					LogUtil.Log($"Elements {items.Text}");
				}
				return true;

			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[SearchField] {e.Message}");
				return false;
			}
		}

		//Pagination
		public bool IsPaginationDisplayed() => WaitUtil.WaitToBeVisible(Pagination, Driver);


		//Verifying Select year filter
		//public bool IsSelectFilterWork()
		//{

		//	try
		//	{
		//		SelectUtil.SelectElementByValue(SelectYearFilter, "2021");
		//		WaitUtil.WaitToBeVisible(YearInPress, Driver);
		//		foreach (var item in YearFiltersChecker)
		//		{
		//			item.FindElement(By.XPath("//p[contains(text(),' de 2021 ')]"));
		//			if (AvailabilityUtil.IsElementDisplayed(item))
		//			{
		//				LogUtil.Log("Foreach, item has found");
		//				return true;
		//			}
		//			else
		//			{
		//				LogUtil.Log("There is no item with that Year");
		//			}
		//		}
		//		return true;
		//	}
		//	catch (Exception e)
		//	{
		//		LogUtil.Log($"Error[YearFilter]: {e.Message}");
		//		return false;
		//	}
		//}
	}
}
