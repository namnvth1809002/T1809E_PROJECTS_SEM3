﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T1809E_PROJECT_SEM3.Models;

namespace T1809E_PROJECT_SEM3.Controllers
{
    public class ClientController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Client
        public ActionResult Index()
        {
            ClientViewModel client = new ClientViewModel();
            var service = db.Services.AsEnumerable();
            client.Services = service.Where(s => s.Status == Service.StatusEnumService.Online).Take(4).ToList();
            client.Offices = db.Offices.AsEnumerable().Take(10).ToList();
            return View(client);
        }
    }
}