using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanityTest.Base;
using OpenQA.Selenium;
using SanityTest.Helpers;
using System.Collections;

namespace EssityMX.Pages.HomePage
{
	public class MainPageFooter : BasePage
	{
		public MainPageFooter(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		
		IWebElement Footer => Driver.FindElement(By.CssSelector(".footer.bg-primary"));
		IWebElement SocialLink => Driver.FindElement(By.CssSelector("div[class='footer-info'] div[class='social-list']"));
		IWebElement EssityLogoFooter => Driver.FindElement(By.CssSelector("img[src='/assets/img/essity-logo-white.svg']"));


		public bool IsFooterVisible() => AvailabilityUtil.IsElementDisplayed(Footer);

		public bool AreSocialLinkVisible() => AvailabilityUtil.IsElementDisplayed(SocialLink);

		public bool IsEssityLogoFooterVisible() => AvailabilityUtil.IsElementDisplayed(EssityLogoFooter);

		public bool IsLogoFooterOK() => AvailabilityUtil.IsElementDisplayed(EssityLogoFooter);

	}
}
