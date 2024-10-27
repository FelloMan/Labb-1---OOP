namespace Labb_1___OOP
{ 
        public class Circle
        {
            public float _pi = 3.141f;
            public int _Radius;

            public Circle(int radie)
            {
                this._Radius = radie;

            }

            public float getArea()
            {
                float result = _Radius * _Radius * _pi;
                return result;

            }
        }

 }

