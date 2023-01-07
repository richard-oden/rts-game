using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace rts_game
{
    public static class Renderer
    {
        private static int _windowWidth = 150;
        private static int _windowHeight = 40;

        public static void Setup()
        {
            CursorVisible = false;
            SetWindowSize(_windowWidth, _windowHeight);
            SetBufferSize(_windowWidth, _windowHeight);
            DrawBorders();
        }

        public static void DrawBorders()
        {
            static void DrawHorizontalBorder(int y)
            {
                for (var x = 1; x < _windowWidth - 1; x++)
                {
                    SetCursorPosition(x, y);
                    Write('═');
                }
            }

            static void DrawVerticalBorder(int x)
            {
                for (var y = 1; y < _windowHeight - 1; y++)
                {
                    SetCursorPosition(x, y);
                    Write('║');
                }
            }

            DrawHorizontalBorder(0);
            DrawHorizontalBorder(_windowHeight - 1);
            DrawVerticalBorder(0);
            DrawVerticalBorder(_windowWidth - 1);

            SetCursorPosition(0, 0);
            Write('╔');

            SetCursorPosition(_windowWidth - 1, 0);
            Write('╗');

            SetCursorPosition(0, _windowHeight - 1);
            Write('╚');

            SetCursorPosition(_windowWidth - 1, _windowHeight - 1);
            Write('╝');
        }
    }
}
