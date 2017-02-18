using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Yun.Response;

namespace Oodso.Common.Api.Response
{
    [XmlRoot("links_model_response")]
    public class LinksModelResponse : YunResponse
    {
        [XmlElement("linksmodel")]
        public LinksDetail LinksModel { get; set; }
    }
}
