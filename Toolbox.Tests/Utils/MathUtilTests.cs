using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Utils;

namespace Toolbox.Tests.Utils
{
	[TestClass]
	public class MathUtilTests
	{
		#region Tests
		[TestMethod]
		public void Math_CalculateBasicValue()
		{
			double value = MathUtil.CalculateBasicValue(5, 4);
			Assert.AreEqual(125, value);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Math_CalculatePercentValue()
		{
			double value = MathUtil.CalculatePercentValue(130, 30);
			Assert.AreEqual(39, value);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Math_CalculatePercentage()
		{
			double value = MathUtil.CalculatePercentage(20, 4);
			Assert.AreEqual(20, value);
			
		}
		#endregion
	}
}