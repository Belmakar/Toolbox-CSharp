using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Data.Exchange
{
	public class DataImport : DataExchange, IDataImport
	{
		#region Constructor
		public DataImport(IDataReader reader, IDataWriter writer)
			: base(reader, writer)
		{
		}

		// ---------------------------------------------------------------------------------------------------- //

		public DataImport(IDataReader reader, IDataWriter writer, IDataParser parser)
			: base(reader, writer, parser)
		{
		}
		#endregion

		#region Public Methods
		public void Import()
		{
			base.Exchange();
		}
		#endregion
	}
}