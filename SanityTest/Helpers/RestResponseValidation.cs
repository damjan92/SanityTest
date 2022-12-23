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
		public  static async Task<bool> GetStatusCode(string getUrl)
		{
			try
			{
				RestClient restClient = new RestClient();
				RestRequest restRequest = new RestRequest(getUrl, Method.Get);
				RestResponse restResponse = await restClient.ExecuteAsync(restRequest);
				int responseCode = (int)restResponse.StatusCode;
				if (responseCode == 200)
				{
					LogUtil.Log("Info[Rest]: Response is 200");
					return true;
				}
				else
				{
					LogUtil.Log("Error[Rest]: Response is not 200");
					return false;
				}
			}
			catch(Exception e)
			{
				LogUtil.Log($"Error[RestReposnse]{e.Message}");
				return false;
			}
				
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
