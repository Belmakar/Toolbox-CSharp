using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Extensions;

namespace Toolbox.Tests.Extensions
{
	[TestClass]
	public class DateExtensionsTests
	{
		#region Tests
		[TestMethod]
		public void Date_GetUnixTimestamp_1970()
		{
			DateTime date = new DateTime(1970, 1, 1, 0, 0, 0);
			int timestamp = date.GetUnixTimestamp();

			Assert.AreEqual(0, timestamp);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Date_GetUnixTimestamp_After_1970()
		{
			DateTime date = new DateTime(1990, 1, 2, 3, 4, 5);
			int timestamp = date.GetUnixTimestamp();

			Assert.AreEqual(631249445, timestamp);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Date_GetUnixTimestamp_Before_1970()
		{
			DateTime date = new DateTime(1950, 12, 11, 10, 9, 8);
			int timestamp = date.GetUnixTimestamp();

			Assert.AreEqual(-601393852, timestamp);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Date_GetUnixTimestamp_Now()
		{
			DateTime now = DateTime.Now;
			int timestamp = now.GetUnixTimestamp();

			DateTime unix = new DateTime(1970, 1, 1, 0, 0, 0);
			double seconds1 = new TimeSpan(unix.Ticks).TotalSeconds;
			double seconds2 = new TimeSpan(now.Ticks).TotalSeconds;
			int expected = (int)(seconds2 - seconds1);

			Assert.AreEqual(expected, timestamp);
		}
		#endregion
	}
}