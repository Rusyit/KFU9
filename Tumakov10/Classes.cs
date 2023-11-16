using System;

namespace Tumakov10
{
    class ACipher : ICipher
    {

        private string Mes1;
        private string Mes2;

        public string Mes
        {
            get
            {
                if (Mes1 != "")
                {
                    return Mes1;
                }
                else
                {
                    return Mes2;
                }
            }
        }

        public bool Encode()
        {
            if (Mes2 == "" && Mes1 != "")
            {
                for (int i = 0; i < Mes1.Length; i++)
                {
                    if (Char.IsLetter(Mes1[i]))
                    {
                        if (Mes1.ToLower()[i] == 'я')
                        {
                            Mes2 += Char.IsUpper(Mes1[i]) ? 'A' : 'a';
                        }
                        else if (Mes1.ToLower()[i] == 'z')
                        {
                            Mes2 += Char.IsUpper(Mes1[i]) ? 'A' : 'a';
                        }
                        else
                        {
                            Mes2 += (char)((int)Mes1[i] + 1);
                        }
                    }
                    else
                    {
                        Mes2 += Mes1[i];
                    }
                }

                Mes1 = "";
                return true;
            }

            return false;
        }

        public bool Decode()
        {
            if (Mes2 != "" && Mes1 == "")
            {
                for (int i = 0; i < Mes2.Length; i++)
                {
                    if (Char.IsLetter(Mes2[i]))
                    {
                        if (Mes2.ToLower()[i] == 'a')
                        {
                            Mes1 += Char.IsUpper(Mes2[i]) ? 'Z' : 'z';
                        }
                        else if (Mes2.ToLower()[i] == 'а')
                        {
                            Mes1 += Char.IsUpper(Mes2[i]) ? 'Я' : 'я';
                        }
                        else
                        {
                            Mes1 += (char)((int)Mes2[i] - 1);
                        }
                    }
                    else
                    {
                        Mes1 += Mes2[i];
                    }
                }

                Mes2 = "";
                return true;
            }

            return false;
        }

        public ACipher(string Mes1)
        {
            this.Mes1 = Mes1;
            Mes2 = "";
        }
    }

    class BCipher : ICipher
    {

        private string Mes1;
        private string Mes2;

        public string Mes
        {
            get
            {
                if (Mes1 != "")
                {
                    return Mes1;
                }
                else
                {
                    return Mes2;
                }
            }
        }

        public bool Encode()
        {
            if (Mes2 == "" && Mes1 != "")
            {
                for (int i = 0; i < Mes1.Length; i++)
                {
                    char newLetter;

                    if (Char.IsLetter(Mes1[i]))
                    {
                        if (Mes1.ToLower()[i] >= 'а' && Mes1.ToLower()[i] <= 'я')
                        {
                            newLetter = (char)((int)'я' - ((int)Mes1.ToLower()[i] - (int)'а'));
                        }
                        else
                        {
                            newLetter = (char)((int)'z' - ((int)Mes1.ToLower()[i] - (int)'a'));
                        }

                        if (Char.IsUpper(Mes1[i]))
                        {
                            Mes2 += newLetter.ToString().ToUpper();
                        }
                        else
                        {
                            Mes2 += newLetter;
                        }
                    }
                    else
                    {
                        Mes2 += Mes1[i];
                    }
                }

                Mes1 = "";
                return true;
            }

            return false;
        }

        public bool Decode()
        {
            if (Mes2 != "" && Mes1 == "")
            {
                for (int i = 0; i < Mes2.Length; i++)
                {
                    char newLetter;

                    if (Char.IsLetter(Mes2[i]))
                    {
                        if (Mes2.ToLower()[i] >= 'а' && Mes2.ToLower()[i] <= 'я')
                        {
                            newLetter = (char)(((int)'я' - (int)Mes2.ToLower()[i]) + (int)'а');
                        }
                        else
                        {
                            newLetter = (char)(((int)'z' - (int)Mes2.ToLower()[i]) + (int)'a');
                        }

                        if (Char.IsUpper(Mes2[i]))
                        {
                            Mes1 += newLetter.ToString().ToUpper();
                        }
                        else
                        {
                            Mes1 += newLetter;
                        }
                    }
                    else
                    {
                        Mes1 += Mes1[i];
                    }
                }

                Mes2 = "";
                return true;
            }

            return false;
        }

        public BCipher(string Mes1)
        {
            this.Mes1 = Mes1;
            Mes2 = "";
        }
    }

    enum State
    {
        Видимое,
        Невидимое
    }
    enum Color
    {
        Красный,
        Синий,
        Зеленый,
        Черный
    }
    internal abstract class Figure : Ipok, IColor, IState
    {
        protected Color color;
        public Color Color
        {
            get
            {
                return color;
            }
        }
        protected State state;
        public State State
        {
            get
            {
                return state;
            }
        }
        public Figure(Color color, State state)
        {
            this.color = color;
            this.state = state;
        }

        public abstract Coordinates Vert(int distance);
        public abstract Coordinates Horiz(int distance);
        public Color ChangeColor(Color new_color)
        {
            color = new_color;
            return color;
        }
        public State ChangeState(State new_state)
        {
            state = new_state;
            return state;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Цвет фигуры {color}, состояние {state} ");
        }
    }

    internal class Circle : Point
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
        }
        public Circle(Color color, State state, Coordinates coordinates, double radius) : base(color, state, coordinates)
        {
            this.radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Радиус: {radius}, Площадь: {CalculateArea()}");
        }
    }

    struct Coordinates
    {
        private int x;
        private int y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
    internal class Point : Figure
    {
        protected Coordinates coordinates;
        public Coordinates Coordinates
        {
            get
            {
                return coordinates;
            }
        }
        public Point(Color color, State state, Coordinates coordinates) : base(color, state)
        {
            this.coordinates = coordinates;
        }
        public override Coordinates Vert(int distance)
        {
            coordinates.Y += distance;
            return coordinates;
        }
        public override Coordinates Horiz(int distance)
        {
            coordinates.X += distance;
            return coordinates;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Координаты: ({coordinates.X}, {coordinates.Y}) ");
        }
    }

    internal class Rectangle : Point
    {
        private double wight, height;
        public double Wight
        {
            get
            {
                return wight;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
        }
        public Rectangle(Color color, State state, Coordinates coordinates, double wight, double height) : base(color, state, coordinates)
        {
            this.wight = wight;
            this.height = height;
        }
        public double CalculateArea()
        {
            return wight * height;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Длина: {wight}, Высота: {height}, Площадь: {CalculateArea()}");
        }

    }
}
