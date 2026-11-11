using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurant(int id, string name, string type, double rating)
        {
            Id = id;
            Name = name;
            Type = type;
            Rating = rating;
        }
    }
}
namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            };


            restaurants.Add(new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2));
            restaurants.Add(new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8));

            Console.WriteLine("--- รายชื่อร้านอาหารทั้งหมด ---");
            foreach (var item in restaurants)
            {
                Console.WriteLine($"[{item.Id}] {item.Name,-22} | ประเภท: {item.Type,-18} | คะแนน: {item.Rating}/5.0");
            }
            int totalCount = restaurants.Count;
            double avgRating = restaurants.Average(r => r.Rating);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"จำนวนร้านอาหารทั้งหมด : {totalCount} ร้าน");
            Console.WriteLine($"คะแนนเฉลี่ยของทุกร้าน   : {avgRating:F2} / 5.0");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("\nกดปุ่มใดก็ได้เพื่อออกจากโปรแกรม...");
            Console.ReadKey();
        }
    }
}