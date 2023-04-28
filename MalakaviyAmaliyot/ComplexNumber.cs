using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalakaviyAmaliyot
{
    public struct ComplexNumber
    {
        private double real;
        private double imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        /// <summary>
        /// The real part of the complex number.
        /// </summary>
        public double Real => real;
        /// <summary>
        /// The imaginary part of the complex number.
        /// </summary>
        public double Imaginary => imaginary;

        /// <summary>
        /// The distance from the origin to the point representing the complex number in the complex plane.
        /// </summary>
        public double Radius => Math.Sqrt(real * real + imaginary * imaginary);
        /// <summary>
        /// Computes summ of two complex numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real + b.real, a.imaginary + b.imaginary);
        }
        /// <summary>
        /// Comutes difference of two complex numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real - b.real, a.imaginary - b.imaginary);
        }
        /// <summary>
        /// Computes product of two complex numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + a.imaginary * b.real);
        }

        public static ComplexNumber operator !(ComplexNumber a)
        {
            return new ComplexNumber(a.real, -a.imaginary);
        }

        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            return a * !b;
        }

        override public string ToString()
        {
            return $"{real} + {imaginary}i";
        }

    }
}
