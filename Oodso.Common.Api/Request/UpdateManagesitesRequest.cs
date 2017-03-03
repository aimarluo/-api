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
    /// 获取管理平台站点更改
    /// oodso.common.managesites.update
    /// </summary>
    public class UpdateManagesitesRequest : ITopRequest<BoolResultResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.managesites.update";
        }
        /// <summary>
        /// ID
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// 接口号
        /// </summary>

        public int Port { get; set; }

        /// <summary>
        /// 公司id
        /// </summary>

        public int Companyid { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>

        public int Shopid { get; set; }


        /// <summary>
        /// 站点名称
        /// </summary>
        public string Sitesname { get; set; }

        public void Validate()
        {
            RequestValidator.ValidateRequired("port", Port);
            RequestValidator.ValidateRequired("companyid", Companyid);
            RequestValidator.ValidateRequired("shopid", Shopid);
            RequestValidator.ValidateRequired("sitesname", Sitesname);
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"id",Id},
                {"port", Port},
                {"companyid", Companyid},
                {"shopid", Shopid},
                {"sitesname", Sitesname}
            };
            return parameters;
        }
    }
}
