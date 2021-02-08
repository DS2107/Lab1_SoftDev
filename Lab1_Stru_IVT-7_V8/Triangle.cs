/*
    В Production Code написать класс Triangle с методом double Area(), который вычисляет
площадь треугольника. Стороны могут быть заданы как в методе SetSides(double a,
double b, double c), так и в параметризированном конструкторе; при этом если одна из
сторон задана отрицательной, бросается исключение FormatException; если стороны не
могут образовать треугольник, то бросается исключение ArgumentException. В Test Code
написать тесты, которые проверяют соответствие результатов метода спецификации
требований.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1_Stru_IVT_7
{
    /// <summary>
    /// Класс Triangle Который вычисляет площадь треугольника
    /// </summary>
    public class Triangle
    {
        // Стороны
        private double a, b, c;
        /// <summary>
        /// Конструктор класса Triangle
        /// </summary>
        /// <param name="a">Сторона а</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона с</param>
        public Triangle(double a, double b , double c)
        {
            SetSides(a, b, c);
        } 

        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Triangle()
        {

        } // Triangle


        /// <summary>
        /// Метод который устанавливает все стороны 
        /// </summary>
        /// <param name="a">Сторона а</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c"> Сторона с</param>
        public void SetSides (double a, double b, double c)
        {
            if (Revise(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            } //if
        } // SetSides

        /// <summary>
        /// Метод который находит площадь треуголника по формуле Герона
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            // Периметр
            double P = (a + b + c) / 2;

            // Формула Герона
            // sqrt p*(p-a)*(p-b)*(p-c)
            // Если получим число с плавающей запятой то окурглим до ближайшего целого 
            return Math.Round(Math.Sqrt(P * (P - a) * (P - b) * (P - c)),1);

        } // Area

        public bool Revise(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new FormatException("Стороны не должны быть отрицательными");
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Не удается образовывать треугольник");
            return true;
        } // Revise
    }
}











































