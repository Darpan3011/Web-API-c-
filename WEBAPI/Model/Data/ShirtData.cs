using System.Drawing;

namespace WEBAPI.Model.Data
{
    public static class ShirtData
    {
        private static List<Shirt> shirtList = new List<Shirt>() {
            new Shirt { ShirtId=1, Brand="darpan1", Color="Bluee1", Gender="Men", Price=30, Size=10 },
            new Shirt { ShirtId=2, Brand="darpan2", Color="Bluee2", Gender="Men", Price=35, Size=10 },
            new Shirt { ShirtId=3, Brand="darpan3", Color="Bluee3", Gender="Men", Price=36, Size=10 },
            new Shirt { ShirtId=4, Brand="darpan4", Color="Bluee4", Gender="Men", Price=38, Size=10 },
            new Shirt { ShirtId=5, Brand="darpan5", Color="Bluee5", Gender="Men", Price=38, Size=10 }
        };

        public static List<Shirt> getAllShirts()
        {
            return shirtList;
        }

        public static bool isShirtThere(int id)
        {
            return shirtList.Any(x=>x.ShirtId == id);
        }

        public static Shirt? returnShirt(int id)
        {
            return shirtList.FirstOrDefault(x => x.ShirtId == id);
        }

        public static Shirt getShirtById(string? b, string? c, string? g, int? s)
        {
            return shirtList.FirstOrDefault(x =>
            x.Brand.Equals(b, StringComparison.OrdinalIgnoreCase) &&
            x.Color.Equals(c, StringComparison.OrdinalIgnoreCase) &&
            x.Gender.Equals(g, StringComparison.OrdinalIgnoreCase) &&
            x.Size == s);
        }

        public static void AddShirt(Shirt shirt)
        {
            int max = shirtList.Max(x => x.ShirtId);
            shirt.ShirtId = max + 1;

            shirtList.Add(shirt);
        }
    }
}
