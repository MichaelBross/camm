using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Application.Models;
using CAMM.DataAccess.Interface; 

namespace Repository
{
    public class WorkOrdersRepo : IDataProvider<WorkOrder>
    {
        public WorkOrder Add(WorkOrder workOrder)
        {

            var context = new CammContext();
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

        public WorkOrder GetById(string WoNumber)
        {
            var context = new CammContext();
            var WO = context.WorkOrders.Find(WoNumber);
            return WO;
        }

        public IEnumerable<WorkOrder> GetAll()
        {
            var context = new CammContext();
            var WO = context.WorkOrders.AsEnumerable();
            return WO;
        }

        public IEnumerable<WorkOrder> Find(WorkOrder workOrder)
        {
            var context = new CammContext();
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
            var context = new CammContext();
            
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

        public int Remove (string woNumber)
        {
            var context = new CammContext();
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

        public WorkOrder Update (WorkOrder workorder)
        {
            var context = new CammContext();
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
               
        public WorkOrder GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void SubmitChanges()
        {
            throw new NotImplementedException();
        }
    }
}
