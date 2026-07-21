using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTetris.Lib
{
    public interface IShape
    {
        void Draw(int x, int y);

        void Move();

        void Rotate();
    }
}
