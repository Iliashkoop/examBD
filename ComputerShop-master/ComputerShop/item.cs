﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShop
{
    internal class item
    {
        public int? id {  get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int? cost { get; set; }
        public int? maxCost { get; set; }
    }
}
