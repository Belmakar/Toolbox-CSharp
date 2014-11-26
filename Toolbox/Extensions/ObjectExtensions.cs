using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Extensions
{
	public static class ObjectExtensions
	{
		#region Public Static Methods
		public static bool HasField(this object value, string fieldName)
		{
			if (value == null)
				throw new ArgumentNullException("value");

			if (fieldName == null)
				throw new ArgumentNullException("fieldName");

			Type type = value.GetType();
			FieldInfo field = type.GetField(fieldName);

			return (field == null) ? false : true;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static bool HasMethod(this object value, string methodName)
		{
			if (value == null)
				throw new ArgumentNullException("value");

			if (methodName == null)
				throw new ArgumentNullException("methodName");
						
			try
			{
				Type type = value.GetType();
				MethodInfo method = type.GetMethod(methodName);

				if (method != null)
					return true;
			}

			catch (AmbiguousMatchException)
			{
				return true;
			}

			return false;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static bool HasProperty(this object value, string propertyName)
		{
			if (value == null)
				throw new ArgumentNullException("value");

			if (propertyName == null)
				throw new ArgumentNullException("propertyName");
			
			Type type = value.GetType();
			PropertyInfo property = type.GetProperty(propertyName);
			
			return (property == null) ? false : true;
		}		
		#endregion
	}
}