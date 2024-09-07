using System;
using SplashKitSDK;

namespace MultipleShape
{
	public class MyCircle : Shape
	{
        private int _radius;

        public MyCircle(Color color, float x, float y, int radius) : base(color)
        {
            X = x;
            Y = y;
            _radius = radius;
		}

        public MyCircle() : this(Color.Blue, 0, 0, 50)
        {

        }

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override void Draw()
        {
            SplashKit.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            
            SplashKit.FillCircle(Color.Black, X, Y, _radius + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            double dX = pt.X - X;
            double dY = pt.Y - Y;
            double distance = System.Math.Sqrt(dX * dX + dY * dY);

            return distance <= _radius;
        }
    }
}

