using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
{
    public class Garden
    {
        public string Address { get; set; }
        public string Owner { get; set; }
        private List<Flower> Flowers = new List<Flower>();

        public Garden(string address, string owner)
        {
            Address = address;
            Owner = owner;

        }
        public void AddFlower(Flower flower)
        {
            Flowers.Add(flower);
        }
        public void ShowAll()
        {
            Console.WriteLine($"Информация о саде:\n" +
                $"Адрес: {Address}\n\n" +
                $"Владелец: {Owner}\n" + "Цветы:");
            Flowers.Sort();
            foreach (Flower p in Flowers)
            {
                p.Show();
            }
        }
    }
    namespace GardenLibrary3
    {
        public class Flower : IComparable<Flower>
        {
            public string Title { get; set; }
            public string Description { get; set; }

            public Flower(string title, string description)
            {
                Title = title;
                Description = description;
            }
            public void Show()
            {
                Console.WriteLine($"Название: {Title}\n" +
                    $"- Описание: {Description}\n");
            }
            public int CompareTo(Flower other)
            {
                return Title.CompareTo(other.Title);
            }
        }
    }
}