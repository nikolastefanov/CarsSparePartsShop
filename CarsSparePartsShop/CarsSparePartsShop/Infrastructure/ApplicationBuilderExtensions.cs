

namespace CarsSparePartsShop.Infrastructure
{
    using CarsSparePartsShop.Data;
    using CarsSparePartsShop.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System.Linq;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(
             this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<ApplicationDbContext>();

            data.Database.EnsureCreated();

           SeedCategories(data);

            return app;
        }
     
       private static void SeedCategories(ApplicationDbContext data)
       {
            if (!data.Categories.Any())
            {

                data.Categories.AddRange(new[]
                {
                      new Category { Name = "Engine" ,ImageUrl="https://fcache1.pakwheels.com/original/3X/4/d/4d9606406f5850e351b358bbfe9d3cb91e07c0fe.jpg "},
                      new Category { Name = "Transmission",ImageUrl="https://www.mediastorehouse.com.au/p/617/modern-car-5-speed-manual-gearbox-cross-section-9596591.jpg " },
                      new Category { Name = "Brake system" ,ImageUrl="https://www.anatomynote.com/wp-content/uploads/2019/05/6189/Car-brake-system-diagram.jpg "},
                      new Category { Name = "Electrical" ,ImageUrl="https://www.newkidscar.com/wp-content/uploads/2019/04/electrical-system.jpg "},
                      new Category { Name = "Body" ,ImageUrl=" https://i.pinimg.com/originals/29/21/e1/2921e13f68e862f75f10a37263f3cb6f.jpg"},
                      new Category { Name = "Tires " ,ImageUrl="https://www.napolitan.it/wp-content/uploads/2019/06/pneumatici-4-stagioni-300x260.jpg"},
                      new Category { Name = "Air conditioner" ,ImageUrl=" https://media.istockphoto.com/photos/car-air-conditioner-system-in-car-garage-car-air-conditioner-check-picture-id1179826380"},
                     
                  });

                data.SaveChanges();
                //index page:  https://local-auto-locksmith.co.uk/wp-content/uploads/2020/01/5c7e7fc789f49339065587c2-768x459.jpg
                //       }
                //
                //
                //       // if (data.SpareParts.Any())
                //       // {
                //       //     return;
                //       // }
                //
                //
                //
                //
                //       // data.SpareParts.AddRange(new[]
                //       //     {
                //       //        new SparePart
                //       //        {
                //       //            Name = "Turbocharger",
                //       //            Manufacturer="SKF",
                //       //            ImageUrl=" ",
                //       //            Price=200.0M,
                //       //            Available=10,
                //       //            IssueTypeId=data.IssueTypes
                //       //                          .Where(it => it.Name == "Engine") 
                //       //                            .FirstOrDefault().Id,
                //       //
                //       //        },
                //       // });
                //
                //
                //
                //
                //       //       new SparePart { Name = "Transmission" },
                //       //       new SparePart { Name = "Diagnostics" },
                //       //       new SparePart { Name = "Brake system" },
                //       //       new SparePart { Name = "Electrical installation" },
                //       //       new SparePart { Name = "Coupe" },
                //       //       new SparePart { Name = "Tires " },
                //       //       new SparePart { Name = "air conditioner" },
                //       //       new SparePart { Name = "Technical review" },
                //
                //
                //       //   data.SaveChanges();

                return;
            }
        }
    }
}

   

