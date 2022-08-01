using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace Selenium_Test5
{
    public class Autoit
    {
        AutoItX3 auto = new AutoItX3();

        public void Click(string Clickside, int x, int y, int manyClick, int Speed)
        {
            auto.MouseClick(Clickside, x, y, manyClick, Speed);
        }

    }
}
