using Microsoft.AspNetCore.Mvc;
using MovieWebSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebSite.ViewComponents
{
    public class CategoryGetList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            GenresRepository genresRepository = new GenresRepository();
            var genreslist = genresRepository.TList();
            return View(genreslist);
        }
    }
}
