using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStoreMVC_2.Models;

namespace MusicStoreMVC_2.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<Genre> {
                new Genre { Name = "Disco"}, 
                new Genre { Name = "Jazz"},
                new Genre { Name = "Rock"}
            };

            return View(genres);
        }

        public ActionResult Details(int id) // GET /Browse/Details/5
        {
            var album = new Album { Title = "Album " + id };

            return View(album);

        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre{Name = genre};
            return View(genreModel);
        }
    }
}
