using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuizzyApp.Models
{
    public class Category
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public bool IsFavorite { get; set; }

        public Category(string name, string image, bool isFavorite)
        {
            Name = name;
            Image = image;
            IsFavorite = isFavorite;
        }
    
    }
}
