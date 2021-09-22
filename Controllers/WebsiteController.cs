using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieWebSite.Models;
using MovieWebSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MovieWebSite.Controllers
{
    public class WebsiteController : Controller
    {
        Context context = new Context();
        WebsiteRepository websiteRepository = new WebsiteRepository();

        [Authorize]
        public IActionResult Index(int page=1)
        {
                var list = websiteRepository.TList().ToPagedList(page, 9);
                return View(list);
        }

        [Authorize]
        public IActionResult AdminDetails(int id)
        {

            var value = (from movie in context.Website.Where(x => x.Id == id).Include(x => x.Genres).Include(x => x.Choose).Include(x => x.Country).Include(x=>x.Filter) select movie).ToList();

            return View(value);
        }


        [Authorize]
        public IActionResult Movie(string searchMovie, int page = 1)
        {

            if (!string.IsNullOrEmpty(searchMovie))
            {
                var value = (from movie in context.Website.Where(x => x.FilterId == 1).Where(x => x.Name.Contains(searchMovie) || x.Genres.Name.Contains(searchMovie) || x.Choose.Name.Contains(searchMovie) || x.Country.Name.Contains(searchMovie) || x.Director.Contains(searchMovie)
                             || x.Actors.Contains(searchMovie) || x.WatchTime.Contains(searchMovie)).
                             Include(x => x.Genres).Include(x => x.Choose).Include(x => x.Country).Include(x=>x.Filter) select movie).ToList().ToPagedList(page, 7);
                return View(value);
            }

            var result = (from movie in context.Website.Where(x => x.FilterId == 1).Include(x => x.Genres).Include(x => x.Choose).Include(x => x.Country).Include(x => x.Filter) select movie).ToList().ToPagedList(page, 3);
            return View(result);

        }

        [Authorize]
        public IActionResult TvShow(string searchTv, int page = 1)
        {
            if (!string.IsNullOrEmpty(searchTv))
            {
                var value = (from tv in context.Website.Where(x => x.FilterId ==2 ).Where(x => x.Name.Contains(searchTv) || x.Genres.Name.Contains(searchTv) 
                             || x.Choose.Name.Contains(searchTv) || x.Country.Name.Contains(searchTv) || x.Director.Contains(searchTv)
                             || x.Actors.Contains(searchTv) || x.WatchTime.Contains(searchTv))
                             .Include(x => x.Genres).Include(x => x.Choose).Include(x => x.Country).Include(x => x.Filter) select tv).ToList().ToPagedList(page, 7);
                return View(value);
            }

            var result = (from tv in context.Website.Where(x => x.FilterId ==2).Include(x => x.Genres).Include(x => x.Choose).Include(x => x.Country).Include(x => x.Filter) select tv).ToList().ToPagedList(page, 3);
            return View(result);
        }

        [HttpGet]
        [Authorize]
        public IActionResult MovieAdd()
        {
            List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = genresV.Name,
                                                     Value = genresV.Id.ToString()


                                                 }).ToList();
            ViewBag.genresValue = genresValues;
            List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = chooseV.Name,
                                                     Value = chooseV.Id.ToString()


                                                 }).ToList();
            ViewBag.chooseValue = chooseValues;
            List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = countryV.Name,
                                                      Value = countryV.Id.ToString()


                                                  }).ToList();
            ViewBag.countryValue = countryValues;
            List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = countryV.Name,
                                                     Value = countryV.Id.ToString()


                                                 }).ToList();
            ViewBag.filterValue = filterValues;
            return View("MovieAdd");
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult MovieAdd(Website website)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = genresV.Name,
                                                         Value = genresV.Id.ToString()


                                                     }).ToList();
                ViewBag.genresValue = genresValues;
                List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = chooseV.Name,
                                                         Value = chooseV.Id.ToString()


                                                     }).ToList();
                ViewBag.chooseValue = chooseValues;
                List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                      select new SelectListItem
                                                      {
                                                          Text = countryV.Name,
                                                          Value = countryV.Id.ToString()


                                                      }).ToList();
                ViewBag.countryValue = countryValues;
                List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = countryV.Name,
                                                         Value = countryV.Id.ToString()


                                                     }).ToList();
                ViewBag.filterValue = filterValues;
                return View("MovieAdd");
            }


            websiteRepository.TAdd(website);

            return RedirectToAction("Movie");
        }

        [HttpGet]
        [Authorize]
        public IActionResult TvAdd()
        {
            List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = genresV.Name,
                                                     Value = genresV.Id.ToString()


                                                 }).ToList();
            ViewBag.genresValue = genresValues;
            List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = chooseV.Name,
                                                     Value = chooseV.Id.ToString()


                                                 }).ToList();
            ViewBag.chooseValue = chooseValues;
            List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = countryV.Name,
                                                      Value = countryV.Id.ToString()


                                                  }).ToList();
            ViewBag.countryValue = countryValues;
            List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = countryV.Name,
                                                     Value = countryV.Id.ToString()


                                                 }).ToList();
            ViewBag.filterValue = filterValues;
            return View("TvAdd");
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult TvAdd(Website website)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = genresV.Name,
                                                         Value = genresV.Id.ToString()


                                                     }).ToList();
                ViewBag.genresValue = genresValues;
                List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = chooseV.Name,
                                                         Value = chooseV.Id.ToString()


                                                     }).ToList();
                ViewBag.chooseValue = chooseValues;
                List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                      select new SelectListItem
                                                      {
                                                          Text = countryV.Name,
                                                          Value = countryV.Id.ToString()


                                                      }).ToList();
                ViewBag.countryValue = countryValues;
                List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = countryV.Name,
                                                         Value = countryV.Id.ToString()


                                                     }).ToList();
                ViewBag.filterValue = filterValues;
                return View("TvAdd");
            }


            websiteRepository.TAdd(website);

            return RedirectToAction("TvShow");
        }

        [Authorize]
        public IActionResult TvDelete(int id)
        {
            websiteRepository.TDelete(new Website { Id = id });
            return RedirectToAction("TvShow");
        }
        [Authorize]
        public IActionResult MovieDelete(int id)
        {
            websiteRepository.TDelete(new Website { Id = id });
            return RedirectToAction("Movie");
        }
        [Authorize]
        public IActionResult TvGetInfo(int id)
        {
            var getinfo = websiteRepository.TGet(id);

            List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = genresV.Name,
                                                     Value = genresV.Id.ToString()


                                                 }).ToList();
            ViewBag.genresValue = genresValues;
            List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()

                                                 select new SelectListItem
                                                 {
                                                     Text = chooseV.Name,
                                                     Value = chooseV.Id.ToString()


                                                 }).ToList();
            ViewBag.chooseValue = chooseValues;
            List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = countryV.Name,
                                                      Value = countryV.Id.ToString()


                                                  }).ToList();
            ViewBag.countryValue = countryValues;
            List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = countryV.Name,
                                                     Value = countryV.Id.ToString()


                                                 }).ToList();
            ViewBag.filterValue = filterValues;

            Website website = new Website()
            {
                Id = getinfo.Id,
                Actors = getinfo.Actors,
                Director = getinfo.Director,
                ReleaseYear = getinfo.ReleaseYear,
                Rating = getinfo.Rating,
                ImageUrl = getinfo.ImageUrl,
                Name = getinfo.Name,
                Link = getinfo.Link,
                Description = getinfo.Description,
                WatchTime = getinfo.WatchTime,
                ChooseId = getinfo.ChooseId,
                CountryId = getinfo.CountryId,
                GenresId = getinfo.GenresId,
                FilterId = getinfo.FilterId
            };

            return View(website);
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult TvUpdate(Website website)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = genresV.Name,
                                                         Value = genresV.Id.ToString()


                                                     }).ToList();
                ViewBag.genresValue = genresValues;

                List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = chooseV.Name,
                                                         Value = chooseV.Id.ToString()


                                                     }).ToList();

                ViewBag.chooseValue = chooseValues;

                List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                      select new SelectListItem
                                                      {
                                                          Text = countryV.Name,
                                                          Value = countryV.Id.ToString()


                                                      }).ToList();

                ViewBag.countryValue = countryValues;
                List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = countryV.Name,
                                                         Value = countryV.Id.ToString()


                                                     }).ToList();
                ViewBag.filterValue = filterValues;

                return View("TvGetInfo");
            }
            var upinfo = websiteRepository.TGet(website.Id);

            upinfo.Name = website.Name;
            upinfo.ReleaseYear = website.ReleaseYear;
            upinfo.GenresId = website.GenresId;
            upinfo.CountryId = website.CountryId;
            upinfo.ChooseId = website.ChooseId;
            upinfo.Description = website.Description;
            upinfo.Rating = website.Rating;
            upinfo.Country = website.Country;
            upinfo.ImageUrl = website.ImageUrl;
            upinfo.Director = website.Director;
            upinfo.Link = website.Link;
            upinfo.Actors = website.Actors;
            upinfo.WatchTime = website.WatchTime;
            upinfo.FilterId = website.FilterId;

            websiteRepository.TUpdate(upinfo);

            return RedirectToAction("TvShow");
        }
        [Authorize]
        public IActionResult MovieGetInfo(int id)
        {
            var getinfo = websiteRepository.TGet(id);

            List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = genresV.Name,
                                                     Value = genresV.Id.ToString()
                                                 }).ToList();
            ViewBag.genresValue = genresValues;
            List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()

                                                 select new SelectListItem
                                                 {
                                                     Text = chooseV.Name,
                                                     Value = chooseV.Id.ToString()
                                                 }).ToList();
            ViewBag.chooseValue = chooseValues;
            List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                  select new SelectListItem
                                                  {
                                                      Text = countryV.Name,
                                                      Value = countryV.Id.ToString()
                                                  }).ToList();
            ViewBag.countryValue = countryValues;
            List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = countryV.Name,
                                                     Value = countryV.Id.ToString()
                                                 }).ToList();
            ViewBag.filterValue = filterValues;

            Website website = new Website()
            {
                Id = getinfo.Id,
                Actors = getinfo.Actors,
                Director = getinfo.Director,
                ReleaseYear = getinfo.ReleaseYear,
                Rating = getinfo.Rating,
                ImageUrl = getinfo.ImageUrl,
                Name = getinfo.Name,
                Link = getinfo.Link,
                Description = getinfo.Description,
                WatchTime = getinfo.WatchTime,
                ChooseId = getinfo.ChooseId,
                CountryId = getinfo.CountryId,
                GenresId = getinfo.GenresId,
                FilterId = getinfo.FilterId
            };

            return View(website);
        }


        [HttpPost]
        public IActionResult MovieUpdate(Website website)
        {
            if (!ModelState.IsValid)
            {
                List<SelectListItem> genresValues = (from genresV in context.Genres.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = genresV.Name,
                                                         Value = genresV.Id.ToString()
                                                     }).ToList();
                ViewBag.genresValue = genresValues;

                List<SelectListItem> chooseValues = (from chooseV in context.Choose.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = chooseV.Name,
                                                         Value = chooseV.Id.ToString()
                                                     }).ToList();

                ViewBag.chooseValue = chooseValues;

                List<SelectListItem> countryValues = (from countryV in context.Country.ToList()
                                                      select new SelectListItem
                                                      {
                                                          Text = countryV.Name,
                                                          Value = countryV.Id.ToString()
                                                      }).ToList();

                ViewBag.countryValue = countryValues;
                List<SelectListItem> filterValues = (from countryV in context.Filter.ToList()
                                                     select new SelectListItem
                                                     {
                                                         Text = countryV.Name,
                                                         Value = countryV.Id.ToString()
                                                     }).ToList();
                ViewBag.filterValue = filterValues;
                return View("MovieGetInfo");
            }
            var upinfo = websiteRepository.TGet(website.Id);

            upinfo.Name = website.Name;
            upinfo.ReleaseYear = website.ReleaseYear;
            upinfo.GenresId = website.GenresId;
            upinfo.CountryId = website.CountryId;
            upinfo.ChooseId = website.ChooseId;
            upinfo.Description = website.Description;
            upinfo.Rating = website.Rating;
            upinfo.Country = website.Country;
            upinfo.ImageUrl = website.ImageUrl;
            upinfo.Director = website.Director;
            upinfo.Link = website.Link;
            upinfo.Actors = website.Actors;
            upinfo.WatchTime = website.WatchTime;
            upinfo.FilterId = website.FilterId;

            websiteRepository.TUpdate(upinfo);
            return RedirectToAction("Movie");
        }

        public IActionResult Details(int id)
        {
            var value = (from detail in context.Website.Where(x => x.Id == id).Include(x => x.Genres).Include(x => x.Choose).Include(x => x.Country).Include(x=>x.Filter) select detail).ToList();

            return View(value);
        }


    }
}
