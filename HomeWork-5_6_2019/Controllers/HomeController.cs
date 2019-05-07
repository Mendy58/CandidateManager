using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeWork_5_6_2019.Models;
using HomeWork_5_6_2019.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HomeWork_5_6_2019.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _environment;
        private string _connectionstring;

        public HomeController(IHostingEnvironment environment,
            IConfiguration configuration)
        {
            _environment = environment;
            _connectionstring = configuration.GetConnectionString("ConStr");
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pending()
        {
            var DB = new CandidateRepository(_connectionstring);
            return View(DB.GetPendingCandidates());
        }
        public IActionResult Confirmed()
        {
            var DB = new CandidateRepository(_connectionstring);
            return View(DB.GetConfirmedCandidates());
        }
        public IActionResult Declined()
        {
            var DB = new CandidateRepository(_connectionstring);
            return View(DB.GetDeclinedCandidates());
        }
        public IActionResult Details(int id)
        {
            var DB = new CandidateRepository(_connectionstring);
            return View(DB.GetCandidateByid(id));
        }
        public IActionResult Confirm(int id)
        {
            var DB = new CandidateRepository(_connectionstring);
            DB.ConfirmCandidate(id);
            return Redirect("/home/Confirmed");
        }
        public IActionResult Decline(int id)
        {
            var DB = new CandidateRepository(_connectionstring);
            DB.DeclineCandidate(id);
            return Redirect("/home/Declined");
        }
        [HttpPost]
        public IActionResult addcandidate(Candidate c)
        {
            var DB = new CandidateRepository(_connectionstring);
            DB.AddCandidate(c);
            return Redirect("/home/pending");
        }
    }
}
