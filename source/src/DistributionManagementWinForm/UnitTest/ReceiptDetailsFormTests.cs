using DAL;
using DistributionManagementWinForm.home.Inventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class ReceiptDetailsFormTests
    {
        [TestMethod]
        public void Product_id_ReturnsCorrectId()
        {
            ReceiptDetailsForm form = new ReceiptDetailsForm();
            string productName = "iPhone XR";

            int productId = form.Product_id(productName);

            Assert.AreEqual(30000, productId);
        }

        [TestMethod]
        public void Received_id_ReturnsMaxReceivedId()
        {
            ReceiptDetailsForm form = new ReceiptDetailsForm();

            int receivedId = form.Received_id();
            int maxID = Convert.ToInt32(Connection.selectQuery("SELECT TOP 1 received_id FROM Goods_Received_Note").Rows[0][0].ToString());

            Assert.AreEqual(maxID, receivedId);
        }
    }
}
