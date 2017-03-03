using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yun.Response;

namespace Oodso.Common.Api.Response
{
    [XmlRoot("sitestoken_response")]
    public class SitestokenResponse : YunResponse
    {
        [XmlElement("sites_token_model")]
        public SitesTokenModel SitesTokenModel { get; set; }
    }
}
