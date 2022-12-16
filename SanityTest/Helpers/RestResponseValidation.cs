using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SanityTest.Helpers
{
	public static class RestResponseValidation
	{
		public  static async Task<bool> GetStatusCode(string url)
		{
			RestClient restClient = new RestClient();
			RestRequest restRequest = new RestRequest(url, Method.Get);
			RestResponse restResponse = await restClient.ExecuteAsync(restRequest);
			int responseCode = (int)restResponse.get_StatusCode();

			return responseCode == 200;
		}
		//public  static async Task<bool> GetStatusCode(string url)
		//{
		//	HttpClient restClient = new HttpClient();
		//	HttpRequestMessage restRequest = new HttpRequestMessage(HttpMethod.Get, url);
		//	HttpResponseMessage restResponse = await restClient.SendAsync(restRequest);
		//	int responseCode = (int)restResponse.StatusCode;

		//	return responseCode == 200;
		//}
		
	}
}
