using System;
using SplashKitSDK;

namespace MultipleShape
{
    public class MyLine : Shape
    {
        private float _endX;
        private float _endY;
        private int _thickness;

        public MyLine(Color color, float startX, float startY, float endX, float endY, int thickness) : base(color)
        {
            X = startX;  
            Y = startY;  
            _endX = endX;  
            _endY = endY;  
            _thickness = thickness;  
        }

        public MyLine() : this(Color.Black, 0, 0, 0, 0, 2)
        {
            
        }

        public float EndX
        {
            get { return _endX; }
            set { _endX = value; }
        }

        public float EndY
        {
            get { return _endY; }
            set { _endY = value; }
        }

        public int Thickness
        {
            get { return _thickness; }
            set { _thickness = value; }
        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();  
            }
            SplashKit.DrawLine(Color, X, Y, _endX, _endY);  
        }

        public override void DrawOutline()
        {
             
            float radius = _thickness * 5f;  
            SplashKit.FillCircle(Color.Red, X, Y, radius);  
            SplashKit.FillCircle(Color.Red, _endX, _endY, radius);  
        }

        public override bool IsAt(Point2D pt)
        {
             
            float minX = Math.Min(X, _endX) - _thickness / 2;
            float minY = Math.Min(Y, _endY) - _thickness / 2;
            float maxX = Math.Max(X, _endX) + _thickness / 2;
            float maxY = Math.Max(Y, _endY) + _thickness / 2;

            return pt.X >= minX && pt.X <= maxX && pt.Y >= minY && pt.Y <= maxY;
        }
    }
}
