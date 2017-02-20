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
    /// 添加友情链接
    /// oodso.common.link.add
    /// </summary>
    public class AddLinksRequest : ITopRequest<IntResultResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.link.add";
        }
        /// <summary>
        /// ID
        /// </summary>

        public int Id { get; set; }
        /// <summary>
        /// 链接名称
        /// </summary>

        public string Sitename { get; set; }
        /// <summary>
        /// 链接地址
        /// </summary>

        public string Siteurl { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>

        public string Contacts { get; set; }
        /// <summary>
        /// qq号
        /// </summary>

        public string QQ { get; set; }

        /// <summary>
        /// 排序号 
        /// </summary>

        public int Sort { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>

        public long CreateTime { get; set; }

        /// <summary>
        /// 状态 0-正常，1-锁定
        /// </summary>

        public int Status { get; set; }

        public int Siteid { get; set; }

        public int Companyid { get; set; }

        public int Shopid { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"sitename", Sitename},
                {"siteurl",Siteurl},
                {"sort", Sort},
                {"createtime", CreateTime},
                {"contacts", Contacts},
                {"qq", QQ},
                {"status", Status},
                {"siteid", Siteid},
                {"companyid", Companyid},
                {"shopid", Shopid}

            };

            return parameters;
        }
        public void Validate()
        {
            RequestValidator.ValidateRequired("sitename", Sitename);
            RequestValidator.ValidateRequired("siteurl", Siteurl);
        }
    }
}
