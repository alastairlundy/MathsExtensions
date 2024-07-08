﻿/*
        MIT License
       
       Copyright (c) 2024 Alastair Lundy
       
       Permission is hereby granted, free of charge, to any person obtaining a copy
       of this software and associated documentation files (the "Software"), to deal
       in the Software without restriction, including without limitation the rights
       to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
       copies of the Software, and to permit persons to whom the Software is
       furnished to do so, subject to the following conditions:
       
       The above copyright notice and this permission notice shall be included in all
       copies or substantial portions of the Software.
       
       THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
       IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
       FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
       AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
       LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
       OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
       SOFTWARE.
   */

namespace AlastairLundy.Extensions.Maths.Powers;

    public static class RootExtensions
    {
        /// <summary>
        ///  Returns the Nth Root of a value.
        /// </summary>
        /// <param name="value">The value to get the Nth root of.</param>
        /// <param name="n">The root</param>
        /// <returns>the Nth root of the specified value.</returns>
        public static float Root(this float value, float n)
        {
            return value.Power(Convert.ToSingle(1.0 / n));
        }
        
        /// <summary>
        /// Returns the Nth root of a specified value.
        /// </summary>
        /// <param name="value">The value to calculate the Nth root of.</param>
        /// <param name="n">The Nth root to be calculated.</param>
        /// <returns>the Nth root of the specified value.</returns>
        public static double Root(this double value, double n)
        {
            return value.Power(1.0 / n);
        }
        
        /// <summary>
        /// Returns the Nth Root of a value.
        /// </summary>
        /// <param name="value">The value to get the Nth root of.</param>
        /// <param name="n">The Nth root.</param>
        /// <returns>the Nth root of the specified value.</returns>
        public static decimal Root(this decimal value, decimal n)
        {
            return value.Power(decimal.Divide(decimal.One, n));
        }
    }