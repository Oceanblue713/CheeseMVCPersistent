﻿using System.Collections.Generic;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public CheeseType Type { get; set; }

        public int CategoryID { get; set; }
        public CheeseCategory Category { get; set; }

        //Part 3
        public List<CheeseMenu> CheeseMenus { get; set; }

    }
}
