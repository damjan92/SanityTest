using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SanityTest.Base;
using OpenQA.Selenium;
using SanityTest.ConfigFiles;
using SanityTest.Enums;
using SanityTest.Helpers;

namespace EssityMX.Pages.LandingPages
{
	public class Company : BasePage
	{
		public Company(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		//HeroBanner
		IWebElement CompanyHeroBanner => Driver.FindElement
			(By.CssSelector("body > div:nth-child(12) > section:nth-child(1) > div:nth-child(1) > div:nth-child(1)"));

		IWebElement CompanyHeroBannerImage => Driver.FindElement(By.XPath("//body/div[7]/section[1]/div[1]/div[1]/div[1]/div[1]/img[1]"));

		//2-col
		IWebElement TheFirstBoxTwoCol => Driver.FindElement
			(By.CssSelector("body > div:nth-child(13) > section:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)"));

		IWebElement TheFirstBoxTwoColImage => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]/div[1]/img[1]"));

		IWebElement TheSecondBoxTwoCol => Driver.FindElement
			(By.CssSelector("body > div:nth-child(13) > section:nth-child(1) > div:nth-child(1) > div:nth-child(2)"));

		IWebElement TheSecondBoxTwoColImage => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]/div[1]/img[1]"));

		//3-col
		IWebElement TheFirstBoxThreeCol => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[1]"));
		IWebElement TheFirstBoxThreeColImage => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[1]/div[1]/img[1]"));

		IWebElement TheSecondBoxThreeCol => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[2]"));
		IWebElement TheSecondBoxThreeColImage => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[2]/div[1]/img[1]"));

		IWebElement TheThirdBoxThreeCol => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[3]/div[1]"));


		//HeroBanner
		public bool IsCompanyHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(CompanyHeroBanner);

		public bool IsCompanyHeroBannerImgOk() => AvailabilityUtil.GetDataSrcAttribute(CompanyHeroBannerImage, Driver);

		//2-col
		//The first the column box
		public bool IsTheFirstBoxTwoColVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstBoxTwoCol);

		public bool IsTheFirstBoxTwoColImageOk() => AvailabilityUtil.GetDataSrcAttribute(TheFirstBoxTwoColImage, Driver);

		//The Second box two collumn
		public bool IsSecondBoxTwoColVisble() => AvailabilityUtil.IsElementDisplayed(TheSecondBoxTwoCol);

		public bool IsSecondBoxTwoColImageOk() => AvailabilityUtil.GetDataSrcAttribute(TheSecondBoxTwoColImage, Driver);

		//3-col
		//The First Three column box 
		public bool IsFirstBoxThreeColVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstBoxThreeCol);

		public bool IsFirstBoxThreeColImageOk() => AvailabilityUtil.GetDataSrcAttribute(TheFirstBoxThreeColImage, Driver);

		//The Second3-col box
		public bool IsSecondBoxThreeColVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondBoxThreeCol);

		public bool IsSecondBoxThreeColImageOk() => AvailabilityUtil.GetDataSrcAttribute(TheSecondBoxThreeColImage, Driver);

		//The third
		public bool IsThirdBoxThreeColVisible() => AvailabilityUtil.IsElementDisplayed(TheThirdBoxThreeCol);


	}
}
