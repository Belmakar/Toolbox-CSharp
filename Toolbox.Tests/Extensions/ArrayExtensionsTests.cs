using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Extensions;

namespace Toolbox.Tests.Utils
{
	[TestClass]
	public class ArrayExtensionsTests
	{
		#region Test
		[TestMethod]
		public void Array_Is_Not_Null_Or_Empty()
		{
			string[] arr = { "abc" };
			bool result = arr.IsNullOrEmpty();
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Array_Is_Null()
		{
			string[] arr = null;
			bool result = arr.IsNullOrEmpty();
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Array_Is_Empty()
		{
			string[] arr = { };
			bool result = arr.IsNullOrEmpty();
			Assert.IsTrue(result);
		}
		#endregion
	}
}