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
    /// 获取管理平台站点登录Token更新
    /// oodso.common.sitestoken.update
    /// </summary>
    public class UpdateSitesTokenRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.sitestoken.update";
        }
        /// <summary>
        /// ID
        /// </summary>

        public int Id { get; set; }
        /// <summary>
        /// 站点id
        /// </summary>

        public int Sitesid { get; set; }


        /// <summary>
        /// 登录名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// token值
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string Createtime { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sitesid", Sitesid);
            RequestValidator.ValidateRequired("username", Username);
            RequestValidator.ValidateRequired("token", Token);
            RequestValidator.ValidateRequired("createtime", Createtime);
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            { 
                {"id",Id},
                {"sitesid",Sitesid},
                {"username",Username},
                {"token",Token},
                {"createtime", Createtime}
            };
            return parameters;
        }

    }
}
