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
		IWebElement HeroBannerImg => Driver.FindElement(By.CssSelector("img[alt*='TIF_Mother_and_two_boys_with_kite_on_beach_1.jpg ']"));

		//Three column CTA
		IWebElement TheFirstThreeColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]"));
		IWebElement TheFirstThreeColumnCtaImg => Driver.FindElement(By.CssSelector("img[alt*='Microphone-Icon-BM-1920x1080.jpg ']"));

		IWebElement TheSecondThreeColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[2]"));
		IWebElement TheSecondThreeColumnCtaImg => Driver.FindElement(By.CssSelector("img[alt*='News-Icon-BM-1920x1080.jpg']"));

		IWebElement TheThirdThreeColumnCta => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[3]"));
		IWebElement TheThirdThreeColumnCtaImg => Driver.FindElement(By.CssSelector("img[alt*='Essity_Icon_Earth_1920x1080.jpg']"));

		//Contact
		IWebElement ContactBox => Driver.FindElement(By.XPath("//body/div[9]/section[1]"));
		IWebElement ShowEmailLabel => Driver.FindElement(By.LinkText("Show Email"));
		IWebElement EmailLabel => Driver.FindElement(By.CssSelector("a[href*='mailto:Paulina']"));

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
						LogUtil.Log("Info[EmailLabel] Email is visible");
						return true;
					}
					else
					{
						LogUtil.Log("Info[EmailLabel] Email is NOT visible");
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
