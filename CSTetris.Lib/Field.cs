using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTetris.Lib
{
    internal class Field
    {
        int _width = 0;
        int _height = 0;

        int _startX = 0;
        int _startY = 0;

        char border = '#';
        
        public Field(int width, int height, int startX, int startY)
        {
            _width = width * 2;
            _height = height * 2;

            _startX = startX;
            _startY = startY;
        }

        public void DrawField()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for(int i = 0; i < _height; i++)
            {
                Console.SetCursorPosition(_startX, _startY + i);
                Console.WriteLine(border);
                Console.SetCursorPosition(_startX + _width, _startY + i);
                Console.WriteLine(border);
            }

            for(int i = 0; i <= _width; i++)
            {
                Console.SetCursorPosition(_startX + i, _startY + _height);
                Console.WriteLine(border);
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
