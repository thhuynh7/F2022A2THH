using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A2THH.Controllers
{
    public class InvoicesController : Controller
    {
        // GET: Invoices
        private Manager m = new Manager();
        public ActionResult Index()
        {
            return View(m.InvoiceGetAll());
        }

        // GET: Invoices/Details/5
        public ActionResult Details(int? id)
        {
            var invoice = m.InvoiceGetByIdWithDetail(id.GetValueOrDefault());
            if (invoice == null)
                return HttpNotFound();
            else
                return View(invoice);
        }
    }
}
