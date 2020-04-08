﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = getCustomers();
            return View(customers);
        }

        private IEnumerable<Customer> getCustomers()
        {
            return new List<Customer>
            {
                new Customer{Name="Mark Underwood"},
                new Customer{Name="Gary Oldman"}
            };
        }
    }
}