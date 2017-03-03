using Oodso.Common.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yun;
using Yun.Interface;

namespace Oodso.Common.Api.Request
{
    /// <summary>
    /// 获取管理平台站点登录Token列表
    /// oodso.common.sitestokenlist.get
    /// </summary>
    public class GetSitesTokenListRequest : ITopRequest<SitestokenListResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.sitestokenlist.get";
        }
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNum
        {
            get { return _pageNum; }
            set
            {
                _pageNum = value < 1 ? 1 : value;
            }
        }

        private int _pageNum = 1;

        /// <summary>
        /// 页容量
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set
            {
                _pageSize = value < 1 ? 1 : value;
            }
        }

        private int _pageSize = 1;

        /// <summary>
        /// 站点id
        /// </summary>

        public int? Sitesid { get; set; }


        /// <summary>
        /// 登录名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 需要返回的字段
        /// </summary>
        public string Fields { get; set; }

        public void Validate()
        {
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
            {
                {"pagenum", PageNum },
                {"pagesize",PageSize},
                {"sitesid",Sitesid},
                {"username",Username}, 
                {"fields",Fields}
            };
            return parameters;
        }
    }
}
