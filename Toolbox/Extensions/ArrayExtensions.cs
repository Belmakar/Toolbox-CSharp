using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Extensions
{
	public static class ArrayExtensions
	{
		#region Public Static Methods
		public static bool IsNullOrEmpty(this Array value)
		{
			return (value == null || value.Length == 0) ? true : false;
		}
		#endregion
	}
}