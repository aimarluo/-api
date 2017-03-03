using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yun.Response;

namespace Oodso.Common.Api.Response
{
    [XmlRoot("managesites_list_response")]
    public class ManagesitesListResponse : YunResponse, IPageResponse
    {
        [XmlArray("manage_sites_list")]
        [XmlArrayItem("managesites")]
        public List<ManageSitesModel> ManageSitesList { get; set; }

        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
