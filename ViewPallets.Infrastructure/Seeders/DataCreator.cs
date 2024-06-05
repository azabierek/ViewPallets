using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewPallets.Domain.Entities;

namespace ViewPallets.Infrastructure.Seeders
{
    internal static class DataCreator
    {
        internal static List<Pallet> CreatePalletsRange()
        {
            List<Pallet> range = new List<Pallet>();
            range.Add(new Pallet()
            {
                CreatedAt = DateTime.Now,
                Height = 1500,
                Length = 2800,
                Width = 1350,
                Weight = 274,
                CustomerName = "HONDA GDAŃSK",
                ProjectId = "HON-102",
                ProjectName = "MAIN ORDER",
                Details = CreateFirstDetailsList()
            });
            range.Add(new Pallet()
            {
                CreatedAt = DateTime.Now,
                Height = 2000,
                Length = 2000,
                Width = 1050,
                Weight = 155,
                CustomerName = "SUZUKI GDYNIA",
                ProjectId = "SUZ-223",
                ProjectName = "SUZ ORDER 22",
                Details = CreateSecondDetailsList()
            });

            return range;
        }
        private static List<Details> CreateFirstDetailsList()
        {
            var resultList = new List<Details>();

            resultList.Add(new Details()
            {
                ItemName = "Chain lube",
                Quantity = 1
            });
            resultList.Add(new Details()
            {
                ItemName = "Brake disc",
                Quantity = 2
            });
            resultList.Add(new Details()
            {
                ItemName = "Brake pads",
                Quantity = 2
            });
            resultList.Add(new Details()
            {
                ItemName = "Motorcycle frame",
                Quantity = 1
            });

            return resultList;
        }

        private static List<Details> CreateSecondDetailsList()
        {
            var resultList = new List<Details>();

            resultList.Add(new Details()
            {
                ItemName = "Wind shield",
                Quantity = 22
            });
            resultList.Add(new Details()
            {
                ItemName = "Wheel",
                Quantity = 2
            });

            return resultList;
        }
    }
}
