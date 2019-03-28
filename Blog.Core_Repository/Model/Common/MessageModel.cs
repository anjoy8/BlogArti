using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Common
{

    /// <summary>
    /// 消息实体类
    /// </summary>
   public class MessageModel<T>
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 返回数据集合
        /// </summary>
        public List<T> Data { get; set; }

    }

    public class LayUITableModel<T>
    {
        /// <summary>
        /// 操作是否成功 0成功 1失败
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 返回数据集数量
        /// </summary>
        public int count { get; set; }
        /// <summary>
        /// 返回数据集合
        /// </summary>
        public List<T> data { get; set; }
    }

}
