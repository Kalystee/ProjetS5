﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlleur.Entity.Interface;

namespace Controlleur.Entity.Cuisine.Machines
{
    public class MachineALaver : Machine, ILaver
    {
        public MachineALaver(int id, string nom) : base(id, nom)
        {
        }

        public void Laver()
        {
            throw new NotImplementedException();
        }

        public bool Recharger()
        {
            throw new NotImplementedException();
        }
    }
}