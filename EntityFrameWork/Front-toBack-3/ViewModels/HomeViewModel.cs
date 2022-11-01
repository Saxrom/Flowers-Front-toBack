using System;
using Front_toBack_3.Models;

namespace Front_toBack_3.ViewModels
{
    public class HomeViewModel
    {
        public List<SliderImage> SliderImages { get; set; } = new List<SliderImage>();

        public Slider? Slider { get; set; }

        public List<Category> Categories { get; set; } = new List<Category>();

        public List<Product> Products { get; set; } = new List<Product>();

        public List<Logo> Logos { get; set; } = new List<Logo>();

    }
}

