using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanityTest.Base;
using SanityTest.ConfigFiles;
using EssityMX.Pages.LandingPages;
using EssityMX.Pages;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using EssityMX.Pages.HomePage;
using NUnit.Framework;


namespace EssityMX.Tests.Test_HomePage
{
	public class Test_MediosDeCommunicacion : BaseTest
	{

		[Test]
		public void Test_56_IsHeroBannerVisible()
		{
			ExtentTest test = extent.CreateTest("Test_56_IsHeroBannerVisible").Info("Test started");
			MediosDeCommunicacion mediosDeCommunicacion = new MediosDeCommunicacion(Driver);
			BasePage.OpenPage(ConfigReader.MediosDeCommunicacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			test.Log(Status.Info, "Browser has launched");
			Assert.Multiple(() =>
			{
				Assert.IsTrue(mediosDeCommunicacion.IsHeroBannerVisible(), "Hero banner is not visible");
				//Assert.IsTrue(mediosDeCommunicacion.IsHeroBannerImgStatusOk(), "Image is not status 200");
			});
			test.Log(Status.Pass, "Test_56_IsHeroBannerVisible - PASS");
		}

		[Test]
		public void Test_57_IsTheFirstThreeColumnCtaVisible()
		{
			ExtentTest test = extent.CreateTest("Test_57_IsTheFirstThreeColumnCtaVisible").Info("Test started");
			MediosDeCommunicacion mediosDeCommunicacion = new MediosDeCommunicacion(Driver);
			BasePage.OpenPage(ConfigReader.MediosDeCommunicacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			test.Log(Status.Info, "Browser has launched");
			Assert.Multiple(() =>
			{
				Assert.IsTrue(mediosDeCommunicacion.IsTheFirstThreeColumnCtaVisible(), "The First Three Column Cta is not visible");
				//Assert.IsTrue(mediosDeCommunicacion.IsTheFirstThreeColumnCtaImgStatusOk(), "Image is not status 200");
			});
			test.Log(Status.Pass, "Test_57_IsTheFirstThreeColumnCtaVisible - PASS");
		}

		[Test]
		public void Test_58_IsTheSecondThreeColumnCtaVisible()
		{
			ExtentTest test = extent.CreateTest("Test_58_IsTheSecondThreeColumnCtaVisible").Info("Test started");
			MediosDeCommunicacion mediosDeCommunicacion = new MediosDeCommunicacion(Driver);
			BasePage.OpenPage(ConfigReader.MediosDeCommunicacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			test.Log(Status.Info, "Browser has launched");
			Assert.Multiple(() =>
			{
				Assert.IsTrue(mediosDeCommunicacion.IsTheSecondThreeColumnCtaVisible(), "The Second Three Column Cta is not visible");
				Assert.IsTrue(mediosDeCommunicacion.IsTheSecondThreeColumnCtaImgStatusOk(), "Image is not status 200");
			});
			test.Log(Status.Pass, "Test_58_IsTheSecondThreeColumnCtaVisible - PASS");
			
		}

		[Test]
		public void Test_59_IsTheThirdThreeColumnCtaVisible()
		{
			MediosDeCommunicacion mediosDeCommunicacion = new MediosDeCommunicacion(Driver);
			BasePage.OpenPage(ConfigReader.MediosDeCommunicacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(mediosDeCommunicacion.IsTheThirdThreeColumnCtaVisible(), "The Thrid Three Column Cta is not visible");
				Assert.IsTrue(mediosDeCommunicacion.IsTheThirdThreeColumnCtaImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_60_IsTheContactBoxVisible()
		{
			MediosDeCommunicacion mediosDeCommunicacion = new MediosDeCommunicacion(Driver);
			BasePage.OpenPage(ConfigReader.MediosDeCommunicacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(mediosDeCommunicacion.IsTheContactBoxVisible(), "Contact box is not visible");
		}

		[Test]
		public void Test_61_IsShowEmailFunctionalityWork()
		{
			MediosDeCommunicacion mediosDeCommunicacion = new MediosDeCommunicacion(Driver);
			BasePage.OpenPage(ConfigReader.MediosDeCommunicacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(mediosDeCommunicacion.IsShowEmailFunctionalityWork(), "Show email label does not work");
		}
	}
}
