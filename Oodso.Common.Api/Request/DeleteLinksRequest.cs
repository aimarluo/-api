using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yun;
using Yun.Interface;
using Yun.Response;
using Yun.Util;


namespace Oodso.Common.Api.Request
{
    /// <summary>
    /// 删除友情链接
    /// oodso.common.link.delete
    /// </summary>
    public class DeleteLinksRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.link.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id }

            };
            return parameters;
        }

        public int Id { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }
    }
}
