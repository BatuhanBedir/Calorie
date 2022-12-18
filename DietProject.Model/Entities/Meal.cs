﻿using DietProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietProject.Model.Entities
{
    public class Meal : BaseEntity
    {
        public string MealName { get; set; }

        //navigation

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

        public Meal()
        {
            Users=new HashSet<User>();
            Foods=new HashSet<Food>();
        }
    }
}
