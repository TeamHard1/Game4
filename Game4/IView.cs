using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game4
{
    internal interface IView
    {
        void SetInFild(int i,  int j);

        void PaintShape(int i, int j);
    }
}
