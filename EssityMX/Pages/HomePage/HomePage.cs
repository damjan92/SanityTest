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
		IWebElement FirstHeroBannerImg => Driver.FindElement(By.CssSelector("img[alt*='Essity-CoverImage_2880x1300.jpg']"));
		IWebElement BrandComponent => Driver.FindElement(By.CssSelector(".hero-brands-list.js-brands-carousel"));
		IWebElement SecondHeroBanner => Driver.FindElement
			(By.XPath("//body/section[@class='section section--hero']/div[@typeof='Region']/div[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement SecondHeroBannerImg => Driver.FindElement(By.CssSelector("img[alt*='Mother_and_two_boys_with_kite_on_beach_1.jpg ']"));
		IWebElement ThirdHeroBanner => Driver.FindElement
			(By.XPath("//body/section[@class='section section--hero']/div[@typeof='Region']/div[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement ThirdHeroBannerImg => Driver.FindElement(By.CssSelector("img[alt*='Two_young_women_workout_in_urban_area_10.tif']"));

		//The first Hero banner
		public bool IsFirstHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(FirstHeroBanner);
		public bool IsFirstImageOk() => AvailabilityUtil.GetDataSrcAttribute(FirstHeroBannerImg, Driver);

		public bool IsBrandComponentVisible() => AvailabilityUtil.IsElementDisplayed(BrandComponent);

		//The second Hero banner
		public bool IsSecondHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(SecondHeroBanner);
		public bool IsSecondImageOK() => AvailabilityUtil.GetDataSrcAttribute(SecondHeroBannerImg, Driver);

		//The Third Hero banner
		public bool IsThirhHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(ThirdHeroBanner);
		public bool IsThirdImageOK() => AvailabilityUtil.GetDataSrcAttribute(ThirdHeroBannerImg, Driver);


	}
}
