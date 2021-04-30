using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSExam1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSExam1.Controllers
{
    public class CochesController : Controller
    {
        public RepositoryCoches repo;

        public CochesController(RepositoryCoches repo) { this.repo = repo; }

        public IActionResult Index()
        {
            return View(this.repo.GetCoches());
        }

        public IActionResult SearchCar(int id)
        {
            return View(this.repo.SearchCar(id));
        }

    }
}
