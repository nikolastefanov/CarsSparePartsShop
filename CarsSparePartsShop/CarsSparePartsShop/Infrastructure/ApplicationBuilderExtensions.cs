

namespace CarsSparePartsShop.Infrastructure
{
    using CarsSparePartsShop.Data;
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

          //  SeedCategories(data);

            return app;
        }
     //
     //   private static void SeedCategories(ApplicationDbContext data)
     //   {
     //       if (!data.IssueTypes.Any())
     //       {
     //
     //           data.IssueTypes.AddRange(new[]
     //           {
     //                  new IssueType { Name = "Engine" ,ImageUrl="https://fcache1.pakwheels.com/original/3X/4/d/4d9606406f5850e351b358bbfe9d3cb91e07c0fe.jpg "},
     //                  new IssueType { Name = "Transmission",ImageUrl="https://www.mediastorehouse.com.au/p/617/modern-car-5-speed-manual-gearbox-cross-section-9596591.jpg " },
     //                  new IssueType { Name = "Diagnostics" ,ImageUrl="https://previews.123rf.com/images/nitroxelmares/nitroxelmares1604/nitroxelmares160400021/55664614-car-diagnostics-test-service-illustration-isolated-on-white.jpg "},
     //                  new IssueType { Name = "Brake system" ,ImageUrl="https://www.anatomynote.com/wp-content/uploads/2019/05/6189/Car-brake-system-diagram.jpg "},
     //                  new IssueType { Name = "Electrical system" ,ImageUrl="https://www.newkidscar.com/wp-content/uploads/2019/04/electrical-system.jpg "},
     //                  new IssueType { Name = "Coupe" ,ImageUrl="https://fs3.ebait.biz/c4RpU5aF/review_337244_1.jpg "},
     //                  new IssueType { Name = "Tires " ,ImageUrl="https://www.napolitan.it/wp-content/uploads/2019/06/pneumatici-4-stagioni-300x260.jpg"},
     //                    new IssueType { Name = "air conditioner" ,ImageUrl=" https://media.istockphoto.com/photos/car-air-conditioner-system-in-car-garage-car-air-conditioner-check-picture-id1179826380"},
     //                    new IssueType { Name = "Technical inspeccion" ,ImageUrl="https://www.theolivepress.es/wp-content/uploads/2020/01/itvvv.jpg?width=1200&enable=upscale"},
     //              });
     //
     //           data.SaveChanges();
     //           //index page:  https://local-auto-locksmith.co.uk/wp-content/uploads/2020/01/5c7e7fc789f49339065587c2-768x459.jpg
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
     //
     //       return;
     //   }
    }
}

   

