using System;
using SplashKitSDK;

namespace MultipleShape
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line  
        }

        public static void Main()
        {
            Window window = new Window("Multiple Shape", 800, 600);
            Drawing myDrawing = new Drawing();

            ShapeKind kindToAdd = ShapeKind.Circle;
            do
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;
                    switch (kindToAdd)
                    {
                        case ShapeKind.Circle:
                            newShape = new MyCircle();
                            newShape.X = SplashKit.MouseX();
                            newShape.Y = SplashKit.MouseY();
                            myDrawing.AddShape(newShape);
                            break;

                        case ShapeKind.Rectangle:
                            newShape = new MyRectangle();
                            newShape.X = SplashKit.MouseX();
                            newShape.Y = SplashKit.MouseY();
                            myDrawing.AddShape(newShape);
                            break;

                        case ShapeKind.Line:  
                            newShape = new MyLine();
                            newShape.X = SplashKit.MouseX();
                            newShape.Y = SplashKit.MouseY();
                            myDrawing.AddShape(newShape);
                            break;
                    }
                }

                if (SplashKit.KeyDown(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle; // Press 'R' to draw rectangles
                }

                if (SplashKit.KeyDown(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle; // Press 'C' to draw circles
                }

                if (SplashKit.KeyDown(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line; // Press 'L' to draw lines và thêm dấu chấm phẩy
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyDown(KeyCode.DeleteKey) || SplashKit.KeyDown(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in myDrawing.SelectedShapes)
                    {
                        myDrawing.RemoveShape(s);
                    }
                }
                myDrawing.Draw();

                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }
}
