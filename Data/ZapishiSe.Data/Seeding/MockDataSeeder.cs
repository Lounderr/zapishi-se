using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZapishiSe.Data.Models;

namespace ZapishiSe.Data.Seeding
{
    internal class MockDataSeeder : InitModels, ISeeder
    {
        public ApplicationUser ApplicationUser { get; set; }

        public BusinessCategory BusinessCategory { get; set; }

        public Business Business { get; set; }

        public BusinessImage BusinessImage { get; set; }

        public Service Service { get; set; }
        public BusinessPromotion BusinessPromotion { get; private set; }
        public BusinessReport BusinessReport { get; private set; }
        public ReviewInteraction ReviewInteraction { get; private set; }
        public ReviewReport ReviewReport { get; private set; }
        public Review Review { get; private set; }
        public BookedAppointment BookedAppointment { get; private set; }
        public OpenHours OpenHours { get; private set; }
        public Break Break { get; private set; }
        public Holiday Holiday { get; private set; }

        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            BusinessCategory = InitBusinessCategory();

            ApplicationUser = dbContext.Users.First(x => x.UserName == "Example");

            Business = InitBusiness(BusinessCategory, ApplicationUser);
            Service = InitService(Business);

            OpenHours = InitOpenHours(Business);
            Break = InitBreak(OpenHours);

            Holiday = InitHoliday(Business);

            BusinessImage = InitBusinessImage(Business);

            BusinessPromotion = InitBusinessPromotion(Business);

            BusinessReport = InitBusinessReport(ApplicationUser, Business);

            Review = InitReview(ApplicationUser, Business);
            ReviewInteraction = InitReviewInteraction(ApplicationUser, Review);
            ReviewReport = InitReviewReport(ApplicationUser, Review);

            BookedAppointment = InitBookedAppointment(ApplicationUser, Service, Business);




            await dbContext.BusinessCategories.AddAsync(BusinessCategory);
            await dbContext.Businesses.AddAsync(Business);
            await dbContext.BusinessImages.AddAsync(BusinessImage);
            await dbContext.Services.AddAsync(Service);
            await dbContext.BookedAppointments.AddAsync(BookedAppointment);

            await dbContext.BusinessPromotions.AddAsync(BusinessPromotion);
            await dbContext.BusinessReports.AddAsync(BusinessReport);
            await dbContext.ReviewInteractions.AddAsync(ReviewInteraction);
            await dbContext.ReviewReports.AddAsync(ReviewReport);
            await dbContext.Reviews.AddAsync(Review);

            await dbContext.OpenHours.AddAsync(OpenHours);
            await dbContext.Breaks.AddAsync(Break);
            await dbContext.Holidays.AddAsync(Holiday);

        }



    }
}
