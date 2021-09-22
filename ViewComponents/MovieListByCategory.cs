using Microsoft.AspNetCore.Mvc;
using MovieWebSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebSite.ViewComponents
{
    public class MovieListByCategory : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {

            WebsiteRepository websiteRepository = new WebsiteRepository();
            var movielist = websiteRepository.List(x => x.GenresId == id).Where(x=>x.FilterId==1);
            return View(movielist);
        }
    }
}
