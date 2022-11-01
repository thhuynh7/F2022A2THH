using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F2022A2THH.Controllers
{
    public class TracksController : Controller
    {
        // GET: Tracks
        private Manager m = new Manager();

        public ActionResult Index()
        {
            return View(m.TrackGetAll());
        }

        public ActionResult BluesAndJazz()
        {
            var tracks = m.TrackGetBluesJazz();
            return View("Index", tracks);
        }

        public ActionResult CantrellAndStaley()
        {
            var tracks = m.TrackGetCantrellStaley();
            return View("Index", tracks);
        }

        public ActionResult Top50Longest()
        {
            var tracks = m.TrackGetTop50Longest();
            return View("Index", tracks);
        }

        public ActionResult Top50Smallest()
        {
            var tracks = m.TrackGetTop50Smallest();
            return View("Index", tracks);
        }
    }
}
