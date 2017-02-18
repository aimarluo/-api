using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oodso.Common.Api.Request;

namespace Yun.UnitTest
{
    [TestClass]
    public class CommonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        /// <summary>
        /// 添加友情链接
        /// </summary>
        [TestMethod]
        public void AddLinksRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new AddLinksRequest
            {
                Contacts = "测试联系人",
                CreateTime = 123456,
                QQ = "23154698",
                Siteid = 0,
                Sitename = "测试网站",
                Siteurl = "http://163.com",
                Sort = 0,
                Status = 0
            });

            Assert.IsTrue(true);

        }

        /// <summary>
        /// 删除友情链接
        /// </summary>
        [TestMethod]
        public void DeleteLinksRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new DeleteLinksRequest
            {
                Id = 0
            });

            Assert.IsTrue(true);

        }


        /// <summary>
        /// 获取友情链接详情
        /// </summary>
        [TestMethod]
        public void GetLinksModelRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetLinksModelRequest
            {
                Id = 10
            });

            Assert.IsTrue(true);

        }


        /// <summary>
        /// 获取友情链接列表
        /// </summary>
        [TestMethod]
        public void GetLinksRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new GetLinksRequest
            {
                PageNum = 1,
                PageSize = 10

            });

            Assert.IsTrue(true);

        }


        /// <summary>
        /// 修改友情链接
        /// </summary>
        [TestMethod]
        public void UpdateLinksRequest()
        {
            YunClient.Format = "json";

            var req = YunClient.Instance.Execute(new UpdateLinksRequest
            {
                Id = 42,
                Contacts = "测试联系人222",
                CreateTime = 123456,
                QQ = "23154698",
                Siteid = 0,
                Sitename = "测试网站22222222",
                Siteurl = "http://163.com",
                Sort = 0,
                Status = 0
            });

            Assert.IsTrue(true);

        }


    }
}
