﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlleur.Entity.Cuisine.Personnel
{
    public abstract class PersonnelCuisine
    {
        protected int Id { get; set; }

        public PersonnelCuisine(int id)
        {
            this.Id = id;
        }
    }
}
