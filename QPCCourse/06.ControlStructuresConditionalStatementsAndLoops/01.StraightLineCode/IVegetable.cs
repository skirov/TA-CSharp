// <copyright file="IVegetable.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace Kitchen
{
    /// <summary>
    /// Provides information about the vegetable - is it fresh, peeled or cut.
    /// </summary>
    public interface IVegetable
    {
        /// <summary>
        /// Gets or sets a value indicating whether the vegetable is peeled.
        /// </summary>
        bool IsPeeled 
        {
            get; 
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the vegetable is fresh.
        /// </summary>
        bool IsFresh
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the vegetable is cut.
        /// </summary>
        bool IsCut
        {
            get;
            set;
        }
    }
}
