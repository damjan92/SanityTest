using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanityTest.Base;
using EssityMX.Pages;
using SanityTest.ConfigFiles;
using NUnit.Framework;
using EssityMX.Pages.LandingPages;
using EssityMX.Pages.HomePage;

namespace EssityMX.Tests.Test_HomePage
{
	public class Test_Carreras : BaseTest
	{
		[Test]
		public void Test_41_IsHeroBannerVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				//Assert.IsTrue(carreras.IsHeroBannerVisible(), "Hero banner is not visible");
				Assert.IsTrue(carreras.IsHeroBannerImageStatusOK(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_42_IsTheFirstPromoboxVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheFirstPromoboxVisible(), "The first promobox is not visible");
				Assert.IsTrue(carreras.IsTheFirstPromoboxImgStatusOK(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_43_IsTheSecondPromoboxVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheSecondPromoboxVisible(), "The second promobox is not visible");
				Assert.IsTrue(carreras.IsTheSecondPromoboxImgStatusOK(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_44_IsTheStackedPomoboxVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheStackedPomoboxVisible(), "Stacked promobox is not visible");
				Assert.IsTrue(carreras.IsTheStackedPromoboxImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_45_IsTheFirstStackedPromoboxVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheFirstStackedPromoboxVisible(), "The frist stacked promobox is not visible");
				Assert.IsTrue(carreras.IsTheFirstStackedPromoboxImgStatusOk(), "Image is not visible");
			});
		}

		[Test]
		public void Test_46_IsTheSecondStackedPromoboxVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheSecondStackedPromoboxVisible(), "The second stacked promobox is not visible");
				Assert.IsTrue(carreras.IsTheSecondStackedPromoboxImgStatusOk(), "Image is not ok");
			});
		}

		[Test]
		public void Test_47_IsTheThirdStackedPromoboxVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheThirdStackedPromoboxVisible(), "The third stacked promobox is not visible");
				Assert.IsTrue(carreras.IsTheThirdStackedPromoboxImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_48_IsTheFourthStackedPromoboxVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheFourthStackedPromoboxVisible(), "The fourth stacked promobox is not visible");
				Assert.IsTrue(carreras.IsTheFourthStackedPromoboxImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_49_IsTheFirstTwoColumnCtaVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheFirstTwoColumnCtaVisible(), "The first two column is not visible");
				Assert.IsTrue(carreras.IsTheFirstTwoColumnCtaImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_50_IsTheSecondTwoColumnCtaVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheSecondTwoColumnCtaVisible(), "The second two column is not visible");
				Assert.IsTrue(carreras.IsTheSecondTwoColumnCtaImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_51_IsTheFourthColumnsVisible()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(carreras.IsTheFirstFourColumnCtaVisible(), "The first fourth column is not visible");
				Assert.IsTrue(carreras.IsTheSecondFourColumnCtaVisible(), "The second fourth column is not visible");
				Assert.IsTrue(carreras.IsTheThirdFourColumnCtaVisible(), "The third fourth column is not visible");
				Assert.IsTrue(carreras.IsTheFourthFourColumnCtaVisible(), "The four fourth column is not visible");
			});
		}

		[Test]
		public void Test_VerificationOfPageTitle()
		{
			Carreras carreras = new Carreras(Driver);
			BasePage.OpenPage(ConfigReader.CarrerasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.AreEqual(BasePage.GetTitle(), "Essity Careers - Improving lives, every day | Essity", "Titles are not the same");
		}
	}
}
