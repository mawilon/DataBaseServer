using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperateDB.DBEntity
{
    public class SqlDB
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public int DB_Type { get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        public string SB_Name { get; set; }
    }
}
