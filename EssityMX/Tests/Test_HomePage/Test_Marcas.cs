using SanityTest.Base;
using NUnit.Framework;
using EssityMX.Pages.HomePage;
using SanityTest.ConfigFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EssityMX.Pages.LandingPages;

namespace EssityMX.Tests.Test_HomePage
{
	public class Test_Marcas : BaseTest
	{
		[Test]
		public void Test_20_AreFiltersVisible()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(marcas.IsSearchFieldVisible(), "Search field is not visible");
				Assert.IsTrue(marcas.IsCategoryBrandSelectorVisible(), "Category field is not visible");
				Assert.IsTrue(marcas.IsCountryBrandSelectorVisible(), "Contry field is not visible");
			});
		}

		[Test]
		public void Test_21_IsTheFristHeroBannerVisible()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(marcas.IsTheFirstHeroBannerImgStatusOk(), "Hero banner image is not status 200");
				Assert.IsTrue(marcas.IsTheFristHeroBannerVisible(), "The first hero banner is not visible");
			});
		}

		[Test]
		public void Test_22_CheckSearchingForTork()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(marcas.CheckSearchingForTork("Tork"), "The Tork is not result");
		}

		[Test]
		public void Test_23_ChechTheCountryFilter()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(marcas.CheckTheCountryFilter(), "The Austraila is not result");
		}

		[Test]
		public void Test_24_CheckCategoryFilterForBodyform()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.IsTrue(marcas.CheckCategoryFilterForBodyform(), "The Femine Care is not result");
		}

		[Test]
		public void Test_25_AreIconsVisible()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(marcas.IsTorkLogoVisible(), "Tork icon is not visible");
				Assert.IsTrue(marcas.IsLiberoLogoVisible(), "Libre icon is not visible");
				Assert.IsTrue(marcas.IsFamiliaLogoVisible(), "Familia icon is not visible");
				Assert.IsTrue(marcas.IsVindaLogoVisible(), "Vinda icon is not status ok");
				Assert.IsTrue(marcas.IsDrypersLogoVisible(), "Drypers icon is not visible");
				Assert.IsTrue(marcas.IsPequieninLogoVisible(), "Pequienin icon is not visible");
				Assert.IsTrue(marcas.IsColhogarLogoVisible(), "Colhogar icon is not visible");
				Assert.IsTrue(marcas.IsCosyLogoVisible(), "Cosy icon is not visible");
				Assert.IsTrue(marcas.IsCushelleLogoVisible(), "Cushelle icon is not visible");
				Assert.IsTrue(marcas.IsEdetLogoVisible(), "Edet icon is not visible");
				Assert.IsTrue(marcas.IsFavoritaLogoVisible(), "Favorita is not visible");
				Assert.IsTrue(marcas.IsLotusLogoVisible(), "Lotus icon is not visible");
				Assert.IsTrue(marcas.IsOkayLogoVisible(), "Okay icon is not visible");
				Assert.IsTrue(marcas.IsRegioLogoVisible(), "Regio icon is not visible");
				Assert.IsTrue(marcas.IsTempoLogoVisible(), "Tempo icon is not visible");
				Assert.IsTrue(marcas.IsVelverLogoVisible(), "Velvet icon is not visible");
				Assert.IsTrue(marcas.IsZewaLogoVisible(), "Zewa icon is not visible");
				Assert.IsTrue(marcas.IsBodyformLogoVisible(), "Bodyform icon is not visible");
				Assert.IsTrue(marcas.IsLibresseLogoVisible(), "Libresse icon is not visible");
				Assert.IsTrue(marcas.IsNanaLogoVisible(), "Nana icon is not visible");
				Assert.IsTrue(marcas.IsNosotrasLogoVisible(), "Nosotras icon is not visible");
				Assert.IsTrue(marcas.IsNuveniaLogoVisible(), "Nuvenia logo is not visible");
				Assert.IsTrue(marcas.IsSabaLogoVisible(), "Saba logo is not visible");
				Assert.IsTrue(marcas.IsTenaLogoVisible(), "Tena logo is not visible");
				Assert.IsTrue(marcas.IsLeukoplastLogoVisible(), "Leukoplast logo is not visible");
				Assert.IsTrue(marcas.IsJobstLogoVisible(), "Jobs logo is not visible");
				Assert.IsTrue(marcas.IsDeltaCastLogoVisible(), "Delta-cast logo is not visible");
				Assert.IsTrue(marcas.IsCutimedLogoVisible(), "Cutimed logo is not visible");
			});
		}

		[Test]
		public void Test_26_AreIconsStatusOK()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(marcas.IsTorkLogoOk(), "Tork logo is not Status 200");
				Assert.IsTrue(marcas.IsLiberoLogoOk(), "Libero loko is not status 200");
				Assert.IsTrue(marcas.IsFamiliaLogoOk());
				Assert.IsTrue(marcas.IsVindaLogoOk(), "Vinda logo is not Status 200");
				Assert.IsTrue(marcas.IsDrypersLogoOk(), "Drypers logo is not Status 200");
				Assert.IsTrue(marcas.IsPequieninLogoOk(), "Pequienin logo is not Status 200");
				Assert.IsTrue(marcas.IsColhogarLogoOk(), "Colhogar logo is not Status 200");
				Assert.IsTrue(marcas.IsCosyLogoOk(), "Cosy logo is not Status 200");
				Assert.IsTrue(marcas.IsCushelleLogoOk(), "Cushelle logo is not Status 200");
				Assert.IsTrue(marcas.IsEdetLogoOk(), "Edet logo is not Status 200");
				Assert.IsTrue(marcas.IsFavoritaLogoOk(), "Favorita logo is not Status 200");
				Assert.IsTrue(marcas.IsLotusLogoOk(), "Lotus logo is not Status 200");
				Assert.IsTrue(marcas.IsOkayLogoOk(), "Okay logo is not Status 200");
				Assert.IsTrue(marcas.IsRegioLogoOk(), "Regio logo is not Status 200");
				Assert.IsTrue(marcas.IsTempoLogoOk(), "Tempo logo is not Status 200");
				Assert.IsTrue(marcas.IsVelverLogoOk(), "Velvet logo is not Status 200");
				Assert.IsTrue(marcas.IsZewaLogoOk(), "Zewa logo is not Status 200");
				Assert.IsTrue(marcas.IsBodyformLogoOk(), "Bodyform logo is not Status 200");
				Assert.IsTrue(marcas.IsLibresseLogoOk(), "Libresse logo is not Status 200");
				Assert.IsTrue(marcas.IsNanaLogoOk(), "Nana logo is not Status 200");
				Assert.IsTrue(marcas.IsNosotrasLogoOk(), "Nosotras logo is not Status 200");
				Assert.IsTrue(marcas.IsNuveniaLogoOk(), "Nuvenia logo is not Status 200");
				Assert.IsTrue(marcas.IsSabaLogoOk(), "Saba logo is not Status 200");
				Assert.IsTrue(marcas.IsTempoLogoOk(), "Tena logo is not Status 200");
				Assert.IsTrue(marcas.IsLeukoplastLogoOk(), "Leukoplast logo is not Status 200");
				Assert.IsTrue(marcas.IsJobstLogoOk(), "Jobs logo is not Status 200");
				Assert.IsTrue(marcas.IsDeltaCastLogoOk(), "logo is not Status 200");
				Assert.IsTrue(marcas.IsCutimedLogoOk(), "logo is not Status 200");
			});
		}

		[Test]
		public void Test_27_IsTheTwoColumnBoxesAreVisible()
		{
			Marcas marcas = new Marcas(Driver);
			BasePage.OpenPage(ConfigReader.MarcasLandingPage);
			AcceptCoockies.ClickOnAcceptCoockies();
			Assert.Multiple(() =>
			{
				Assert.IsTrue(marcas.IsTheFristTwoColumnBoxVisible(), "The first column box is visible");
				Assert.IsTrue(marcas.IsTheSecondTwoColumnBoxVisible(), "The second column box is visible");
				Assert.IsTrue(marcas.IsTheThirdTwoColumnBoxVisible(), "The third column box is visible");
				Assert.IsTrue(marcas.IsTheFourthTwoColumnBoxVisible(), "The fourth columnd box is visible");
			});
		}
	}
}
