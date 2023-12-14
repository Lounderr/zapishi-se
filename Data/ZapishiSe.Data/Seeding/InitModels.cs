using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using ZapishiSe.Data.Models;

namespace ZapishiSe.Data.Seeding
{
    internal class InitModels
    {
        public BusinessCategory InitBusinessCategory()
        {
            return new BusinessCategory
            {
                Name = "Фризьорски салон",
            };
        }

        public Business InitBusiness(BusinessCategory businessCategory, ApplicationUser applicationUser)
        {
            return new Business
            {
                Name = "Фризьорски салон THE ONE",
                Description = "Перфектният фризьорски салон за Вас!",
                Address = new Address
                {
                    Street = "ул. Царска, 1",
                    City = "Пазарджик",
                },
                Phone = "0876455905",
                Pricing = Models.Enums.Pricing.Standard,
                BusinessCategory = businessCategory,
                Owner = applicationUser,
                CreatedOn = DateTime.Now,
                ModifiedOn = null,
                IsDeleted = false,
                DeletedOn = null,
            };
        }

        public BusinessImage InitBusinessImage(Business business)
        {
            return new BusinessImage
            {
                Name = "image.png",
                Filetype = "png",
                Path = "https://picsum.photos/600/300",
                Order = 1,
                CreatedOn = DateTime.Now,
                Business = business,
            };
        }

        public Service InitService(Business business)
        {
            return new Service
            {
                Name = "Мъжка прическа",
                HasPriceRange = false,
                BasePrice = 12,
                MaxPrice = null,
                Duration = new TimeSpan(0, minutes: 40, 0),
                Business = business,
            };
        }

        public BusinessPromotion InitBusinessPromotion(Business business)
        {
            return new BusinessPromotion
            {
                StartDateTime = DateTime.Now,
                EndDateTime = DateTime.Now + new TimeSpan(30, 0, 0, 0),
                CreatedOn = DateTime.Now,
                Business = business,
            };
        }

        public BusinessReport InitBusinessReport(ApplicationUser applicationUser, Business business)
        {
            return new BusinessReport
            {
                Content = "Report text",
                ReportCategory = Models.Enums.ReportType.Scam,
                Author = applicationUser,
                Business = business,
            };
        }

        public ReviewInteraction InitReviewInteraction(ApplicationUser applicationUser, Review review)
        {
            return new ReviewInteraction
            {
                IsLiked = true,
                Author = applicationUser,
                Review = review,
                CreatedOn = DateTime.Now,
            };
        }

        public ReviewReport InitReviewReport(ApplicationUser applicationUser, Review review)
        {
            return new ReviewReport
            {
                Content = "Report Description",
                CreatedOn = DateTime.Now,
                Author = applicationUser,
                Review = review,
                ReportCategory = Models.Enums.ReportType.Spam,
            };
        }

        public Review InitReview(ApplicationUser applicationUser, Business business)
        {
            return new Review
            {
                Content = "Example Review 1",
                Author = applicationUser,
                Business = business,
                CreatedOn = DateTime.Now,
                Pricing = Models.Enums.Pricing.Low,
                Rating = 4,
            };
        }

        public BookedAppointment InitBookedAppointment(ApplicationUser applicationUser, Service service, Business business)
        {
            return new BookedAppointment
            {
                AppointmentStart = DateTime.Now + TimeSpan.FromDays(1),
                AppointmentStatus = Models.Enums.AppointmentStatus.Accepted,
                CreatedOn = DateTime.Now,
                IsAttended = false,
                ApplicationUser = applicationUser,
                Service = service,
                Business = business,
            };
        }

        public OpenHours InitOpenHours(Business business)
        {
            return new OpenHours
            {
                DayOfWeek = DayOfWeek.Monday,
                OpeningTime = new TimeOnly(09, 00),
                ClosingTime = new TimeOnly(18, 00),
                Business = business,
            };
        }

        public Break InitBreak(OpenHours openHours)
        {
            return new Break
            {
                BreakStart = new TimeOnly(13, 00),
                BreakEnd = new TimeOnly(14, 00),
                OpenHours = openHours,
            };
        }

        public Holiday InitHoliday(Business business)
        {
            return new Holiday
            {
                HolidayStart = new DateOnly(2024, 1, 1),
                HolidayEnd = new DateOnly(2024, 1, 7),
                Business = business,
            };
        }


    }
}