using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yun.Response;

namespace Oodso.Common.Api.Response
{
    [XmlRoot("sitestoken_list_response")]
    public class SitestokenListResponse : YunResponse, IPageResponse
    {
        [XmlArray("sites_token_list")]
        [XmlArrayItem("sitestokens")]
        public List<SitesTokenModel> SitesTokenList { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
