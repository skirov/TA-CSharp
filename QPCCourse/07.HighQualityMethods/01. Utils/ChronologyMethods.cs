// <copyright file="ChronologyMethods.cs" company="Telerik Academy">
// Telerik academy homework task 01 from lecture 07. HighQualityMethods 
// </copyright>
namespace Methods
{
    using System;

    /// <summary>
    /// Contains methods extending those defined in the struct <see cref="System.DateTime"/>.
    /// </summary>
    public static class ChronologyMethods
    {
        /// <summary>
        /// Checks if the value of this instance is earlier than the specified <see cref="System.DateTime"/> value.
        /// </summary>
        /// <param name="thisValue">The(this) instance to extend.</param>
        /// <param name="value">The object to compare to the current instance.</param>
        /// <returns>True if this instance is earlier than <paramref name="value"/>, otherwise - false.</returns>
        public static bool IsEarlierThan(this DateTime thisValue, DateTime value)
        {
            return thisValue < value;
        }
    }
}
