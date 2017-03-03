using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Oodso.Common.Api
{
    public class ManageSitesModel
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        [XmlElement("sitesname")]
        public string Sitesname { get; set; }
        /// <summary>
        /// 接口号
        /// </summary>
        [XmlElement("port")]
        public sbyte Port { get; set; }
        /// <summary>
        /// 公司ID
        /// </summary>
        [XmlElement("companyid")]
        public int Companyid { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("shopid")]
        public int Shopid { get; set; }
    }
}
