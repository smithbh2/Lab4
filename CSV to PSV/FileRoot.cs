﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_PSV
{
    internal class FileRoot
    {
        public static string Root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}
