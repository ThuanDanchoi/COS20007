using System;
using SplashKitSDK;

namespace DrawingShape
{
    public class Program
    {
        public static void Main()
        {
            Window window = new Window("Drawing Shape", 800, 600);
            Drawing myDrawing = new Drawing();
            do
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape s = new Shape();
                    s.X = SplashKit.MouseX();
                    s.Y = SplashKit.MouseY();
                    myDrawing.AddShape(s);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SplashKit.RandomRGBColor(255);
                }


                if (SplashKit.MouseClicked(MouseButton.RightButton)) 
                {
                    myDrawing.SelectShapesAt(SplashKit.MousePosition());   
                }

                if (SplashKit.KeyDown(KeyCode.DeleteKey)||SplashKit.KeyDown(KeyCode.BackspaceKey))
                {
                    foreach(Shape s in myDrawing.SelectedShapes)
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
