using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanityTest.Base;
using EssityMX.Pages;
using SanityTest.ConfigFiles;
using EssityMX.Pages.HomePage;
using NUnit.Framework;
using EssityMX.Pages.LandingPages;

namespace EssityMX.Tests.Test_HomePage
{
	public class Test_Innovacion : BaseTest
	{
		[Test]
		public void Test_52_IsHeroBannerVisible()
		{
			Innnovacion innovacion = new Innnovacion(Driver);
			BasePage.OpenPage(ConfigReader.InnovacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(innovacion.IsHeroBannerVisible(), "Hero banner is not visible");
				Assert.IsTrue(innovacion.IsHeroBannerImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_53_IsTheFirstTwoColumnCtaVisible()
		{
			Innnovacion innovacion = new Innnovacion(Driver);
			BasePage.OpenPage(ConfigReader.InnovacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(innovacion.IsTheFirstTwoColumnCtaVisible(), "The first two column cta is not visible");
				Assert.IsTrue(innovacion.IsTheFirstTwoColumnImgStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_54_IsTheSecondTwoColumnCtaVisible()
		{
			Innnovacion innovacion = new Innnovacion(Driver);
			BasePage.OpenPage(ConfigReader.InnovacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(innovacion.IsTheSecondTwoColumnCtaVisible(), "The second two column cta is not visible");
				Assert.IsTrue(innovacion.IsTheSecondTwoColumnCtaStatusOk(), "Image is not status 200");
			});
		}

		[Test]
		public void Test_55_IsThePromoboxVisible()
		{
			Innnovacion innovacion = new Innnovacion(Driver);
			BasePage.OpenPage(ConfigReader.InnovacionLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(innovacion.IsThePromoboxVisible(), "The promobox is not visible");
				Assert.IsTrue(innovacion.IsThePromoboxImgStatusOk(), "Image is not status 200");
			});
		}

	}
}
