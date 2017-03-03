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
    /// 获取管理平台站点
    /// oodso.common.managesites.get
    /// </summary>
    public class GetManagesitesRequest : ITopRequest<ManagesitesResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.managesites.get";
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
