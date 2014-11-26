using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Utils;
using System.Collections;
using System.Collections.Generic;

namespace Toolbox.Tests.Utils
{
	[TestClass]
	public class ClassUtilTests
	{
		#region Tests
		[TestMethod]
		public void Class_GetInstance_By_Generic()
		{
			object obj = ClassUtil.GetInstance<Exception>();

			Assert.IsNotNull(obj);
			Assert.IsInstanceOfType(obj, typeof(Exception));
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Class_GetInstance_By_Type()
		{
			object obj = ClassUtil.GetInstance(typeof(Exception));

			Assert.IsNotNull(obj);
			Assert.IsInstanceOfType(obj, typeof(Exception));
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Class_GetInstance_Null_Value()
		{
			object obj = ClassUtil.GetInstance(null);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Class_GetListInstance_By_Type()
		{
			IList list = ClassUtil.GetListInstance(typeof(string));

			Assert.IsNotNull(list);
			Assert.IsInstanceOfType(list, typeof(List<string>));
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Class_GetListInstance_Null_Value()
		{
			object obj = ClassUtil.GetListInstance(null);
		}
		#endregion
	}
}