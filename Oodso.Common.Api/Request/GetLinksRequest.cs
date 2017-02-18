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
    /// 获取友情链接链表
    /// oodso.common.link.list
    /// </summary>
    public class GetLinksRequest : ITopRequest<LinksResponse>
    {
        public string GetApiName()
        {
            return "oodso.common.link.list";
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
        /// 需要返回的字段
        /// </summary>
        public string Fields { get; set; }

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

        public string CreateTime { get; set; }
        /// <summary>
        /// 状态 0-正常，1-锁定
        /// </summary>

        public int? Status { get; set; }


        public int? Siteid { get; set; }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new YunDictionary
             {
                 {"pagenum", PageNum},
                 {"pagesize", PageSize},
                 {"fields", Fields},
                 {"sitename", Sitename },
                 {"createtime", CreateTime },
                 {"contacts", Contacts },
                 {"status", Status },
                 {"qq", QQ },
                 {"Siteid", Siteid}
             };
            return parameters;
        }

        public void Validate()
        {

        }

    }
}
