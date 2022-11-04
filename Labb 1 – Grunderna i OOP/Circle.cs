using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1___Grunderna_i_OOP
{
    public class Circle
    {
        float _pi = 3.141f;
        int _Radius;

        public Circle(int Radius)
        {
            _Radius = Radius;
        }
        public float GetArea()
        {
            return _Radius * _Radius * _pi;
        }
    }



    

}
