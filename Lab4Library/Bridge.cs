using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Library
{
    public interface IRenderer
    {
        void Render();
    }
    public abstract class Shape
    {
        protected IRenderer? renderer;
        public Shape(IRenderer? renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }
    public class Circle : Shape
    {
        public Circle(IRenderer? renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            Console.Write("Drawing Circle ");
            renderer?.Render();
        }
    }
    public class Square : Shape
    {
        public Square(IRenderer? renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            Console.Write("Drawing Square ");
            renderer?.Render();
        }
    }
    public class Triangle : Shape
    {
        public Triangle(IRenderer? renderer) : base(renderer)
        {
        }

        public override void Draw()
        {
            Console.Write("Drawing Triangle ");
            renderer?.Render();
        }
    }
    public class VectorRenderer : IRenderer
    {
        public void Render()
        {
            Console.WriteLine("as vectors.");
        }
    }
    public class RasterRenderer : IRenderer
    {
        public void Render()
        {
            Console.WriteLine("as pixels.");
        }
    }
}
