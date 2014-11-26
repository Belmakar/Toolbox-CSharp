using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Toolbox.Extensions
{
	public static class StringExtensions
	{
		#region Public Static Methods
		public static bool IsNullOrEmpty(this string value)
		{
			return (value == null || value.Trim().Length == 0) ? true : false;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static bool IsLowerCase(this string value)
		{
			return Regex.IsMatch(value, @"^[a-z]+$");
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static bool IsUpperCase(this string value)
		{
			return Regex.IsMatch(value, @"^[A-Z]+$");
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static string[] ToArray(this string value, string separator = ",")
		{
			char[] chars = separator.ToCharArray();
			string[] arr = value.Split(chars);

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static bool ToBoolean(this string value)
		{
			bool result;

			switch (value.ToLower())
			{
				case "0":
				case "no":
					result = false;
					break;

				case "1":
				case "yes":
					result = true;
					break;

				default:
					result = Convert.ToBoolean(value);
					break;
			}

			return result;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static short[] ToInt16Array(this string value, string separator = ",")
		{
			char[] chars = separator.ToCharArray();
			string[] values = value.Split(chars);
			short[] arr = Array.ConvertAll(values, short.Parse);

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static int[] ToInt32Array(this string value, string separator = ",")
		{
			char[] chars = separator.ToCharArray();
			string[] values = value.Split(chars);
			int[] arr = Array.ConvertAll(values, int.Parse);

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static long[] ToInt64Array(this string value, string separator = ",")
		{
			char[] chars = separator.ToCharArray();
			string[] values = value.Split(chars);
			long[] arr = Array.ConvertAll(values, long.Parse);

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static ushort[] ToUInt16Array(this string value, string separator = ",")
		{
			char[] chars = separator.ToCharArray();
			string[] values = value.Split(chars);
			ushort[] arr = Array.ConvertAll(values, ushort.Parse);

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static uint[] ToUInt32Array(this string value, string separator = ",")
		{
			char[] chars = separator.ToCharArray();
			string[] values = value.Split(chars);
			uint[] arr = Array.ConvertAll(values, uint.Parse);

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static ulong[] ToUInt64Array(this string value, string separator = ",")
		{
			char[] chars = separator.ToCharArray();
			string[] values = value.Split(chars);
			ulong[] arr = Array.ConvertAll(values, ulong.Parse);

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static string TrimToNull(this string value)
		{
			return (value == null || value.Trim().Length == 0) ? null : value.Trim();
		}
		#endregion
	}
}