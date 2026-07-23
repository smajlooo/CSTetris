using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTetris.Lib
{

    /*      Smashboy
     * 
     *      [][]
     *      [][]
     * 
     */

    public class Smashboy : IShape
    {
        public Smashboy() { }

        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine();
        }

        public void Move(int x, int y)
        {

        }

        public void Rotate(int x, int y)
        {

        }
    }
}
