﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Extensions
{
	public static class ListExtensions
	{
		#region Public Static Methods
		public static bool IsNullOrEmpty(this IList value)
		{
			return (value == null || value.Count == 0) ? true : false;
		}
		#endregion
	}
}