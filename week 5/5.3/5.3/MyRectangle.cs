using System;
using SplashKitSDK;

namespace Drawing_Program__Saving_and_Loading
{
	public class MyRectangle : Shape
	{
		private int _width;
		private int _height;

		public MyRectangle(Color color, float x, float y, int width, int height) : base(color)
		{
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }

        public MyRectangle() : this(Color.Green, 0, 0, 100, 100)
        {

        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
		{
            get { return _height; }
            set { _height = value; }
        }

        public override void Draw()
        {
            SplashKit.FillRectangle(Color, X, Y, Width, Height);
        }

        public override void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, X, Y, Width + 2, Height + 2);
        }

        public override bool IsAt(Point2D pt)
        {
            return pt.X >= X && pt.X <= X + Width && pt.Y >= Y && pt.Y <= Y + Height;
        }

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Rectangle"); 
            base.SaveTo(writer); 
            writer.WriteLine(Width); 
            writer.WriteLine(Height); 
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            Width = reader.ReadInteger();
            Height = reader.ReadInteger();
        }
    }
}

