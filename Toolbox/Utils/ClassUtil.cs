using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Utils
{
	public static class ClassUtil
	{
		#region Public Static Methods
		public static TClass GetInstance<TClass>()
		{
			return Activator.CreateInstance<TClass>();
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static object GetInstance(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");
			
			return Activator.CreateInstance(type);
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static IList GetListInstance(Type type)
		{
			if (type == null)
				throw new ArgumentNullException("type");

			Type listType = typeof(List<>).MakeGenericType(type);

			return (IList)Activator.CreateInstance(listType);
		}
		#endregion
	}
}