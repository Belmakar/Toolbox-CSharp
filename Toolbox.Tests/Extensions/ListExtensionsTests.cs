using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Extensions;
using System.Collections.Generic;

namespace Toolbox.Tests.Extensions
{
	[TestClass]
	public class ListExtensionsTests
	{
		#region Tests
		[TestMethod]
		public void List_Is_Not_Null_Or_Empty()
		{
			List<string> list = new List<string>();
			list.Add("abc");

			bool result = list.IsNullOrEmpty();
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void List_Is_Null()
		{
			List<string> list = null;
			bool result = list.IsNullOrEmpty();
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void List_Is_Empty()
		{
			List<string> list = new List<string>();
			bool result = list.IsNullOrEmpty();
			Assert.IsTrue(result);
		}
		#endregion
	}
}