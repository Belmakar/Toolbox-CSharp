using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Extensions;

namespace Toolbox.Tests.Extensions
{
	[TestClass]
	public class ObjectExtensionsTests
	{
		#region Setup
		public ValueObject obj { get; set; }

		[TestInitialize]
		public void Initialize()
		{
			obj = new ValueObject();
		}

		[TestCleanup]
		public void Cleanup()
		{
			obj = null;
		}
		#endregion
		
		#region Tests
		[TestMethod]
		public void Object_HasField_Is_False()
		{
			bool result = obj.HasField("Field");
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasField_Is_True()
		{
			bool result = obj.HasField("ObjField");
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasField_Empty_Value()
		{
			bool result = obj.HasField("");
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Object_HasField_Null_Value()
		{
			bool result = obj.HasField(null);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasMethod_False()
		{
			bool result = obj.HasMethod("Method");
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasMethod_True()
		{
			bool result = obj.HasMethod("ObjMethod");
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasMethod_Overloaded_True()
		{
			bool result = obj.HasMethod("ObjMethodOverload");
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasMethod_Empty_Value()
		{
			bool result = obj.HasMethod("");
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Object_HasMethod_Null_Value()
		{
			bool result = obj.HasMethod(null);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasProperty_Is_False()
		{
			bool result = obj.HasProperty("Property");
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasProperty_Is_True()
		{
			bool result = obj.HasProperty("ObjProperty");
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void Object_HasProperty_Empty_Value()
		{
			bool result = obj.HasProperty("");
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void Object_HasProperty_Null_Value()
		{
			bool result = obj.HasProperty(null);
		}
		#endregion
	}

	// ---------------------------------------------------------------------------------------------------- //

	public class ValueObject
	{
		public string ObjField = null;
		public string ObjProperty { get; set; }

		public void ObjMethod() { }

		public void ObjMethodOverload(object value1) { }
		public void ObjMethodOverload(object value1, object value2) { }
		public void ObjMethodOverload(object value1, object value2, object value3) { }
	}
}