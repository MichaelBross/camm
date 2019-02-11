using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Application.Models;
using Application.ViewModels;
using Repository;
using System.Linq.Dynamic;
using WebApplication2.Code;

namespace WebApplication2.Controllers
{
    public class WorkOrdersController : Controller
    {
        private WorkOrdersRepo workOrdersRepo;

        public WorkOrdersController()
        {
            this.workOrdersRepo = new WorkOrdersRepo();
        }

        // GET: WorkOrders
        public ActionResult Index(string searchString)
        {
            return View();
        }

        [HttpPost]
        public JsonResult Search(string searchstring)
        {
            var searchResults = WorkOrdersRepo.Find(searchstring).ToList();
            return Json(searchResults);
        }

        [HttpPost]
        public JsonResult SearchServerSide()
        {
            // Get Server Side Parameters from Request
            int start = Convert.ToInt32(Request["start"]);
            int length = Convert.ToInt32(Request["length"]);
            string searchValue = Request["search[value]"];
            string sortColumnName = Request["columns[" + Request["order[0][column]"] + "][name]"];
            string sortDirection = Request["order[0][dir]"];
           
            // Total record count
            int totalrows = workOrdersRepo.GetAll().Count();

            // Search
            var searchResults = WorkOrdersRepo.Find(searchValue);
            int totalrowsafterfiltering = searchResults.Count();

            // Sort
            searchResults = searchResults.OrderBy(sortColumnName + " " + sortDirection);

            // Page
            searchResults = searchResults.Skip(start).Take(length).ToList();

            return Json(new { data = searchResults, draw = Request["draw"], recordsTotal = totalrows, recordsFiltered = totalrowsafterfiltering }, JsonRequestBehavior.AllowGet);
        }

        // POST: WorkOrders/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "WoNumber,Customer,CustomerPO,SalesOrder,DueDate,AssemblyNumber,QuantityToBuild,WoStatus,SalesOrderLineItemNo")] WorkOrderDetail detail)
        {
            if (ModelState.IsValid)
            {
                WorkOrder workorder = new WorkOrder();
                CopyPropertyValues.CopyPropertiesTo<WorkOrderDetail, WorkOrder>(detail, workorder);
                try
                {                    
                    WorkOrder retrieved = workOrdersRepo.Add(workorder);
                    return Json(new { success = true, model = retrieved });
                }
                catch (Exception ex)
                {
                    if(ex.Message == "Duplicate WoNumber")
                    {
                        ModelState.AddModelError("WoNumber", "Duplicate WO Number.");
                    }                    
                }                
            }
            return JsonErrorResult();
        }

        // POST: WorkOrders/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Update([Bind(Include = "WoNumber,Customer,CustomerPO,SalesOrder,DueDate,AssemblyNumber,QuantityToBuild,WoStatus,SalesOrderLineItemNo")] WorkOrderDetail detail)
        {
            if (ModelState.IsValid)
            {                
                WorkOrder workorder = new WorkOrder();
                CopyPropertyValues.CopyPropertiesTo<WorkOrderDetail, WorkOrder>(detail, workorder);
                WorkOrder updated = workOrdersRepo.Update(workorder);
                return Json(new { success = true, model = updated });
            }

            return JsonErrorResult();
        }

        // GET: WorkOrders/Delete
        [ValidateAntiForgeryToken]
        [HttpPost]
        public JsonResult Delete([Bind(Include = "WoNumber")] WorkOrderDetail detail)
        {
            if (detail.WoNumber == null)
            {
                return Json(new { success = false, ErrorMessage = "WoNumber cannot be null." });
            }

            try
            {                
                var result = workOrdersRepo.Remove(detail.WoNumber);
                if (result == 1)
                {
                    return Json(new { success = true });
                }
                return Json(new { success = false, ErrorMessage = "Failed to delete WoNumber " + detail.WoNumber });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, ErrorMessage = ex.Message });
            }
        }

        private JsonResult JsonErrorResult()
        {
            List<ValidationError> validationErrors = new List<ValidationError>();
            var propertyErrors = ModelState.Where(x => x.Value.Errors.Count > 0).ToList();
            foreach (KeyValuePair<string, ModelState> item in propertyErrors)
            {
                ValidationError validationError = new ValidationError();
                validationError.PropertyName = item.Key;
                foreach (ModelError error in item.Value.Errors)
                {
                    validationError.ErrorMessage = error.ErrorMessage;
                }
                validationErrors.Add(validationError);
            }
            return Json(new { success = false, errors = validationErrors }, JsonRequestBehavior.AllowGet);
        }

        public class ValidationError
        {
            public string PropertyName { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}
