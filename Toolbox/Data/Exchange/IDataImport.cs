using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.Data.Exchange
{
	public interface IDataImport : IDataExchange
	{
		void Import();
	}
}