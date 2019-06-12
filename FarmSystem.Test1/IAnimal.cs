﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem.Test1
{
    interface IAnimal
    {
        string Id { get; set; }
        int NoOfLegs { get; set; }
        //void Talk();
        void Walk();
        void Run();
    }
}
