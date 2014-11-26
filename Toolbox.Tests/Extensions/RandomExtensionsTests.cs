using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Extensions;

namespace Toolbox.Tests.Extensions
{
	[TestClass]
	public class RandomExtensionsTests
	{
		#region Setup
		public Random random { get; set; }
		public int iterations { get; set; }

		[TestInitialize]
		public void Initialize()
		{
			random = new Random();
			iterations = 1000000;
		}

		[TestCleanup]
		public void Cleanup()
		{
			random = null;
		} 
		#endregion

		#region Tests
		[TestMethod]
		public void Random_NextLong()
		{
			int i = 0;
			long value = 0;

			while (i < iterations)
			{
				long randomValue = random.NextLong();

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= 0));
					Assert.IsTrue((value <= long.MaxValue));
				}	
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextLong_With_Max_Value()
		{
			int i = 0;			
			long value = 0;

			while (i < iterations)
			{
				long maxValue = GetLongRandomMaxValue();
				long randomValue = random.NextLong(maxValue);
				
				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= 0));
					Assert.IsTrue((value <= maxValue));
				}
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextLong_With_Min_And_Max_Value()
		{
			int i = 0;
			long value = 0;

			while (i < iterations)
			{
				long minValue = GetLongMinValue();
				long maxValue = GetLongRandomMaxValue();
				long randomValue = random.NextLong(minValue, maxValue);

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= minValue));
					Assert.IsTrue((value <= maxValue));
				}
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextUInt()
		{
			int i = 0;
			uint value = 0;

			while (i < iterations)
			{
				uint randomValue = random.NextUInt();

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= 0));
					Assert.IsTrue((value <= uint.MaxValue));
				}
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextUInt_With_Max_Value()
		{
			int i = 0;
			uint value = 0;

			while (i < iterations)
			{
				uint maxValue = GetUIntRandomMaxValue();
				uint randomValue = random.NextUInt(maxValue);

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= 0));
					Assert.IsTrue((value <= maxValue));
				}
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextUInt_With_Min_And_Max_Value()
		{
			int i = 0;
			uint value = 0;

			while (i < iterations)
			{
				uint minValue = GetUIntMinValue();
				uint maxValue = GetUIntRandomMaxValue();
				uint randomValue = random.NextUInt(minValue, maxValue);

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= minValue));
					Assert.IsTrue((value <= maxValue));
				}
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextULong()
		{
			int i = 0;
			ulong value = 0;

			while (i < iterations)
			{
				ulong randomValue = random.NextULong();

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= 0));
					Assert.IsTrue((value <= ulong.MaxValue));
				}
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextULong_With_Max_Value()
		{
			int i = 0;
			ulong value = 0;

			while (i < iterations)
			{
				ulong maxValue = GetULongRandomMaxValue();
				ulong randomValue = random.NextULong(maxValue);

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= 0));
					Assert.IsTrue((value <= maxValue));
				}
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Random_NextULong_With_Min_And_Max_Value()
		{
			int i = 0;
			ulong value = 0;

			while (i < iterations)
			{
				ulong minValue = GetULongMinValue();
				ulong maxValue = GetULongRandomMaxValue();
				ulong randomValue = random.NextULong(minValue, maxValue);

				if (value != randomValue)
				{
					value = randomValue;
					i++;

					Assert.IsTrue((value >= minValue));
					Assert.IsTrue((value <= maxValue));
				}
			}
		}
		#endregion

		#region Private Methods
		private long GetLongMinValue()
		{
			return ((long)int.MaxValue + 1);
		}

		// ---------------------------------------------------------------------------------------------------- //

		private long GetLongRandomMaxValue()
		{
			long min = GetLongMinValue();
			long max = long.MaxValue;

			int divider = random.Next(2, 8);
			long value = min + ((max - min) / divider);
			
			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		private uint GetUIntMinValue()
		{
			return (ushort.MaxValue + 1);
		}

		// ---------------------------------------------------------------------------------------------------- //

		private uint GetUIntRandomMaxValue()
		{
			uint min = GetUIntMinValue();
			uint max = uint.MaxValue;

			uint divider = (uint)random.Next(2, 8);
			uint value = min + ((max - min) / divider);

			return value;
		}

		// ---------------------------------------------------------------------------------------------------- //

		private ulong GetULongMinValue()
		{
			return ((ulong)uint.MaxValue + 1);
		}

		// ---------------------------------------------------------------------------------------------------- //

		private ulong GetULongRandomMaxValue()
		{
			ulong min = GetULongMinValue();
			ulong max = ulong.MaxValue;

			uint divider = (uint)random.Next(2, 8);
			ulong value = min + ((max - min) / divider);

			return value;
		}
		#endregion
	}
}