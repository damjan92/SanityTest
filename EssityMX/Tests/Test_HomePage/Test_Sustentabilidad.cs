using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SanityTest.Base;
using NUnit.Framework;
using EssityMX.Pages;
using System.Threading.Tasks;
using EssityMX.Pages.LandingPages;
using SanityTest.ConfigFiles;
using EssityMX.Pages.HomePage;

namespace EssityMX.Tests.Test_HomePage
{
	public class Test_Sustentabilidad : BaseTest
	{
		[Test]
		public void Test_28_IsHeroBanerVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheHeroBannerVisible(), "Hero Banner is not visible");
		}

		[Test]
		public void Test_29_IsTwoColumnBoxStackedVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTwoColumnBoxStackedVisible(), "Two column stacked promobox is not visible");
		}

		[Test]
		public void Test_30_IsTheFirstStackedBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheFirstStackedBoxVisible(), "The First stacked promobox is not visible");
		}

		[Test]
		public void Test_31_IsTheSecondStackedBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheSecondStackedBoxVisible(), "The Second stacked promobox is not visible");
		}

		[Test]
		public void Test_32_IsTheThirdStackedBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheThirdStackedBoxVisible(), "The Third stacked promobox is not visible");
		}

		[Test]
		public void Test_33_IsTheFourthStackedBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheFourthStackedBoxVisible(), "The Fourth stacked promobox is not visible");
		}

		//The First row of the two column promoboxes
		[Test]
		public void Test_34_IsTheFirstTwoColumnBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheFirstTwoColumnBoxVisible(), "The First two column promobox is not visible");
		}

		[Test]
		public void Test_35_IsTheSecondTwoColumnBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheSecondTwoColumnBoxVisible(), "The Second two column promobox is not visible");
		}

		[Test]
		public void Test_36_IsTheThirdTwoColumnBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheThirdTwoColumnBoxVisible(), "The Third two column promobox is not visible");
		}

		[Test]
		public void Test_37_IsTheFourthTwoColumnBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheFourthTwoColumnBoxVisible(), "The Fourth two column promobox is not visible");
		}

		[Test]
		public void Test_38_IsTheFifthTwoColumnBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheFifthTwoColumnBoxVisible(), "The Fifth two column promobox is not visible");
		}

		[Test]
		public void Test_39_IsTheSixthTwoColumnBoxVisible()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(sustentabilidad.IsTheSixthTwoColumnBoxVisible(), "The Sixth two column promobox is not visible");
		}

		[Test]
		public void Test_40_IsHeroBannerImageStatus200()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(sustentabilidad.IsHeroBannerImageStatusOK(), "HeroBannerImage is not OK/200");
				Assert.IsTrue(sustentabilidad.IsTwoColumnBoxStackedImageStatusOK(), "TwoColumnBoxStacked is not status ok/200");
				Assert.IsTrue(sustentabilidad.IsTheFirstStackedBoxImageStatusOK(), "TheFirstStackedBox is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheSecondStackedBoxImageStatusOK(), "TheSecondSTackedBox is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheThirdStackedBoxImageStatusOK(), "TheThirdStackedBox is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheFourthStackedBoxImageStatusOK(), "TheFourthStackedBox is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheFirstTwoColumnBoxStatusOK(), "FirstTwoColumnBox is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheSecondTwoColumnStatusOK(), "TheSecondTwoColumnStatusOK is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheThirdTwoColumnBoxVisible(), "TheThirdTwoColumnStatusOK is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheFourthTwoColumnBoxStatusOK(), "TheFourthTwoColumnStatusOK is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheFifthTwoColumnBoxStatusOK(), "FourthStackedBox is not ok/200");
				Assert.IsTrue(sustentabilidad.IsTheSixthTwoColumnBoxStatusOK(), "TheSixTwoColumnBox is not ok/200");

			});
		}

		[Test]
		public void Test_VerificationOfPageTitle()
		{
			Sustentabilidad sustentabilidad = new Sustentabilidad(Driver);
			BasePage.OpenPage(ConfigReader.SustentabilidadLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.AreEqual(BasePage.GetTitle(), "Crear valor sustentable juntos", "Titles are not the same");
		}
	}
}
