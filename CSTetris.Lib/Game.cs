using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTetris.Lib
{
    public class Game
    {
        public Game()
        {

        }

        public void Start()
        {
            Field field = new Field(20, 10, 5, 5);
            field.DrawField();
        }


    }
}
