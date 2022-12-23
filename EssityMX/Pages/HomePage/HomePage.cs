using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SanityTest.Helpers;
using SanityTest.Base;
using SanityTest.Enums;
using System.Threading;

namespace EssityMX.Pages.HomePage
{
	public class HomePage : BasePage
	{
		public  HomePage(IWebDriver driver) : base(driver)
		{
		}

		IWebElement FirstHeroBanner => Driver.FindElement
			(By.XPath("//body/section[contains(@class,'section section--hero')]/div[contains(@typeof,'Region')]/div[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement FirstHeroBannerImg => Driver.FindElement(By.XPath("//body/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement BrandComponent => Driver.FindElement(By.CssSelector(".hero-brands-list.js-brands-carousel"));
		IWebElement SecondHeroBanner => Driver.FindElement
			(By.XPath("//body/section[@class='section section--hero']/div[@typeof='Region']/div[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement SecondHeroBannerImg => Driver.FindElement(By.XPath("//body/section[1]/div[1]/div[3]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement ThirdHeroBanner => Driver.FindElement
			(By.XPath("//body/section[@class='section section--hero']/div[@typeof='Region']/div[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement ThirdHeroBannerImg => Driver.FindElement(By.XPath("//body/section[1]/div[1]/div[4]/div[1]/div[1]/div[1]/img[1]"));

		//The first Hero banner
		public bool IsFirstHeroBannerVisible()
		{
			return AvailabilityUtil.IsElementDisplayed(FirstHeroBanner);
		}

		public bool IsFirstImageOk()
		{
			return AvailabilityUtil.GetDataSrcAttribute(FirstHeroBannerImg, Driver);
		}

		public bool IsBrandComponentVisible()
		{
			return AvailabilityUtil.IsElementDisplayed(BrandComponent);
		} 

		//The second Hero banner
		public bool IsSecondHeroBannerVisible()
		{
			return AvailabilityUtil.IsElementDisplayed(SecondHeroBanner);
		}

		public bool IsSecondImageOK()
		{
			return AvailabilityUtil.GetDataSrcAttribute(SecondHeroBannerImg, Driver);
		}

		//The Third Hero banner
		public bool IsThirhHeroBannerVisible()
		{
			return AvailabilityUtil.IsElementDisplayed(ThirdHeroBanner);
		}

		public bool IsThirdImageOK()
		{
			return AvailabilityUtil.GetDataSrcAttribute(ThirdHeroBannerImg, Driver);
		}
		

	}
}
