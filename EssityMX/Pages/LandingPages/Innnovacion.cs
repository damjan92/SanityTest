using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SanityTest.Base;
using SanityTest.Helpers;
using OpenQA.Selenium;
using System.Threading.Tasks;

namespace EssityMX.Pages.LandingPages
{
	public class Innnovacion : BasePage
	{
		public Innnovacion(IWebDriver driver) : base(driver)
		{
		}

		//Hero Banner
		IWebElement HeroBanner => Driver.FindElement(By.XPath("//body/div[7]/section[1]/div[1]/div[1]"));
		IWebElement HeroBannerImg => Driver.FindElement(By.XPath("//body/div[7]/section[1]/div[1]/div[1]/div[1]/div[1]/img[1]"));

		//Two column CTA
		IWebElement TheFirstTwoColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]"));
		IWebElement TheFirstTwoColumnCtaImg => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]/div[1]/img[1]"));

		IWebElement TheSecondTwoColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]"));
		IWebElement TheSecondTwoColumnCtaImg => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]/div[1]/img[1]"));

		//Promobox Image
		IWebElement ThePromobox => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[1]/div[1]"));
		IWebElement ThePromoboxImg => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[1]/div[1]/div[1]/div[1]/img[1]"));

		public bool IsHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(HeroBanner);
		public bool IsHeroBannerImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(HeroBannerImg, Driver);

		public bool IsTheFirstTwoColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstTwoColumnCta);
		public bool IsTheFirstTwoColumnImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheFirstTwoColumnCtaImg, Driver);
		public bool IsTheSecondTwoColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondTwoColumnCta);
		public bool IsTheSecondTwoColumnCtaStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheSecondTwoColumnCtaImg, Driver);

		public bool IsThePromoboxVisible() => AvailabilityUtil.IsElementDisplayed(ThePromobox);
		public bool IsThePromoboxImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(ThePromoboxImg, Driver);
	}
}
