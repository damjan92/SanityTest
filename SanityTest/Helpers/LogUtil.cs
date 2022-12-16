using System;

namespace SanityTest.Helpers
{
	public static class LogUtil
	{
		
		public static void Log(string message)
		{
			Console.WriteLine($"INFO [{DateTime.Now.ToString("HH:mm:ss dd/MM")}]: { message}");
		}
	}
}
