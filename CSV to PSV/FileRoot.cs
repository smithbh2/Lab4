///////////////////////////////////////////////////////////////////////
///
/// Author:         Ben Smith
/// Course:         Server Side Web Programming 
/// Assignment:     Lab 4
/// Description:    A file to acquire the root folder of the program.
/// 
///////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_PSV
{
    /// <summary>
    /// The class used to obtain and store the path to the root of the program.
    /// </summary>
    internal class FileRoot
    {
        public static string Root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}
