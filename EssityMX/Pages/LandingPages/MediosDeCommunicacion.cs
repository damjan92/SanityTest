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
	public class MediosDeCommunicacion : BasePage
	{
		public  MediosDeCommunicacion(IWebDriver driver) : base(driver)
		{
		}

		//HeroBanner
		IWebElement HeroBanner => Driver.FindElement(By.XPath("//body/div[7]/section[1]/div[1]/div[1]"));
		IWebElement HeroBannerImg => Driver.FindElement(By.XPath("//body/div[7]/section[1]/div[1]/div[1]/div[1]/div[1]/img[1]"));

		//Three column CTA
		IWebElement TheFirstThreeColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]"));
		IWebElement TheFirstThreeColumnCtaImg => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]/div[1]/img[1]"));

		IWebElement TheSecondThreeColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]"));
		IWebElement TheSecondThreeColumnCtaImg => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]/div[1]/img[1]"));

		IWebElement TheThirdThreeColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[3]"));
		IWebElement TheThirdThreeColumnCtaImg => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[3]/div[1]/img[1]"));

		//Contact
		IWebElement ContactBox => Driver.FindElement(By.XPath("//body/div[9]/section[1]"));
		IWebElement ShowEmailLabel => Driver.FindElement(By.LinkText("Show Email"));
		IWebElement EmailLabel => Driver.FindElement(By.LinkText("Paulina.Barragan@essity.com"));

		public bool IsHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(HeroBanner);
		public bool IsHeroBannerImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(HeroBannerImg, Driver);

		public bool IsTheFirstThreeColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstThreeColumnCta);
		public bool IsTheFirstThreeColumnCtaImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheFirstThreeColumnCtaImg, Driver);

		public bool IsTheSecondThreeColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondThreeColumnCta);
		public bool IsTheSecondThreeColumnCtaImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheSecondThreeColumnCtaImg, Driver);

		public bool IsTheThirdThreeColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheThirdThreeColumnCta);
		public bool IsTheThirdThreeColumnCtaImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheThirdThreeColumnCtaImg, Driver);

		public bool IsTheContactBoxVisible() => AvailabilityUtil.IsElementDisplayed(ContactBox);

		public bool IsShowEmailFunctionalityWork()
		{
			try
			{
				if (ShowEmailLabel.Displayed && ShowEmailLabel.Enabled)
				{
					WaitUtil.WaitToBeVisibleAndClickable(ShowEmailLabel, Driver);
					if (EmailLabel.Displayed)
					{
						return true;
					}
				}
				return true;
			}
			catch(Exception e)
			{
				LogUtil.Log($"Error:{e.Message}");
				return false;
			}
		}


	}
}
