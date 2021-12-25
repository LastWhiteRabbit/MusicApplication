using Microsoft.AspNetCore.Mvc;
using RS1_Seminarski.Data;
using RS1_Seminarski.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Seminarski.Controllers
{
    public class TrackController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TrackController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Track> objList = _db.Track;
            return View(objList); 
        }
    }
}
