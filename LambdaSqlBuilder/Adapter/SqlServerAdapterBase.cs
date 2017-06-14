/* License: http://www.apache.org/licenses/LICENSE-2.0 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaSqlBuilder.Adapter
{
    /// <summary>
    /// Provides functionality common to all supported SQL Server versions
    /// </summary>
    public class SqlServerAdapterBase : SqlAdapterBase
    {
        public virtual string QueryStringPage(string source, string selection, string conditions, string order,
            int pageSize)
        {
            return string.Format("SELECT TOP({4}) {0} FROM {1} {2} {3}",
                    selection, source, conditions, order, pageSize);
        }


        public virtual string Table(string tableName)
        {
            return string.Format("[{0}]", tableName);
        }

        public virtual string Field(string tableName, string fieldName)
        {
            return string.Format("[{0}].[{1}]", tableName, fieldName);
        }

        public virtual string Parameter(string parameterId)
        {
            return "@" + parameterId;
        }
    }
}
