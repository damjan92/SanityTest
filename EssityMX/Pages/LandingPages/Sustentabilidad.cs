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
	public class Sustentabilidad : BasePage
	{
		public Sustentabilidad(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		IWebElement HeroBanner => Driver.FindElement
			(By.CssSelector("body > div:nth-child(12) > section:nth-child(1) > div:nth-child(1) > div:nth-child(1)"));
		IWebElement HeroBanner_Img => Driver.FindElement
			(By.CssSelector("section.section div.container div.banner.banner--regular.bg-primary div.media div.media-overlay > img.img.lazy.entered.loaded"));
		//Stacked promoboxed
		IWebElement TwoColumnBoxStacked => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]"));
		IWebElement TwoColumnBoxStacked_Img => Driver.FindElement(By.XPath("//div[@class='grid col-2']//div[1]//div[1]//div[1]//img[1]"));

		IWebElement TheFirstStackedBox => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]/div[1]"));
		IWebElement TheFirstStackedBox_Img => Driver.FindElement(By.XPath("//div[@class='grid col-2 carousel cta-carousel js-card-carousel']//div[1]//div[1]//img[1]"));

		IWebElement TheSecondStackedBox => Driver.FindElement
			(By.CssSelector("body > div:nth-child(13) > section:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(2)"));
		IWebElement TheSecondStackedBox_Img => Driver.FindElement(By.XPath("//body[1]/div[8]/section[1]/div[1]/div[2]/div[2]/div[1]/img[1]"));

		IWebElement TheThirdStackedBox => Driver.FindElement(By.XPath("//body[1]/div[8]/section[1]/div[1]/div[2]/div[3]"));
		IWebElement TheThirdStackedBox_Img => Driver.FindElement(By.XPath("//body[1]/div[8]/section[1]/div[1]/div[2]/div[3]/div[1]/img[1]"));

		IWebElement TheFourthStackedBox => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]/div[4]"));
		IWebElement TheFourthStackedBox_Img => Driver.FindElement(By.XPath("//body[1]/div[8]/section[1]/div[1]/div[2]/div[4]/div[1]/img[1]"));
		//The First row of the two column promoboxes
		IWebElement TheFirstTwoColumnBox => Driver.FindElement
			(By.XPath("//body[1]/div[9]/section[1]/div[1]/div[1]"));
		IWebElement TheFirstTwoColumnBox_Img => Driver.FindElement
			(By.XPath("//body/div[@typeof='Region']/section[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement TheSecondTwoColumnBox => Driver.FindElement
			(By.XPath("//body[1]/div[9]/section[1]/div[1]/div[2]"));
		IWebElement TheSecondTwoColumnBox_Img => Driver.FindElement
			(By.XPath("//body/div[@typeof='Region']/section[1]/div[1]/div[1]/div[1]/img[1]"));
		//The second row of the column promoboxes
		IWebElement TheThirdTwoColumnBox => Driver.FindElement
			(By.XPath("//body[1]/div[9]/section[2]/div[1]/div[1]"));
		IWebElement TheThirdTwoColumnBox_Img => Driver.FindElement
			(By.XPath("//body/div[@typeof='Region']/section[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement TheFourthTwoColumnBox => Driver.FindElement
			(By.XPath("//body[1]/div[9]/section[2]/div[1]/div[2]"));
		IWebElement TheFourthTwoColumnBox_Img => Driver.FindElement
			(By.XPath("//body/div[contains(@class,'container')]/section[1]/div[1]/div[1]/div[1]/img[1]"));
		//The third row of the column promoboxes
		IWebElement TheFifthTwoColumnBox => Driver.FindElement
			(By.XPath("//body[1]/div[9]/section[3]/div[1]/div[1]"));
		IWebElement TheFifthTwoColumnBox_Img => Driver.FindElement
			(By.XPath("//body/div[@class='container']/section[1]/div[1]/div[1]/div[1]/img[1]"));
		IWebElement TheSixthTwoColumnBox => Driver.FindElement
			(By.XPath("//body[1]/div[9]/section[3]/div[1]/div[2]"));
		IWebElement TheSixthTwoColumnBox_Img => Driver.FindElement
			(By.XPath("//body/div[@class='container']/section[1]/div[1]/div[1]/div[1]/img[1]"));


		//Are components are displayed
		public bool IsTheHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(HeroBanner);
		public bool IsTwoColumnBoxStackedVisible() => AvailabilityUtil.IsElementDisplayed(TwoColumnBoxStacked);
		public bool IsTheFirstStackedBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstStackedBox);
		public bool IsTheSecondStackedBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondStackedBox);
		public bool IsTheThirdStackedBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheThirdStackedBox);
		public bool IsTheFourthStackedBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheFourthStackedBox);
		public bool IsTheFirstTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstTwoColumnBox);
		public bool IsTheSecondTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondTwoColumnBox);
		public bool IsTheThirdTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheThirdTwoColumnBox);
		public bool IsTheFourthTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheFourthTwoColumnBox);
		public bool IsTheFifthTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheFifthTwoColumnBox);
		public bool IsTheSixthTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheSixthTwoColumnBox);

		//Checking the status
		public bool IsHeroBannerImageStatusOK() => AvailabilityUtil.GetDataSrcAttribute(HeroBanner_Img, Driver);
		public bool IsTwoColumnBoxStackedImageStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TwoColumnBoxStacked_Img, Driver);
		public bool IsTheFirstStackedBoxImageStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheFirstStackedBox_Img, Driver);
		public bool IsTheSecondStackedBoxImageStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheSecondStackedBox_Img, Driver);
		public bool IsTheThirdStackedBoxImageStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheThirdStackedBox_Img, Driver);
		public bool IsTheFourthStackedBoxImageStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheFourthStackedBox_Img, Driver);
		public bool IsTheFirstTwoColumnBoxStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheFirstTwoColumnBox_Img, Driver);
		public bool IsTheSecondTwoColumnStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheSecondTwoColumnBox_Img, Driver);
		public bool IsTheThirdTwoColumnBoxStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheThirdTwoColumnBox_Img, Driver);
		public bool IsTheFourthTwoColumnBoxStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheFourthTwoColumnBox_Img, Driver);
		public bool IsTheFifthTwoColumnBoxStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheFifthTwoColumnBox_Img, Driver);
		public bool IsTheSixthTwoColumnBoxStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheSixthTwoColumnBox_Img, Driver);

	}
}
