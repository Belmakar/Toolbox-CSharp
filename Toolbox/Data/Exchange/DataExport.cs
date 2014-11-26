using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Data.Exchange
{
	public class DataExport : DataExchange, IDataExport
	{
		#region Constructor
		public DataExport(IDataReader reader, IDataWriter writer)
			: base(reader, writer)
		{
		}

		// ---------------------------------------------------------------------------------------------------- //

		public DataExport(IDataReader reader, IDataWriter writer, IDataParser parser)
			: base(reader, writer, parser)
		{
		}
		#endregion

		#region Public Methods
		public void Export()
		{
			base.Exchange();
		}
		#endregion
	}
}