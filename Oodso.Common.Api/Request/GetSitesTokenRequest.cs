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
    /// 获取管理平台站点登录Token
    /// oodso.common.sitestoken.get
    /// </summary>
    public class GetSitesTokenRequest : ITopRequest<SitestokenResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.sitestoken.get";
        }
        public int Id { get; set; }
        public void Validate()
        {
            RequestValidator.ValidateRequired("id", Id);
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id", Id } 
            };
            return parameters;
        }

    }
}
