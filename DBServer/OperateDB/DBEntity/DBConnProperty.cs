using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperateDB.DBEntity
{
    public class DBConnProperty
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public int DB_Type { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DB_Name { get; set; }

        /// <summary>
        /// 数据库地址
        /// </summary>
        public string DB_DataSource { get; set; }

        /// <summary>
        /// 请求用户
        /// </summary>
        public string DB_UserID { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string DB_Password { get; set; }
    }
}
