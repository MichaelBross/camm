using System;
using Application.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;

namespace MKM.UnitTest
{
    [TestClass]
    public class WorkOrderTests
    {
        WorkOrder MakeTestWorkOrder()
        {
            WorkOrder item = new WorkOrder
            {
                AssemblyNumber = "TestAssyNo",
                Customer = "TestCustomer",
                CustomerPO = "TestCustomerPO",
                DueDate = DateTimeOffset.Parse("1/21/2019"),
                QuantityToBuild = 123456,
                SalesOrder = "TestSONo",
                SalesOrderLineItemNo = "1",
                WoNumber = "TestWoNumber",
                WoStatus = "X"
            };

            return item;
        }

        [TestMethod]
        public void AddWorkOrder_ExpectedBehavior_ReturnsTestWorkOrder()
        {
            // Arrange
            WorkOrder item = MakeTestWorkOrder();
            var workOrdersRepo = new WorkOrdersRepo();

            // Act
            var result = workOrdersRepo.Add(item);

            // Assert
            Assert.AreEqual(item, result);

        }

        [TestMethod]
        public void GetWorkOrder_ExpectedBehavior_ReturnsTestWorkOrder()
        {
            // Arrange
            WorkOrder item = MakeTestWorkOrder();
            var workOrdersRepo = new WorkOrdersRepo();

            // Act
            WorkOrder retrieved = workOrdersRepo.GetById(item.WoNumber);            

            // Assert
            Assert.AreEqual(retrieved.AssemblyNumber, item.AssemblyNumber);
            Assert.AreEqual(retrieved.Customer, item.Customer);
            Assert.AreEqual(retrieved.CustomerPO, item.CustomerPO);
            Assert.AreEqual(retrieved.DueDate, item.DueDate);
            Assert.AreEqual(retrieved.QuantityToBuild, item.QuantityToBuild);
            Assert.AreEqual(retrieved.SalesOrder, item.SalesOrder);
            Assert.AreEqual(retrieved.SalesOrderLineItemNo, item.SalesOrderLineItemNo);
            Assert.AreEqual(retrieved.WoNumber, item.WoNumber);
            Assert.AreEqual(retrieved.WoStatus, item.WoStatus);            
        }

        [TestMethod]
        public void EditWorkOrder_ExpectedBehavior_ReturnsTestWorkOrder()
        {
            // Arrange
            WorkOrder item = MakeTestWorkOrder();
            item.AssemblyNumber = "EditTest";
            var workOrdersRepo = new WorkOrdersRepo();

            // Act            
            workOrdersRepo.Update(item);
            WorkOrder retrieved = workOrdersRepo.GetById(item.WoNumber);

            // Assert
            Assert.AreEqual(retrieved.AssemblyNumber, item.AssemblyNumber);
            Assert.AreEqual(retrieved.Customer, item.Customer);
            Assert.AreEqual(retrieved.CustomerPO, item.CustomerPO);
            Assert.AreEqual(retrieved.DueDate, item.DueDate);
            Assert.AreEqual(retrieved.QuantityToBuild, item.QuantityToBuild);
            Assert.AreEqual(retrieved.SalesOrder, item.SalesOrder);
            Assert.AreEqual(retrieved.SalesOrderLineItemNo, item.SalesOrderLineItemNo);
            Assert.AreEqual(retrieved.WoNumber, item.WoNumber);
            Assert.AreEqual(retrieved.WoStatus, item.WoStatus);
        }

        [TestMethod]
        public void DeleteWorkOrder_ExpectedBehaviour_WorkOrderRemoved()
        {
            // Arrange
            WorkOrder item = MakeTestWorkOrder();
            var workOrdersRepo = new WorkOrdersRepo();
            // Act            
            var result = workOrdersRepo.Remove(item.WoNumber);
            WorkOrder retrieved = workOrdersRepo.GetById(item.WoNumber);

            // Assert
            Assert.AreEqual(result, 1);
            Assert.AreEqual(retrieved, null);            
        }

    }
}
