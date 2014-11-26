using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toolbox.Extensions;

namespace Toolbox.Tests.Extensions
{
	[TestClass]
	public class StringExtensionsTests
	{
		#region Setup
		public Random random { get; set; }
		public int maxArraySize { get; set; }
		public int minArraySize { get; set; }

		[TestInitialize]
		public void Initialize()
		{
			random = new Random();
			minArraySize = 10;
			maxArraySize = 100;
		}

		[TestCleanup]
		public void Cleanup()
		{
			random = null;
			minArraySize = 0;
			maxArraySize = 0;
		}
		#endregion
		
		#region Tests
		[TestMethod]
		public void String_Is_Not_Null_Or_Empty()
		{
			string str = "abc";
			bool result = str.IsNullOrEmpty();
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_Is_Null()
		{
			string str = null;
			bool result = str.IsNullOrEmpty();
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_Is_Empty()
		{
			string str = "     ";
			bool result = str.IsNullOrEmpty();
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_IsLowerCase_False()
		{
			string str = "aBcDeFgHiJ";
			bool result = str.IsLowerCase();
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_IsLowerCase_True()
		{
			string str = "abcdefghij";
			bool result = str.IsLowerCase();
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_IsUpperCase_False()
		{
			string str = "aBcDeFgHiJ";
			bool result = str.IsUpperCase();
			Assert.IsFalse(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_IsUpperCase_True()
		{
			string str = "ABCDEFGHIJ";
			bool result = str.IsUpperCase();
			Assert.IsTrue(result);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToBoolean_Is_False()
		{
			string[] values = { "0", "no", "false" };

			foreach (string value in values)
			{
				Assert.IsFalse(value.ToBoolean());
			}		
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToBoolean_Is_True()
		{
			string[] values = { "1", "yes", "true" };

			foreach (string value in values)
			{
				Assert.IsTrue(value.ToBoolean());
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToInt16Array()
		{
			short[] arr = GetInt16Array();
			string str = String.Join(",", arr);
			short[] values = str.ToInt16Array();

			Assert.IsNotNull(values);
			Assert.AreEqual(arr.Length, values.Length);

			for (int i = 0; i < values.Length; i++)
			{
				Assert.AreEqual(arr[i], values[i]);
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToInt32Array()
		{
			int[] arr = GetInt32Array();
			string str = String.Join(",", arr);
			int[] values = str.ToInt32Array();

			Assert.IsNotNull(values);
			Assert.AreEqual(arr.Length, values.Length);

			for (int i = 0; i < values.Length; i++)
			{
				Assert.AreEqual(arr[i], values[i]);
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToInt64Array()
		{
			long[] arr = GetInt64Array();
			string str = String.Join(",", arr);
			long[] values = str.ToInt64Array();

			Assert.IsNotNull(values);
			Assert.AreEqual(arr.Length, values.Length);

			for (int i = 0; i < values.Length; i++)
			{
				Assert.AreEqual(arr[i], values[i]);
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToUInt16Array()
		{
			ushort[] arr = GetUInt16Array();
			string str = String.Join(",", arr);
			ushort[] values = str.ToUInt16Array();

			Assert.IsNotNull(values);
			Assert.AreEqual(arr.Length, values.Length);

			for (int i = 0; i < values.Length; i++)
			{
				Assert.AreEqual(arr[i], values[i]);
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToUInt32Array()
		{
			uint[] arr = GetUInt32Array();
			string str = String.Join(",", arr);
			uint[] values = str.ToUInt32Array();

			Assert.IsNotNull(values);
			Assert.AreEqual(arr.Length, values.Length);

			for (int i = 0; i < values.Length; i++)
			{
				Assert.AreEqual(arr[i], values[i]);
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_ToUInt64Array()
		{
			ulong[] arr = GetUInt64Array();
			string str = String.Join(",", arr);
			ulong[] values = str.ToUInt64Array();

			Assert.IsNotNull(values);
			Assert.AreEqual(arr.Length, values.Length);

			for (int i = 0; i < values.Length; i++)
			{
				Assert.AreEqual(arr[i], values[i]);
			}
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_TrimToNull_Empty_Value()
		{
			string str = "     ";
			string value = str.TrimToNull();

			Assert.IsNull(value);
		}

		// ---------------------------------------------------------------------------------------------------- //

		[TestMethod]
		public void String_TrimToNull_Not_Empty_Value()
		{
			string str = "  abc  ";
			string value = str.TrimToNull();

			Assert.IsNotNull(value);
			Assert.AreEqual("abc", value);
		}
		#endregion

		#region Private Methods
		private short[] GetInt16Array()
		{
			int arrSize = random.Next(minArraySize, maxArraySize);
			short[] arr = new short[arrSize];

			for (int i = 0; i < arrSize; i++)
			{
				arr[i] = (short)random.Next(short.MinValue, short.MaxValue);
			}

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		private int[] GetInt32Array()
		{
			int arrSize = random.Next(minArraySize, maxArraySize);
			int[] arr = new int[arrSize];

			for (int i=0; i < arrSize; i++)
			{
				arr[i] = random.Next();
			}

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		private long[] GetInt64Array()
		{
			int arrSize = random.Next(minArraySize, maxArraySize);
			long[] arr = new long[arrSize];

			for (int i = 0; i < arrSize; i++)
			{
				arr[i] = random.Next();
			}

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		private ushort[] GetUInt16Array()
		{
			int arrSize = random.Next(minArraySize, maxArraySize);
			ushort[] arr = new ushort[arrSize];

			for (int i = 0; i < arrSize; i++)
			{
				arr[i] = (ushort)random.Next(ushort.MinValue, ushort.MaxValue);
			}

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		private uint[] GetUInt32Array()
		{
			int arrSize = random.Next(minArraySize, maxArraySize);
			uint[] arr = new uint[arrSize];

			for (int i = 0; i < arrSize; i++)
			{
				arr[i] = random.NextUInt();
			}

			return arr;
		}

		// ---------------------------------------------------------------------------------------------------- //

		private ulong[] GetUInt64Array()
		{
			int arrSize = random.Next(minArraySize, maxArraySize);
			ulong[] arr = new ulong[arrSize];

			for (int i = 0; i < arrSize; i++)
			{
				arr[i] = random.NextULong();
			}

			return arr;
		}
		#endregion
	}
}