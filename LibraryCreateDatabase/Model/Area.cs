using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCreateDatabase.Model
{
 public   class Area
    {
        public Guid Id { get; set; }
        /// <summary>
        /// 地区名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 区域代码
        /// </summary>
        public string AreaCode { get; set; }
        /// <summary>
        /// 父级区域代码
        /// </summary>
        public string ParentAreaCode { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public int Delflag { get; set; }
    }
}
