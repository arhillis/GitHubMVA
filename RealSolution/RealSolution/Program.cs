using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace RealSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new HtmlDocument();
            doc.Load("../../index.html");
        }
    }
}
