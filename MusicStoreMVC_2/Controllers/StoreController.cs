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

        MusicStoreEntities storeDB = new MusicStoreEntities();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }

        public ActionResult Details(int id) // GET /Browse/Details/5
        {
            var album = storeDB.Albums.Find(id);

            return View(album);

        }

        public ActionResult Browse(string genre)
        {
            //var genreModel = new Genre{Name = genre};
            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(genreModel);
        }
    }
}
