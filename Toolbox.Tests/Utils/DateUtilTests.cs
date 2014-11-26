using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Utils;

namespace Toolbox.Tests.Utils
{
	[TestClass]
	public class DateUtilTests
	{
		#region Tests
		[TestMethod]
		public void Date_GetDate_Unix_Timestamp()
		{
			DateTime expectedDate = new DateTime(2000, 1, 2, 3, 4, 5);
			DateTime date = DateUtil.GetDate(946782245);

			Assert.AreEqual(expectedDate, date);
		}

		[TestMethod]
		public void Date_GetDate_Unix_Timestamp_Max_Value()
		{
			DateTime expectedDate = new DateTime(2038, 1, 19, 3, 14, 7);
			DateTime date = DateUtil.GetDate(int.MaxValue);

			Assert.AreEqual(expectedDate, date);
		}

		[TestMethod]
		public void Date_GetDate_Unix_Timestamp_Min_Value()
		{
			DateTime expectedDate = new DateTime(1901, 12, 13, 20, 45, 52);
			DateTime date = DateUtil.GetDate(int.MinValue);

			Assert.AreEqual(expectedDate, date);
		}
		#endregion
	}
}