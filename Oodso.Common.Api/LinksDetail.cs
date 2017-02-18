using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Oodso.Common.Api
{
    public class LinksDetail
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }
        /// <summary>
        /// 链接名称
        /// </summary>
        [XmlElement("sitename")]
        public string Sitename { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>
        [XmlElement("siteurl")]
        public string Siteurl { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contacts")]
        public string Contacts { get; set; }
        /// <summary>
        /// qq号
        /// </summary>
        [XmlElement("qq")]
        public string QQ { get; set; }

        /// <summary>
        /// 排序号 
        /// </summary>
        [XmlElement("sort")]
        public int Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("createtime")]
        public string CreateTime { get; set; }
        /// <summary>
        /// 状态 0-正常，1-锁定
        /// </summary>
        [XmlElement("status")]
        public int Status { get; set; }

        /// <summary>
        /// 站点标识  0-欧德莱尔，1-4（欧德莱尔4个资源站）
        /// </summary>
        [XmlElement("siteid")]
        public int Siteid { get; set; }

    }
}
