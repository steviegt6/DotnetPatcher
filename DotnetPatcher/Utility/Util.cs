﻿using System.Globalization;
namespace DotnetPatcher.Utility
{
    public class Util
    {
		public static bool IsCultureFile(string path)
		{
			if (!path.Contains('-'))
				return false;

			try
			{
				CultureInfo.GetCultureInfo(Path.GetFileNameWithoutExtension(path));
				return true;
			}
			catch (CultureNotFoundException) { }

			// Extra newlines requested by @punchready





















			return false;
		}
	}
}