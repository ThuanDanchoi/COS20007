using System;
using SplashKitSDK;

namespace Drawing_Program__Saving_and_Loading
{
    public class MyLine : Shape
    {
        private float _endX;
        private float _endY;
        private int _thickness;

        public MyLine(Color color, float endX, float endY, int thickness) : base(color)
        {
            _endX = endX;
            _endY = endY;
            _thickness = thickness;
        }

        public MyLine() : this(Color.Black, 0, 0, 0)
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
                DrawOutline();
            SplashKit.DrawLine(Color, X, Y, _endX, _endY);
        }

        public override void DrawOutline()
        {
             
        }

        public override bool IsAt(Point2D pt)
        {
             
            float minX = Math.Min(X, _endX) - _thickness / 2;
            float minY = Math.Min(Y, _endY) - _thickness / 2;
            float maxX = Math.Max(X, _endX) + _thickness / 2;
            float maxY = Math.Max(Y, _endY) + _thickness / 2;

             
            return pt.X >= minX && pt.X <= maxX && pt.Y >= minY && pt.Y <= maxY;
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Line");
            base.SaveTo(writer);
            writer.WriteLine(EndX);
            writer.WriteLine(EndY);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            EndX = reader.ReadInteger();
            EndY = reader.ReadInteger();
        }
    }
}


