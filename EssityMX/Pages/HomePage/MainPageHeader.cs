using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SanityTest.Base;
using OpenQA.Selenium;
using SanityTest.Helpers;
using System.Collections;

namespace EssityMX.Pages.HomePage
{
	public class MainPageHeader : BasePage
	{
		public MainPageHeader(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement EssityShare => Driver.FindElement(By.CssSelector(".top-share"));
		IWebElement SelectRegion => 
			Driver.FindElement(By.CssSelector("button[class='btn btn--link bg-primary js-toggle js-top-toggle'] i[class='i i-globe']"));
		IWebElement SearchButton => 
			Driver.FindElement(By.CssSelector("button[class='btn btn--link bg-primary js-toggle js-top-toggle'] i[class='i i-search']"));
		IWebElement EssityLogoNav => Driver.FindElement(By.CssSelector("a[class='navbar-logo'] img[alt='Essity logo']"));


		public bool IsEssityShareVisible() => AvailabilityUtil.IsElementDisplayed(EssityShare);

		public bool IsSelectRegionVisible() => AvailabilityUtil.IsElementDisplayed(SelectRegion);

		public bool IsSearchButtonVisible() => AvailabilityUtil.IsElementDisplayed(SearchButton);

		public bool IsEssityLogoVisible() => AvailabilityUtil.IsElementDisplayed(EssityLogoNav);

	}
}
