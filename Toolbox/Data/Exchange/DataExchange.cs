using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Data.Exchange
{
	public abstract class DataExchange : IDataExchange
	{

		#region Public Properties
		public IDataParser parser { get; set; }
		public IDataReader reader { get; set; }
		public IDataWriter writer { get; set; }
		#endregion

		#region Constructor
		public DataExchange(IDataReader reader, IDataWriter writer)
		{
			this.reader = reader;
			this.writer = writer;
		}

		// ---------------------------------------------------------------------------------------------------- //

		public DataExchange(IDataReader reader, IDataWriter writer, IDataParser parser)
		{
			this.reader = reader;
			this.writer = writer;
			this.parser = parser;
		}
		#endregion

		#region Protected Methods
		protected void Exchange()
		{
			object data = reader.Read();

			if (parser != null)
				data = parser.Parse(data);

			writer.Write(data);
		}
		#endregion
	}
}