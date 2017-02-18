using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yun.Response;

namespace Oodso.Common.Api.Response
{
    [XmlRoot("links_response")]
    public class LinksResponse : YunResponse, IPageResponse
    {
        [XmlArray("linkslist")]
        [XmlArrayItem("links")]
        public List<LinksDetail> LinksList { get; set; }


        [XmlElement("total_item")]
        public long TotalItem { get; set; }
    }
}
