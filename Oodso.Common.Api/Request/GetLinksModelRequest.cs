using Oodso.Common.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yun;
using Yun.Interface;
using Yun.Util;

namespace Oodso.Common.Api.Request
{
    /// <summary>
    /// 获取友情链接详情
    /// oodso.common.link.get
    /// </summary>
    public class GetLinksModelRequest : ITopRequest<LinksModelResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.link.get";
        }

        /// <summary>
        /// 需要返回的字段信息
        /// </summary>
        public string Fields { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id },
                {"fields",Fields}
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
