using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using SanityTest.Helpers;
using SanityTest.Base;
using System.Threading.Tasks;

namespace EssityMX.Pages.LandingPages
{
	public class Carreras : BasePage
	{
		public Carreras(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		//Hero banner
		IWebElement HeroBanner => Driver.FindElement(By.XPath("//body/div[@typeof='Region']/section[@class='section']/div[@class='container']/div[1]"));
		IWebElement HeroBannerImg => Driver.FindElement(By.XPath("//div[@typeof='Region']//div[@class='container']//div[1]//div[2]//img[1]"));

		//The first promobox
		IWebElement TheFirstPromobox => Driver.FindElement
			(By.XPath("//div[contains(@class,'bg-primary')]//div//div[contains(@class,'banner--flipped')]"));
		IWebElement TheFirstPomoboxImg => Driver.FindElement
			(By.XPath("(//img[@alt='Company_Animation_US_HMS .jpg'])[1]"));

		//The second promobox
		IWebElement TheSecondPromobox => Driver.FindElement
			(By.XPath("//div[contains(@class,'bg-secondary')]//div//div[contains(@class,'banner--flipped')]"));
		IWebElement TheSecondPrombooxImg => Driver.FindElement
			(By.XPath("(//img[@class='img lazy entered error'])[1]"));

		//TheStackPromobox
		IWebElement TheStackedPromobox => Driver.FindElement(By.XPath("//body/div[@class='container']/section[2]/div[1]/div[1]"));
		IWebElement TheStackedPromoboxImg => Driver.FindElement(By.XPath("//body[1]/div[9]/section[1]/div[1]/div[1]/div[1]/img[1]"));

		IWebElement TheFirstStackedPromobox => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[2]"));
		IWebElement TheFirstStackedPromoboxImg => Driver.FindElement(By.XPath("//body/div[@typeof='Region']/section/div/div/div/div[2]/img[1]"));

		IWebElement TheSecondStackedPromobox => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[3]"));
		IWebElement TheSecondStackedPromoboxImg => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[2]/div[2]/div[1]/img[1]"));

		IWebElement TheThirdStackedPromobox => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[4]"));
		IWebElement TheThirdStackedPromoboxImg => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[2]/div[3]/div[1]/img[1]"));

		IWebElement TheFourthStackedPromobox => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[5]"));
		IWebElement TheFourthStackedPromoboxImg => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[2]/div[4]/div[1]/img[1]"));

		//Two column CTA
		IWebElement TheFirstTwoColumnCta => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[6]"));
		IWebElement TheFirstTwoColumnCtaImg => Driver.FindElement(By.XPath("//body/div[10]/section[1]/div[1]/div[1]/div[1]/img[1]"));

		IWebElement TheSecondTwoColumnCta => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[7]"));
		IWebElement TheSecondTwoColumnCtaImg => Driver.FindElement(By.XPath("//body/div[10]/section[1]/div[1]/div[2]/div[1]/img[1]"));

		//Four Column CTA
		IWebElement TheFirstFourColumnCta => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[8]"));
		IWebElement TheSecondFourColumnCta => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[9]"));
		IWebElement TheThirdFourColumnCta => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[10]"));
		IWebElement TheFourthFourColumnCta => Driver.FindElement(By.XPath("(//div[@class='cta js-cta-clickable cta-clickable bg-tertiary'])[11]"));


		public bool IsHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(HeroBanner);
		public bool IsHeroBannerImageStatusOK() => AvailabilityUtil.GetDataSrcAttribute(HeroBannerImg, Driver);

		public bool IsTheFirstPromoboxVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstPromobox);
		public bool IsTheFirstPromoboxImgStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheFirstPomoboxImg, Driver);

		public bool IsTheSecondPromoboxVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondPromobox);
		public bool IsTheSecondPromoboxImgStatusOK() => AvailabilityUtil.GetDataSrcAttribute(TheSecondPrombooxImg, Driver);

		public bool IsTheStackedPomoboxVisible() => AvailabilityUtil.IsElementDisplayed(TheStackedPromobox);
		public bool IsTheStackedPromoboxImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheStackedPromoboxImg, Driver);

		public bool IsTheFirstStackedPromoboxVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstStackedPromobox);
		public bool IsTheFirstStackedPromoboxImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheFirstStackedPromoboxImg, Driver);

		public bool IsTheSecondStackedPromoboxVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondStackedPromobox);
		public bool IsTheSecondStackedPromoboxImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheSecondStackedPromoboxImg, Driver);

		public bool IsTheThirdStackedPromoboxVisible() => AvailabilityUtil.IsElementDisplayed(TheThirdStackedPromobox);
		public bool IsTheThirdStackedPromoboxImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheThirdStackedPromoboxImg, Driver);

		public bool IsTheFourthStackedPromoboxVisible() => AvailabilityUtil.IsElementDisplayed(TheFourthStackedPromobox);
		public bool IsTheFourthStackedPromoboxImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheFourthStackedPromoboxImg, Driver);

		public bool IsTheFirstTwoColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstTwoColumnCta);
		public bool IsTheFirstTwoColumnCtaImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheFirstTwoColumnCtaImg, Driver);

		public bool IsTheSecondTwoColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondTwoColumnCta);
		public bool IsTheSecondTwoColumnCtaImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheSecondTwoColumnCtaImg, Driver);

		public bool IsTheFirstFourColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstFourColumnCta);
		public bool IsTheSecondFourColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondFourColumnCta);
		public bool IsTheThirdFourColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheThirdFourColumnCta);
		public bool IsTheFourthFourColumnCtaVisible() => AvailabilityUtil.IsElementDisplayed(TheFourthFourColumnCta);
	}
}
