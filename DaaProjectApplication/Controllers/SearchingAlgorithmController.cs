using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaaProjectApplication.Controllers
{
    public class SearchingAlgorithmController : Controller
    {
        // GET: SearchingAlgorithm
        public ActionResult LinearSearch()
        {
            return View();
        }

        public ActionResult BinarySearch()
        {
            return View();
        }

        public ActionResult BinarySearchTree()
        {
            return View();
        }

        public ActionResult RedBlackTree()
        {
            return View();
        }
    }
}