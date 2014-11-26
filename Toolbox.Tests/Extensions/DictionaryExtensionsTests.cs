using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Toolbox.Extensions;

namespace Toolbox.Tests.Extensions
{
	[TestClass]
	public class DictionaryExtensionsTests
	{
		#region Tests
		[TestMethod]
		public void Dict_Is_Not_Null_Or_Empty()
		{
			Dictionary<string, string> dict = new Dictionary<string, string>();
			dict.Add("key", "value");

			bool result = dict.IsNullOrEmpty();
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Dict_Is_Null()
		{
			Dictionary<string, string> dict = null;
			bool result = dict.IsNullOrEmpty();
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Dict_Is_Empty()
		{
			Dictionary<string, string> dict = new Dictionary<string, string>();
			bool result = dict.IsNullOrEmpty();
			Assert.IsTrue(result);
		}
		#endregion
	}
}