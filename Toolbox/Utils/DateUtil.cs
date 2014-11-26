using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Utils
{
	public static class DateUtil
	{
		#region Public Static Methods
		public static DateTime GetDate(int unixTimestamp)
		{
			TimeSpan timespan = new TimeSpan(0, 0, unixTimestamp);			
			DateTime date = new DateTime(1970, 1, 1, 0, 0, 0);
			date = date.Add(timespan);
			
			return date;
		}
		#endregion
	}
}