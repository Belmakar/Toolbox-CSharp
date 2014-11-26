using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Extensions
{
	public static class DateExtensions
	{
		#region Public Static Methods
		public static int GetUnixTimestamp(this DateTime date)
		{
			DateTime date1 = new DateTime(1970, 1, 1, 0, 0, 0);
			DateTime date2 = new DateTime(date.Ticks);

			double seconds1 = new TimeSpan(date1.Ticks).TotalSeconds;
			double seconds2 = new TimeSpan(date2.Ticks).TotalSeconds;

			int timestamp = (int)(seconds2 - seconds1);

			return timestamp;
		}
		#endregion
	}
}