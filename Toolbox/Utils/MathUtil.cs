using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Utils
{
	public static class MathUtil
	{
		#region Public Static Methods
		public static double CalculateBasicValue(double percentValue, double percentage)
		{
			return ((percentValue / percentage) * 100);
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static double CalculatePercentValue(double basicValue, double percentage)
		{
			return (basicValue * (percentage / 100));
		}

		// ---------------------------------------------------------------------------------------------------- //

		public static double CalculatePercentage(double basicValue, double percentValue)
		{
			return ((percentValue / basicValue) * 100);
		}
		#endregion
	}
}