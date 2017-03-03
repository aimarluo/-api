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
    /// 获取管理平台站点列表
    /// oodso.common.managesiteslist.get
    /// </summary>
    public class GetManagesitesListRequest : ITopRequest<ManagesitesListResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.managesiteslist.get";
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
        /// 接口号
        /// </summary>

        public int? Port { get; set; }

        /// <summary>
        /// 公司id
        /// </summary>

        public int? Companyid { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>

        public int? Shopid { get; set; }


        /// <summary>
        /// 站点名称
        /// </summary>
        public string Sitesname { get; set; }

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
                {"port",Port},
                {"companyid",Companyid},
                {"shopid",Shopid},
                {"sitesname",Sitesname},
                {"fields",Fields}  
            };
            return parameters;
        }

    }
}
