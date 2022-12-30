using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SanityTest.ConfigFiles
{
	public static class ConfigReader
	{
		//public static string Url { get { return ConfigurationManager.AppSettings["url_home"]; } }

		//new way of setting the get values
		public static string HomepageUrl => ConfigurationManager.AppSettings["homepage"];
		public static string CompanyLandingPageUrl => ConfigurationManager.AppSettings["companyPage"];
		public static string MarcasLandingPage => ConfigurationManager.AppSettings["marcasPage"];
		public static string SustentabilidadLandingPage => ConfigurationManager.AppSettings["sustentabilidad"];
		public static string CarrerasLandingPage => ConfigurationManager.AppSettings["carreras"];
		public static string InnovacionLandingPage => ConfigurationManager.AppSettings["innovacion"];
		public static string MediosDeCommunicacionLandingPage => ConfigurationManager.AppSettings["medios"];
		public static string BoletinesDePrensa => ConfigurationManager.AppSettings["press"];
	}

}
