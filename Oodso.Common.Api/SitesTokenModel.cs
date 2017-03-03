using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Oodso.Common.Api
{
    public class SitesTokenModel
    {
        /// <summary>
        /// ID
        /// </summary>
        [XmlElement("id")]
        public int Id { get; set; }
        /// <summary>
        /// 站点ID
        /// </summary>
        [XmlElement("sitesid")]
        public int Sitesid { get; set; }
        /// <summary>
        /// 登录用户名
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
        /// <summary>
        /// 用户Token
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        [XmlElement("createtime")]
        public string Createtime { get; set; }


    }
}
