using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Collections.Generic;
using System.Linq;
using ZapishiSe.Data;
using ZapishiSe.Data.Models;
using ZapishiSe.Web.ViewModels.Default.Search;

namespace ZapishiSe.Web.Controllers
{
    public class SearchController : Controller
    {
        // Temporary - should be in a service
        private readonly ApplicationDbContext context;

        public SearchController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(SearchViewModel viewModel)
        {
            var keywords = viewModel.Keywords.Split().Select(k => k.ToUpper());

            var businesses = this.context.Businesses.Include(x => x.BusinessCategory).Include(x => x.Address).Include(x => x.VisitsEachMonth).ToList()
                .Where(b =>
                    b.Address.City.Contains(viewModel.Location)
                && (b.Name.Split()
                    .Any(nw => keywords.Contains(nw.ToUpper()))
                || b.Description.Split()
                    .Any(dw => keywords.Contains(dw.ToUpper()))))
                .OrderBy(b => b.ReviewsAverage).ToList();

            businesses.Add(new Business
            {
                Id = 1,
                Name = "FirstBusiness",
                Description = null,
                BusinessImages = new List<BusinessImage>
                {
                    new BusinessImage
                    {
                        Id = 1,
                        Path = "https://picsum.photos/300/300",
                    },
                },
                Reviews = new List<Review>
                {
                    new Review
                    {
                        Rating = 5,
                    },
                },
                Pricing = Data.Models.Enums.Pricing.Standard,
                Address = new Address
                {
                    City = "Пазарджик",
                },
                BusinessCategory = new BusinessCategory
                {
                    Name = "Фризьорски салон",
                },
            });

            viewModel.Businesses = businesses;

            return View(viewModel);
        }

        [HttpPost]
        [ActionName("Index")]
        public IActionResult IndexPost(SearchViewModel input)
        {
            return RedirectToAction(nameof(Index), input);
        }
    }
}
