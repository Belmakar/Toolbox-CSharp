using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Extensions
{
	public static class RandomExtensions
	{
		#region Public Static Methods
		public static long NextLong(this Random random)
		{
			byte[] buffer = new byte[8];
			random.NextBytes(buffer);

			long value = BitConverter.ToInt64(buffer, 0);
			value = Math.Abs(value);

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static long NextLong(this Random random, long maxValue)
		{
			long value = NextLong(random, 0, maxValue);

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static long NextLong(this Random random, long minValue, long maxValue)
		{
			long value = NextLong(random);
			value = Math.Abs(value % (maxValue - minValue)) + minValue;

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static uint NextUInt(this Random random)
		{
			byte[] buffer = new byte[4];
			random.NextBytes(buffer);

			uint value = BitConverter.ToUInt32(buffer, 0);

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static uint NextUInt(this Random random, uint maxValue)
		{
			uint value = NextUInt(random, 0, maxValue);

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static uint NextUInt(this Random random, uint minValue, uint maxValue)
		{
			uint value = NextUInt(random);
			value = (value % (maxValue - minValue)) + minValue;

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static ulong NextULong(this Random random)
		{
			byte[] buffer = new byte[8];
			random.NextBytes(buffer);

			ulong value = BitConverter.ToUInt64(buffer, 0);

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static ulong NextULong(this Random random, ulong maxValue)
		{
			ulong value = NextULong(random, 0, maxValue);

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static ulong NextULong(this Random random, ulong minValue, ulong maxValue)
		{
			ulong value = NextULong(random);
			value = (value % (maxValue - minValue)) + minValue;

			return value;
		}
		#endregion
	}
}