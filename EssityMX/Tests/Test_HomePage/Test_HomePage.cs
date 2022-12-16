using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanityTest.Base;
using NUnit.Framework;
using SanityTest.ConfigFiles;
using SanityTest.Helpers;
using OpenQA.Selenium;
using EssityMX.Pages.HomePage;
using System.Threading;

namespace EssityMX.Tests.Test_HomePage
{
	[TestFixture]
	public class Test_HomePage : BaseTest
	{

		[Test]
		public void Test_01_TestMainPageHeader()
		{
			MainPageHeader mainPageHeader = new MainPageHeader(Driver);
			string url = ConfigReader.HomepageUrl;
			BasePage.OpenPage(url);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(mainPageHeader.IsEssityLogoVisible(), "Essity Logo is not visible");
				Assert.IsTrue(mainPageHeader.IsEssityShareVisible(), "Essity share is not visible");
				Assert.IsTrue(mainPageHeader.IsSearchButtonVisible(), "Search field is not visible");
				Assert.IsTrue(mainPageHeader.IsSelectRegionVisible(), "Region button is not visible");
			});
		}

		[Test]
		public void Test_02_IsFirstHeroBannerVisible()
		{
			HomePage homePage = new HomePage(Driver);
			BasePage.OpenPage(ConfigReader.HomepageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(homePage.IsFirstHeroBannerVisible(), "Header is not visible");
		}

		[Test]
		public void Test_03_IsBrandComponentVisible()
		{
			HomePage homePage = new HomePage(Driver);
			BasePage.OpenPage(ConfigReader.HomepageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(homePage.IsBrandComponentVisible(), "Brand component is not visible");
		}

		[Test]
		public void Test_04_IsThirdHeroBannerVisible()
		{
			HomePage homePage = new HomePage(Driver);
			BasePage.OpenPage(ConfigReader.HomepageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(homePage.IsThirhHeroBannerVisible(), "Brand component is not visible");
		}

		

		[Test]
		public void Test_05_IsFirstImageOK()
		{
			HomePage homePage = new HomePage(Driver);
			BasePage.OpenPage(ConfigReader.HomepageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(homePage.IsFirstImageOk(), "Brand component is not visible");
		}

		[Test]
		public void Test_06_IsSecondImageOK()
		{
			HomePage homePage = new HomePage(Driver);
			BasePage.OpenPage(ConfigReader.HomepageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(homePage.IsSecondImageOK(), "Brand component is not visible");
		}

		[Test]
		public void Test_07_IsThirdImageOK()
		{
			HomePage homePage = new HomePage(Driver);
			BasePage.OpenPage(ConfigReader.HomepageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(homePage.IsThirdImageOK(), "Brand component is not visible");
		}

		[Test]
		public void Test_08_TestMainPageFooter()
		{
			MainPageFooter mainPageFooter = new MainPageFooter(Driver);
			BasePage.OpenPage(ConfigReader.HomepageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(mainPageFooter.AreSocialLinkVisible(), "Social links are not visible");
				Assert.IsTrue(mainPageFooter.IsFooterVisible(), "Footer is not visible");
				Assert.IsTrue(mainPageFooter.IsEssityLogoFooterVisible(), "Search field is not visible");
				Assert.IsTrue(mainPageFooter.IsLogoFooterOK(), "Region button is not visible");
			});
		}


	}
}
