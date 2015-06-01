using System.Web.Mvc;
using SharpPatterns.ViewModels;

namespace SharpPatterns.Controllers
{
    public class MementoController : Controller
    {
        private readonly ICustomerFactory _customerFactory;

        public MementoController(ICustomerFactory customerFactory)
        {
            _customerFactory = customerFactory;
        }

        //
        // GET: /Memento/

        public ActionResult Index()
        {
            var mementoViewModel = new MementoViewModel
            {
                Customers = new CustomerViewModel[20]
            };
            for (var i = 0; i < 20; i++)
            {
                mementoViewModel.Customers[i] = _customerFactory.Create();
            }
            return View(mementoViewModel);
        }
    }
}
