using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieWebSite.Models;
using MovieWebSite.Repositories;
using X.PagedList;

namespace MovieWebSite.Controllers
{
    public class HomeController : Controller
    {

        Context context = new Context();
        WebsiteRepository websiteRepository= new WebsiteRepository();


        public IActionResult Index(string search)
        {

            if (!string.IsNullOrEmpty(search))
            {
                var value = websiteRepository.List(m => m.Name.Contains(search));
                return RedirectToAction("Details", "Website", new { id = value[0].Id });
            }

            var website = websiteRepository.TList();
            return View(website);

        }

        public IActionResult CategoryDetails(int id)
        {
            ViewBag.id = id;
            return View();
        }

        public IActionResult MovieList(int page = 1)
        {
            var movie = websiteRepository.TList().Where(x=>x.FilterId==1).ToPagedList(page, 9);
            return View(movie);
        }

        public IActionResult TvList(int page=1)
        {
            var tv = websiteRepository.TList().Where(x => x.FilterId == 2).ToPagedList(page, 9);
            return View(tv);
            
        }
        public IActionResult Question()
        {

            return View();
        }

        public IActionResult Communication()
        {
            return View();
        }

        public async Task<IActionResult> ImdbList(string sortOrder, string search)
        {

            if (!string.IsNullOrEmpty(search))
            {
                var value = websiteRepository.List(m => m.Name.Contains(search));
                return RedirectToAction("Details", "Website", new { id = value[0].Id });
            }

            var popular = from p in context.Website.Where(x=>x.FilterId==1)
                          select p;
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            switch (sortOrder)
            {

                case "Date":
                    popular = popular.OrderBy(s => s.Rating);
                    break;
                default:
                    popular = popular.OrderByDescending(s => s.Rating);
                    break;

            }
            return View(await popular.AsNoTracking().ToListAsync());
        }


        public async Task<IActionResult> AZList(string sortOrder,string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var value = websiteRepository.List(m => m.Name.Contains(search));
                return RedirectToAction("Details", "Website", new { id = value[0].Id });
            }
            var AzList = from list in context.Website.Where(x => x.FilterId == 1) select list;

            ViewData["NameOrder"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            switch (sortOrder)
            {
                case "name_desc":
                    AzList = AzList.OrderByDescending(s => s.Name);
                    break;
                default:
                    AzList = AzList.OrderBy(s => s.Name);
                    break;
            }
            return View(await AzList.AsNoTracking().ToListAsync());

        }


        public async Task<IActionResult> RecentlyAdded(string sortOrder,string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                var value = websiteRepository.List(m => m.Name.Contains(search));
                return RedirectToAction("Details", "Website", new { id = value[0].Id });
            }
            var RecentlyAdded = from addedlist in context.Website.Where(x => x.FilterId == 1) select addedlist;
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            switch (sortOrder)
            {

                case "Date":
                    RecentlyAdded = RecentlyAdded.OrderBy(s => s.Id);
                    break;
                default:
                    RecentlyAdded = RecentlyAdded.OrderByDescending(s => s.Id);
                    break;

            }
            return View(await RecentlyAdded.AsNoTracking().ToListAsync());

        }






    }
}
