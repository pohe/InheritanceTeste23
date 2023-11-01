using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTeste23
{
    public interface IGeometryDraw
    {
        void DrawCircle(int x, int y, int r);
        void DrawLine(int x, int y, int x1, int y1);

        int CalculateArea();
    }
}
