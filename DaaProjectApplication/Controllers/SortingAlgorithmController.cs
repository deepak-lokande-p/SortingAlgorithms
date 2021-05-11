using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaaProjectApplication.Controllers
{
    public class SortingAlgorithmController : Controller
    {
        // GET: SortingAlgorithms
        public ActionResult MergeSort()
        {
            return View();
        }

        public ActionResult HeapSort()
        {
            return View();
        }

        public ActionResult RegularQuickSort()
        {
            return View();
        }

        public ActionResult SplQuickSort()
        {
            return View();
        }

        public ActionResult InsertionSort()
        {
            return View();
        }

        public ActionResult SelectionSort()
        {
            return View();
        }

        public ActionResult BubbleSort()
        {
            return View();
        }
    }
}