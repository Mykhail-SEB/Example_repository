using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Practic_8_WPF
{
    public abstract class Shape
    {
        float _length;
        public float length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public Shape(){}
        public Shape(float length)
        {
            _length = length;
        }
        public abstract float Area();
    }


    public class Triangle : Shape
    {
        float _height;
        public float height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public Triangle() : base(){}
        public Triangle(float height, float length) : base(length)
        {
            this.height = height;
        }
        public override string ToString()
        {
            return "Triangle with length of " + length + " and height of " + height;
        }
        public override float Area()
        {
            float area = height * length / 2;
            return area;
        }
    }


    public class Square : Shape
    {
        public Square() : base(){}
        public Square(float length) : base(length){}
        public override string ToString()
        {
            return "Square with sides of " + length;
        }
        public override float Area()
        {
            float area = length*length;
            return area;
        }
    }
}
