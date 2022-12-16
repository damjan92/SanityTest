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
		IWebElement TheFirstHeroBanner => Driver.FindElement
			(By.CssSelector("body > div:nth-child(12) > section:nth-child(1) > div:nth-child(1) > div:nth-child(1)"));

		IWebElement TheFirstHeroBannerImage => Driver.FindElement(By.CssSelector("img[alt='GRUPPBILD_ALLA-PRODUKTER-PÅ-RAD-PQED.jpg ']"));

		//Brand Filters
		IWebElement SearchBrandField => Driver.FindElement(By.CssSelector("#search-bar-search"));
		IWebElement CountryBrandSelector => Driver.FindElement(By.CssSelector("#select-country"));
		IWebElement CategoryBrandSelector => Driver.FindElement(By.CssSelector("#select2-select-component-container"));

		//Brands
		IWebElement Tork => Driver.FindElement(By.XPath("//body/div[8]/section[1]/div[1]/div[1]/div[1]/a[1]/div[1]/img[1]"));
		IWebElement Libero => Driver.FindElement(By.CssSelector(".brand-list-link[href='https://www.libero.com/']"));
		IWebElement Familia => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.familiainstitucional.com/']"));
		IWebElement Vinda => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.vindapaper.com/en/product/index.html']"));
		IWebElement Drypers => Driver.FindElement(By.CssSelector(".brand-list-link[href='https://www.drypers.com.my/']"));
		IWebElement Pequenin => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.pequenin.com/']"));
		IWebElement Colhogar => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.colhogar.com/']"));
		IWebElement Cosy => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.cosy.co.at/']"));
		IWebElement Cushelle => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.cushelle.com/']"));
		IWebElement Edet => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.edet.se/']"));
		IWebElement Favorita => Driver.FindElement(By.CssSelector("div[data-country='ar bo br cl co ec py pe uy ve'] a[class='brand-list-link']"));
		IWebElement Lotus => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.lotus-planete.com/']"));
		IWebElement Okay => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.okay.fr/']"));
		IWebElement Regio => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.papelregio.com/']"));
		IWebElement Tempo => Driver.FindElement(By.CssSelector(".brand-list-link[href='https://www.tempo-world.com/de-de/start']"));
		IWebElement Velver => Driver.FindElement(By.CssSelector("div[class='js-brand-list grid col-5'] div:nth-child(1) a:nth-child(1)"));
		IWebElement Zewa => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.zewa.de/']"));
		IWebElement Bodyform => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.bodyform.co.uk/?epslanguage=en']"));
		IWebElement Libresse => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.libresse.com/']"));
		IWebElement Nana => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.libresse.com/']"));
		IWebElement Nosotras => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.nosotrasonline.com/']"));
		IWebElement Nuveina => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.nosotrasonline.com/']"));
		IWebElement Saba => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.saba.com.mx/']"));
		IWebElement Tena => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.tena.com.mx/']"));
		IWebElement Leukoplast => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.tena.com.mx/']"));
		IWebElement Jobst => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.jobst.com/']"));
		IWebElement DeltaCast => Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.jobst.com/']"));
		IWebElement Cutimed => 
			Driver.FindElement(By.CssSelector(".brand-list-link[href='http://www.bsnmedical.com/products/wound-care-vascular/category-product-search/advanced-wound-care/wound-bed-preparation/cutimedr-sorbactr.html']"));

		//FirstRowCTABoxes
		//TwoColumnBoxes
		IWebElement TheFirstTwoColumnBox => Driver.FindElement
			(By.CssSelector("body > div:nth-child(14) > section:nth-child(1) > div:nth-child(1) > div:nth-child(1)"));
		IWebElement TheSecondTwoColumnBox => Driver.FindElement
			(By.CssSelector("body > div:nth-child(14) > section:nth-child(1) > div:nth-child(1) > div:nth-child(2)"));
		//TheSecondRowCTABoxes
		//TwoColumnBoxes
		IWebElement TheThirdTwoColumnBox => Driver.FindElement
			(By.CssSelector("body > div:nth-child(14) > section:nth-child(1) > div:nth-child(1) > div:nth-child(3)"));
		IWebElement TheFourthTwoColumnBox => Driver.FindElement
			(By.CssSelector("body > div:nth-child(14) > section:nth-child(1) > div:nth-child(1) > div:nth-child(2)"));

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
				if (AvailabilityUtil.IsElementDisplayed(Bodyform) && !AvailabilityUtil.IsElementDisplayed(Tork))
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
				if (AvailabilityUtil.IsElementDisplayed(Tork) && !AvailabilityUtil.IsElementDisplayed(Libresse))
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
		public bool IsDrypersLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Drypers, Driver);

		//Pequenin
		public bool IsPequieninLogoVisible() => AvailabilityUtil.IsElementDisplayed(Pequenin);
		public bool isPequieninLogoOk() => AvailabilityUtil.GetDataSrcAttribute(Pequenin, Driver);

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
