namespace RefactorStatistics
{
    using System;

    public static class Statistics
    {
        /// <summary>
        /// Returns the maximum value in the array.
        /// </summary>
        /// <param name="array">A sequence of values to determine the maximum value from.</param>
        /// <returns>The maximum value in the array sequence.</returns>
        public static double Max(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Sequence is null.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Sequence contains no elements.");
            }

            double max = double.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Returns the minimum value in the array.
        /// </summary>
        /// <param name="array">A sequence of values to determine the minimum value from.</param>
        /// <returns>The minimum value in the array sequence.</returns>
        public static double Min(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Sequence is null.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("Sequence contains no elements.");
            }

            double min = double.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Computes the average of a sequence of values.
        /// </summary>
        /// <param name="array">A sequence of values to determine the average value from.</param>
        /// <returns>The average value of the elements in the sequence.</returns>
        public static double Average(double[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Sequence is null.");
            }

            int arrayLength = array.Length;

            if (arrayLength == 0)
            {
                throw new ArgumentException("Sequence contains no elements.");
            }

            double sum = 0;

            for (int i = 0; i < arrayLength; i++)
            {
                sum += array[i];
            }

            double average = sum / arrayLength;
            return average;
        }
    }
}
