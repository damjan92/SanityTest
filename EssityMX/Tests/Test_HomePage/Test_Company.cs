using SanityTest.Base;
using System;
using EssityMX.Pages.LandingPages;
using SanityTest.ConfigFiles;
using EssityMX.Pages.HomePage;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EssityMX.Tests.Test_HomePage
{
	public class Test_Company : BaseTest
	{

		[Test]
		public void Test_09_IsCompanyHeroBannerVisible()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsCompanyHeroBannerVisible(), "[Test_09]Hero banner is not visible");
		}

		[Test]
		public void Test_10_IsCompanyHeroBannerImageOk()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsCompanyHeroBannerImgOk(), "[Test_09]Hero banner image is not visible");
		}

		[Test]
		public void Test_11_IsTheFirstBoxTwoColVisible()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsTheFirstBoxTwoColVisible(), "[Test_09]Two column box is not visible");
		}

		[Test]
		public void Test_12_IsTheFirstBoxTwoColImageOk()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsTheFirstBoxTwoColImageOk(), "[Test_09]Two column box image is not visible");
		}

		[Test]
		public void Test_13_IsSecondBoxTwoColVisble()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsSecondBoxTwoColVisble(), "[Test_09]Two column box is not visible");
		}

		[Test]
		public void Test_14_IsSecondBoxTwoColImageOk()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsSecondBoxTwoColImageOk(), "[Test_09]Two column box image is not visible");
		}

		[Test]
		public void Test_15_IsFirstBoxThreeColVisible()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsFirstBoxThreeColVisible(), "[Test_09]Two column box  is not visible");
		}

		[Test]
		public void Test_16_IsFirstBoxThreeColImageOk()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsFirstBoxThreeColImageOk(), "[Test_09]Two column box image is not visible");
		}

		[Test]
		public void Test_17_IsSecondBoxThreeColVisible()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsSecondBoxThreeColVisible(), "[Test_09]Two column box  is not visible");
		}

		[Test]
		public void Test_18_IsSecondBoxThreeColImageOk()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsSecondBoxThreeColImageOk(), "[Test_09]Two column box image is not visible");
		}

		[Test]
		public void Test_19_IsThirdBoxThreeColVisible()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(company.IsThirdBoxThreeColVisible(), "[Test_09]Two column box  is not visible");
		}

		[Test]
		public void Test_VerificationOfPageTitle()
		{
			Company company = new Company(Driver);
			BasePage.OpenPage(ConfigReader.CompanyLandingPageUrl);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.AreEqual(BasePage.GetTitle(), "About our Company | Essity", "Titles are not the same");
		}
	}
}
