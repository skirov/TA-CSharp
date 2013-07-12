// <copyright file="Chef.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace Kitchen
{
    using System.Collections.Generic;

    /// <summary>
    /// Does cooking operations
    /// </summary>
    public class Chef
    {
        /// <summary>
        /// All vegetables in the bowl
        /// </summary>
        private List<Vegetable> vegitablesInBowl = new List<Vegetable>();

        /// <summary>
        /// Gets a read only collection for the vegetables in the bowl
        /// </summary>
        public IReadOnlyCollection<Vegetable> VegitablesInBowl
        {
            get
            {
                return this.vegitablesInBowl;
            }
        }

        #region Methods(Chef activities)

        /// <summary>
        /// Peel the <paramref name="vegetable"/>
        /// </summary>
        /// <param name="vegetable">Vegetable name</param>
        public void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }

        /// <summary>
        /// Cut the <paramref name="vegetable"/>
        /// </summary>
        /// <param name="vegetable">Vegetable name</param>
        public void Cut(Vegetable vegetable)
        {
            vegetable.IsCut = true;
        }

        /// <summary>
        /// Put the <paramref name="vegetable"/> in a bowl
        /// </summary>
        /// <param name="vegetable">Vegetable name</param>
        public void PutInBowl(Vegetable vegetable)
        {
            this.vegitablesInBowl.Add(vegetable);
        }

        #endregion
    }
}