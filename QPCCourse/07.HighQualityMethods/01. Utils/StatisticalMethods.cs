// <copyright file="StatisticalMethods.cs" company="Telerik Academy">
// Telerik academy homework task 01 from lecture 07. HighQualityMethods 
// </copyright>
namespace Methods
{
    using System;

    /// <summary>
    /// Contains some frequently used statistical methods.
    /// </summary>
    public static class StatisticalMethods
    {
        /// <summary>
        /// Returns the maximum value in the sequence of values 
        /// passed as arguments.
        /// </summary>
        /// <param name="args">Keeps a variable number of arguments.</param>
        /// <returns>The maximum value in the sequence.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown when
        /// null has been passed as an argument.</exception>
        /// <exception cref="System.ArgumentException">Thrown when
        /// no arguments have been specified or an array with length of zero
        /// has been passed.</exception>
        public static int Max(params int[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException("args is null.");
            }

            if (args.Length == 0)
            {
                throw new ArgumentException("No arguments specified.");
            }

            int max = int.MinValue;

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] > max)
                {
                    max = args[i];
                }
            }

            return max;
        }
    }
}
