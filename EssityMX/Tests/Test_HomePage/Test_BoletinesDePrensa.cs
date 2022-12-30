using SanityTest.Base;
using System;
using NUnit.Framework;
using SanityTest.ConfigFiles;
using EssityMX.Pages.LandingPages;
using EssityMX.Pages.HomePage;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssityMX.Tests.Test_HomePage
{
	public class Test_BoletinesDePrensa : BaseTest
	{
		[Test]
		public void Test_62_CheckNumOfPressInListView()
		{
			BoletinesDePrensa boletinesDePrensa = new BoletinesDePrensa(Driver);
			BasePage.OpenPage(ConfigReader.BoletinesDePrensa);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(boletinesDePrensa.CheckNumOfPressInListView(), "Number of press releases in list view is incorrect");
		}

		[Test]
		public void Test_63_CheckNumOfPressInGridView()
		{
			BoletinesDePrensa boletinesDePrensa = new BoletinesDePrensa(Driver);
			BasePage.OpenPage(ConfigReader.BoletinesDePrensa);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(boletinesDePrensa.CheckNumOfPressInGridView(), "Number of press releases in grid view is incorrect");
		}

		[Test]
		public void Test_63_IsPaginationDisplayed()
		{
			BoletinesDePrensa boletinesDePrensa = new BoletinesDePrensa(Driver);
			BasePage.OpenPage(ConfigReader.BoletinesDePrensa);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(boletinesDePrensa.IsPaginationDisplayed(), "Pagination is not visible");
		}

		[Test]
		public void Test_64_IsSearchFieldWorkAsExpected()
		{
			BoletinesDePrensa boletinesDePrensa = new BoletinesDePrensa(Driver);
			BasePage.OpenPage(ConfigReader.BoletinesDePrensa);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(boletinesDePrensa.IsSearchFieldWorkAsExpected("cdp"), "Search field does not wokr");
		}

		[Test]
		public void Test_VerificationOfPageTitle()
		{
			BoletinesDePrensa boletinesDePrensa = new BoletinesDePrensa(Driver);
			BasePage.OpenPage(ConfigReader.BoletinesDePrensa);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.AreEqual(BasePage.GetTitle(), "Global Press releases | Essity", "Titles are not the same");
		}

	}
}
