using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yun.Response;

namespace Oodso.Common.Api.Response
{
    [XmlRoot("managesites_response")]
    public class ManagesitesResponse : YunResponse
    {
        [XmlElement("manage_sites_model")]
        public ManageSitesModel ManageSitesModel { get; set; }
    }
}
