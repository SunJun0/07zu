﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using BLL;
namespace Shop.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeessBLL bll = new EmployeessBLL();
        public int Employeess(Employees m)
        {
            return bll.Add(m);
        }
    }
}
