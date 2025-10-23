using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorExamles
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Mover m=new Mover();
            m.Area(5);
            m.Area(5, 3);
            m.Area(5.6);
        }
    }
}
