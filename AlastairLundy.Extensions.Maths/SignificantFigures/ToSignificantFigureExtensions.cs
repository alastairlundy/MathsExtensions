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

using System.Globalization;

namespace AlastairLundy.Extensions.Maths.SignificantFigures
{
    public static class ToSignificantFigureExtensions
    {
        /// <summary>
        /// Insert or remove Significant Figures as needed to reach the required number of significant figures. 
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <param name="numberOfSignificantFigures">The number of significant figures to return the specified value to.</param>
        /// <returns>the specified value to the specified number of significant figures.</returns>
        public static string ToNSignificantFigures(this double value, int numberOfSignificantFigures)
        {
            return value.ToString($"G{numberOfSignificantFigures}", CultureInfo.InvariantCulture);
        }
        
        /// <summary>
        /// Insert or remove Significant Figures as needed to reach the required number of significant figures. 
        /// </summary>
        /// <param name="value">The value to be checked.</param>
        /// <param name="numberOfSignificantFigures">The number of significant figures to return the specified value to.</param>
        /// <returns>the specified value to the specified number of significant figures.</returns>
        public static string ReturnToNSignificantFigures(this decimal value, int numberOfSignificantFigures)
        {
            return value.ToString($"G{numberOfSignificantFigures}", CultureInfo.InvariantCulture);
        }
    }
}