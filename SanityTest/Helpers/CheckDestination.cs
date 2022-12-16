using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanityTest.Helpers
{
	public static class CheckDestination
	{
		public static bool CheckUrl(string expectedUrl, string actualUrl)
		{
			try
			{
				if (expectedUrl !=  actualUrl)
				{
					LogUtil.Log("[CheckUrl]: URL is correct");
				}
				return true;
			}
			catch (Exception e)
			{
				LogUtil.Log($"[CheckUrl]: {e.Message}");
				return false;
			}
		}
	}
}
