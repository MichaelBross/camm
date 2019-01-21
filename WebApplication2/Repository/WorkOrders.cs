using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Repository
{
    public class WorkOrders
    {
        public static WorkOrder Add(WorkOrder workOrder)
        {

            var context = new MFG_TablesContext();
            var keyViolation = context.WorkOrders.Find(workOrder.WoNumber);
            if(keyViolation != null)
            {
                throw new Exception("Duplicate WoNumber");
            }
            var WO = context.WorkOrders.Add(workOrder);
                        
            try
            {
                var result = context.SaveChanges();
                if(result == 1)
                {
                    return WO;
                }
                else
                {
                    throw new Exception("Save failed for an unknown reason.");
                };
                
            }
            catch (Exception ex)
            {
                throw new Exception("Save failed. " + ex.InnerException.InnerException);
            }           
            
        }

        public static WorkOrder Get(string WoNumber)
        {
            var context = new MFG_TablesContext();
            var WO = context.WorkOrders.Find(WoNumber);
            return WO;
        }

        public static IEnumerable<WorkOrder> GetAll()
        {
            var context = new MFG_TablesContext();
            var WO = context.WorkOrders.AsEnumerable();
            return WO;
        }

        public static IEnumerable<WorkOrder> Find(WorkOrder workOrder)
        {
            var context = new MFG_TablesContext();
            var query = context.WorkOrders.AsQueryable();
            
            if(workOrder.AssemblyNumber != null)
            {
                query = query.Where(q => q.AssemblyNumber.Contains(workOrder.AssemblyNumber));
            }

            if (workOrder.Customer != null)
            {
                query = query.Where(q => q.AssemblyNumber.Contains(workOrder.Customer));
            }

            if (workOrder.CustomerPO != null)
            {
                query = query.Where(q => q.AssemblyNumber.Contains(workOrder.CustomerPO));
            }

            if (workOrder.SalesOrder != null)
            {
                query = query.Where(q => q.AssemblyNumber.Contains(workOrder.SalesOrder));
            }

            if (workOrder.SalesOrderLineItemNo != null)
            {
                query = query.Where(q => q.AssemblyNumber.Contains(workOrder.SalesOrderLineItemNo));
            }

            if (workOrder.WoNumber != null)
            {
                query = query.Where(q => q.AssemblyNumber.Contains(workOrder.WoNumber));
            }

            if (workOrder.WoStatus != null)
            {
                query = query.Where(q => q.AssemblyNumber.Contains(workOrder.WoStatus));
            }

            return query.AsEnumerable<WorkOrder>();
        }

        public static IEnumerable<WorkOrder> Find(string searchString)
        {            
            var context = new MFG_TablesContext();
            
            var query = context.WorkOrders.AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                string[] terms = searchString.Split(' ');

                DateTime startDate = new DateTime();
                DateTime endDate = new DateTime();

                foreach (string term in terms)
                {
                    if (startDate == DateTime.MinValue && DateTime.TryParse(term, out startDate)) continue;
                    if (startDate != DateTime.MinValue && endDate == DateTime.MinValue && DateTime.TryParse(term, out endDate))
                    {
                        query = query.Where(q => q.DueDate >= startDate && q.DueDate <= endDate);
                        continue;
                    }

                    query = query.Where(q => q.AssemblyNumber.Contains(term)
                    || q.Customer.Contains(term)
                    || q.CustomerPO.Contains(term)
                    || q.SalesOrder.Contains(term)
                    || q.SalesOrderLineItemNo.Contains(term)
                    || q.SalesOrderLineItemNo.Contains(term)
                    || q.WoNumber.Contains(term)
                    || q.WoStatus.Contains(term));
                }
            }


            return query.AsEnumerable<WorkOrder>();
        }

        public static int Remove (string woNumber)
        {
            var context = new MFG_TablesContext();
            WorkOrder unwanted = context.WorkOrders.Find(woNumber);

            try
            {
                context.WorkOrders.Remove(unwanted);
                var result = context.SaveChanges();
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        public static WorkOrder Update (WorkOrder workorder)
        {
            var context = new MFG_TablesContext();
            WorkOrder targetItem = context.WorkOrders.Find(workorder.WoNumber);
            if(targetItem != null)
            {
                targetItem.AssemblyNumber = workorder.AssemblyNumber;
                targetItem.Customer = workorder.Customer;
                targetItem.CustomerPO = workorder.CustomerPO;
                targetItem.DueDate = workorder.DueDate;
                targetItem.QuantityToBuild = workorder.QuantityToBuild;
                targetItem.SalesOrder = workorder.SalesOrder;
                targetItem.SalesOrderLineItemNo = workorder.SalesOrderLineItemNo;
                targetItem.WoStatus = workorder.WoStatus;
                targetItem.TimeStamp = DateTime.Now;
            }
            else
            {
                throw new Exception("WorkOrder with WoNumber " + workorder.WoNumber + " not found.");
            }

            context.SaveChanges();
            return targetItem;                       
        }

        //public static WorkOrder Create (WorkOrder workorder)
        //{
        //    var context = new MFG_TablesContext();
        //    WorkOrder hasSameKeyValue = context.WorkOrders.Find(workorder.WoNumber);

        //    if(hasSameKeyValue != null)
        //    {
        //        throw new Exception("WoNumber " + workorder.WoNumber + " already exists.");
        //    }

        //    WorkOrder newWorkOrder = context.WorkOrders.Add(workorder);
        //    context.SaveChanges();
        //    return newWorkOrder;
        //}

        public static int RemoveMany(List<string> woNumbers)
        {
            var context = new MFG_TablesContext();

            foreach(string woNumber in woNumbers)
            {
                WorkOrder unwanted = context.WorkOrders.Find(woNumber);
                context.WorkOrders.Remove(unwanted);
            }

            var result = context.SaveChanges();
            return result;
        }

    }
}
