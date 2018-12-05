using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DienMayQuyetTien.Controllers;
using System.Web.Mvc;
using DienMayQuyetTien.Models;
using System.Collections.Generic;
namespace DienMayQuyetTien.Tests.Controllers
{
    [TestClass]
    public class BangSanPhamTest
    {
        [TestMethod]
        public void TestIndex()
        {
            var controller = new BangSanPhamController();
            var result = controller.Index() as ViewResult;
            var db = new CS4PEEntities();
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.Model, typeof(List<BangSanPham>));
            Assert.AreEqual(db.BangSanPhams.Count(), ((List<BangSanPham>)result.Model).Count);
        }
    }
}
