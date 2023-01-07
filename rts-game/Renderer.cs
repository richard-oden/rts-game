using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace rts_game
{
    public static partial class Renderer
    {
        private static readonly int _windowWidth = 150;
        private static readonly int _windowHeight = 30;
        private static readonly int _rightPaneXLevel = 111;

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
                    Write(_borderH);
                }
            }

            static void DrawVerticalBorder(int x)
            {
                for (var y = 1; y < _windowHeight - 1; y++)
                {
                    SetCursorPosition(x, y);
                    Write(_borderV);
                }
            }

            DrawHorizontalBorder(0);
            DrawHorizontalBorder(_windowHeight - 1);
            DrawVerticalBorder(0);
            DrawVerticalBorder(_windowWidth - 1);
            DrawVerticalBorder(_rightPaneXLevel);

            SetCursorPosition(0, 0);
            Write(_borderTL);

            SetCursorPosition(_windowWidth - 1, 0);
            Write(_borderTR);

            SetCursorPosition(0, _windowHeight - 1);
            Write(_borderBL);

            SetCursorPosition(_windowWidth - 1, _windowHeight - 1);
            Write(_borderBR);

            SetCursorPosition(_rightPaneXLevel, 0);
            Write(_borderHIntersectB);

            SetCursorPosition(_rightPaneXLevel, _windowHeight - 1);
            Write(_borderHIntersectT);
        }
    }
}
