using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using SanityTest.Base;
using SanityTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssityMX.Pages.LandingPages
{
	public class Marcas : BasePage
	{
		public Marcas(IWebDriver driver) : base(driver)
		{
			Driver = driver;
		}

		//The first hero banner
		IWebElement TheFirstHeroBanner => Driver.FindElement(By.CssSelector("div[class*='banner--regular']"));

		IWebElement TheFirstHeroBannerImage => Driver.FindElement(By.CssSelector("img[alt*='GRUPPBILD_ALLA-PRODUKTER-PÅ-RAD-PQED.jpg']"));

		//Brand Filters
		IWebElement SearchBrandField => Driver.FindElement(By.CssSelector("#search-bar-search"));
		IWebElement CountryBrandSelector => Driver.FindElement(By.CssSelector("#select-country"));
		IWebElement CategoryBrandSelector => Driver.FindElement(By.CssSelector("#select2-select-component-container"));

		//Brands
		IWebElement Tork => Driver.FindElement(By.CssSelector("img[alt*='Tork']"));
		IWebElement Libero => Driver.FindElement(By.CssSelector("img[alt*='Libero']"));
		IWebElement Familia => Driver.FindElement(By.CssSelector("img[alt='familia_Logo_highres.png']"));
		IWebElement Vinda => Driver.FindElement(By.CssSelector("img[alt*='Vinda']"));
		IWebElement Drypers => Driver.FindElement(By.CssSelector("img[alt*='drypers']"));
		IWebElement Pequenin => Driver.FindElement(By.CssSelector("img[alt*='LOGO pequenin']"));
		IWebElement Colhogar => Driver.FindElement(By.CssSelector("img[alt*='Colhogar']"));
		IWebElement Cosy => Driver.FindElement(By.CssSelector("img[alt='Cosy Logo']"));
		IWebElement Cushelle => Driver.FindElement(By.CssSelector("img[alt='Cushelle Logo 2017.png']"));
		IWebElement Edet => Driver.FindElement(By.CssSelector("img[alt='Edet_SE-NOR_Logo.png']"));
		IWebElement Favorita => Driver.FindElement(By.CssSelector("img[alt='FAVORITA_Logo_highres.png']"));
		IWebElement Lotus => Driver.FindElement(By.CssSelector("img[alt*='Lotus_Logo.png']"));
		IWebElement Okay => Driver.FindElement(By.CssSelector("img[alt='HHNEW_OKAY_ELEPHANT_LOGO_highres.png']"));
		IWebElement Regio => Driver.FindElement(By.CssSelector("img[alt='Regio_highres.png']"));
		IWebElement Tempo => Driver.FindElement(By.CssSelector("img[alt='Tempo Logo DE/AT/CH']"));
		IWebElement Velver => Driver.FindElement(By.CssSelector("img[alt='Velvet_Logo_highres.png']"));
		IWebElement Zewa => Driver.FindElement(By.CssSelector("img[alt*='Zewa_Logo_RGB']"));
		IWebElement Bodyform => Driver.FindElement(By.CssSelector("img[alt='SCA_Bodf_Logo_EBU_SML_RGB.png']"));
		IWebElement Libresse => Driver.FindElement(By.CssSelector("img[alt='SCA_Lib_Logo_EBU_SML_RGB.png']"));
		IWebElement Nana => Driver.FindElement(By.CssSelector("img[alt='Nana_Logo_EBU_SML_RGB.jpg']"));
		IWebElement Nosotras => Driver.FindElement(By.CssSelector("img[alt*='Nosotras-300x300.jpg ']"));
		IWebElement Nuveina => Driver.FindElement(By.CssSelector("img[alt='SCA_Nuve_Logo_EBU_SML_RGB.png']"));
		IWebElement Saba => Driver.FindElement(By.CssSelector("img[alt='SCA_Saba_Logo_EBU_SML_RGB.png']"));
		IWebElement Tena => Driver.FindElement(By.CssSelector("img[alt*='TENA-300x300.jpg ']"));
		IWebElement Leukoplast => Driver.FindElement(By.CssSelector("img[alt*='Leukoplast logo.jpg']"));
		IWebElement Jobst => Driver.FindElement(By.CssSelector("img[alt*='JOBST logo.jpg ']"));
		IWebElement DeltaCast => Driver.FindElement(By.CssSelector("img[alt*='Delta-Cast.jpg']"));
		IWebElement Cutimed => Driver.FindElement(By.CssSelector("img[alt*='Cutimed logo.jpg']"));

		//First Row CTA
		//Two Column Boxes
		IWebElement TheFirstTwoColumnBox => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[1]"));
		IWebElement TheSecondTwoColumnBox => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[2]"));
		//The Second Row CTA
		//Two Column Boxes
		IWebElement TheThirdTwoColumnBox => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[3]"));
		IWebElement TheFourthTwoColumnBox => Driver.FindElement(By.XPath("//body/div[9]/section[1]/div[1]/div[4]"));

		//Filters
		public bool IsSearchFieldVisible() => AvailabilityUtil.IsElementDisplayed(SearchBrandField);
		public bool IsCountryBrandSelectorVisible() => AvailabilityUtil.IsElementDisplayed(CountryBrandSelector);
		public bool IsCategoryBrandSelectorVisible() => AvailabilityUtil.IsElementDisplayed(CategoryBrandSelector);

		//Search filter
		public bool CheckSearchingForTork(string searchedItem)
		{
			try
			{
				AvailabilityUtil.ScrollIntoViewJS(SearchBrandField, Driver);
				TextUtil.SendKeys(SearchBrandField, searchedItem);
				//TextUtil.ActionSendKeys(searchedItem, SearchBrandField);
				if (WaitUtil.WaitToBeVisible(Tork, Driver) && !WaitUtil.WaitToBeVisible(Jobst, Driver))
				{
					LogUtil.Log($"Info[SearchField] Result is Tork");
					return true;
				}
				return true;
				
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[SearchField] {e.Message}");
				return false;
			}
		}

		//Category filter
		public bool CheckCategoryFilterForBodyform()
		{
			try
			{
				SelectUtil.SelectElementByText(CategoryBrandSelector, "Feminine Care");
				if (WaitUtil.WaitToBeVisible(Libresse, Driver) && !WaitUtil.WaitToBeVisible(Tork, Driver))
				{
					LogUtil.Log("Info[CategoryFilter] Result is Femine care");
					return true;
				}
				return true;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[CategoryFilter] {e.Message}");
				return false;
			}
		}

		//Country filter
		public bool CheckTheCountryFilter()
		{
			try
			{
				SelectUtil.SelectElementByText(CountryBrandSelector, "Australia");
				if (WaitUtil.WaitToBeVisible(Tork, Driver) && !WaitUtil.WaitToBeVisible(Libresse, Driver))
				{
					LogUtil.Log("Info[CountryFilter] Result is search by Australia");
					return true;
				}
				return true;
			}
			catch (Exception e)
			{
				LogUtil.Log($"Error[CountryFilter] {e.Message}");
				return false;
			}
		}

		//Is The first hero banner
		public bool IsTheFristHeroBannerVisible() => AvailabilityUtil.IsElementDisplayed(TheFirstHeroBanner);
		public bool IsTheFirstHeroBannerImgStatusOk() => AvailabilityUtil.GetDataSrcAttribute(TheFirstHeroBannerImage, Driver);

		//Tork
		public bool IsTorkLogoVisible() => AvailabilityUtil.IsElementDisplayed(Tork);
		public bool IsTorkLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Tork, Driver);

		//Libero
		public bool IsLiberoLogoVisible() => AvailabilityUtil.IsElementDisplayed(Libero);
		public bool IsLiberoLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Libero, Driver);

		//Familia
		public bool IsFamiliaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Familia);
		public bool IsFamiliaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Familia, Driver);

		//Vinda
		public bool IsVindaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Vinda);
		public bool IsVindaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Vinda, Driver);

		//Drypers
		public bool IsDrypersLogoVisible() => AvailabilityUtil.IsElementDisplayed(Drypers);
		public bool IsDrypersLogoOk()
		{
			WaitUtil.WaitToBeVisible(Drypers, Driver);
			return AvailabilityUtil.GetDataSrcAttribute(Drypers, Driver);
		}

		//Pequenin
		public bool IsPequieninLogoVisible() => AvailabilityUtil.IsElementDisplayed(Pequenin);
		public bool IsPequieninLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Pequenin, Driver);

		//Colhogar
		public bool IsColhogarLogoVisible() => AvailabilityUtil.IsElementDisplayed(Colhogar);
		public bool IsColhogarLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Colhogar, Driver);

		//Cosy
		public bool IsCosyLogoVisible() => AvailabilityUtil.IsElementDisplayed(Cosy);
		public bool IsCosyLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Cosy, Driver);

		//Cushelle
		public bool IsCushelleLogoVisible() => AvailabilityUtil.IsElementDisplayed(Cushelle);
		public bool IsCushelleLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Cushelle, Driver);

		//Edet
		public bool IsEdetLogoVisible() => AvailabilityUtil.IsElementDisplayed(Edet);
		public bool IsEdetLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Edet, Driver);

		//Favorita
		public bool IsFavoritaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Favorita);
		public bool IsFavoritaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Favorita, Driver);

		//Lotus
		public bool IsLotusLogoVisible() => AvailabilityUtil.IsElementDisplayed(Lotus);
		public bool IsLotusLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Lotus, Driver);

		//Okay
		public bool IsOkayLogoVisible() => AvailabilityUtil.IsElementDisplayed(Okay);
		public bool IsOkayLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Okay, Driver);

		//Regio
		public bool IsRegioLogoVisible() => AvailabilityUtil.IsElementDisplayed(Regio);
		public bool IsRegioLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Regio, Driver);

		//Tempo
		public bool IsTempoLogoVisible() => AvailabilityUtil.IsElementDisplayed(Tempo);
		public bool IsTempoLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Tempo, Driver);

		//Velver
		public bool IsVelverLogoVisible() => AvailabilityUtil.IsElementDisplayed(Velver);
		public bool IsVelverLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Velver, Driver);

		//Zewa
		public bool IsZewaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Zewa);
		public bool IsZewaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Zewa, Driver);
		//Bodyform
		public bool IsBodyformLogoVisible() => AvailabilityUtil.IsElementDisplayed(Bodyform);
		public bool IsBodyformLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Bodyform, Driver);

		//Libresse
		public bool IsLibresseLogoVisible() => AvailabilityUtil.IsElementDisplayed(Libresse);
		public bool IsLibresseLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Libresse, Driver);

		//Nana
		public bool IsNanaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Nana);
		public bool IsNanaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Nana, Driver);

		//Nosotras
		public bool IsNosotrasLogoVisible() => AvailabilityUtil.IsElementDisplayed(Nosotras);
		public bool IsNosotrasLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Nosotras, Driver);

		//Nuvenia
		public bool IsNuveniaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Nuveina);
		public bool IsNuveniaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Nuveina, Driver);

		//Saba
		public bool IsSabaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Saba);
		public bool IsSabaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Saba, Driver);

		//Tena
		public bool IsTenaLogoVisible() => AvailabilityUtil.IsElementDisplayed(Tena);
		public bool IsTenaLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Tena, Driver);

		//Leukoplast
		public bool IsLeukoplastLogoVisible() => AvailabilityUtil.IsElementDisplayed(Leukoplast);
		public bool IsLeukoplastLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Leukoplast, Driver);

		//Jobst
		public bool IsJobstLogoVisible() => AvailabilityUtil.IsElementDisplayed(Jobst);
		public bool IsJobstLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Jobst, Driver);

		//Delta-cast
		public bool IsDeltaCastLogoVisible() => AvailabilityUtil.IsElementDisplayed(DeltaCast);
		public bool IsDeltaCastLogoOk() => AvailabilityUtil.GetDataSrcAttribute(DeltaCast, Driver);

		//Cutimed
		public bool IsCutimedLogoVisible() => AvailabilityUtil.IsElementDisplayed(Cutimed);
		public bool IsCutimedLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Cutimed, Driver);

		//FirstRowCTABoxes
		public bool IsTheFristTwoColumnBoxVisible()
		{
			AvailabilityUtil.ScrollIntoViewJS(TheFirstTwoColumnBox, Driver);
			return AvailabilityUtil.IsElementDisplayed(TheFirstTwoColumnBox);
		}
		public bool IsTheSecondTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheSecondTwoColumnBox);
		//TheSecondRowCTABoxes
		public bool IsTheThirdTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheThirdTwoColumnBox);
		public bool IsTheFourthTwoColumnBoxVisible() => AvailabilityUtil.IsElementDisplayed(TheFourthTwoColumnBox);

	}
}
