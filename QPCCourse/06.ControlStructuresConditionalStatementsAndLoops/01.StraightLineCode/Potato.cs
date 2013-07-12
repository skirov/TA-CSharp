// <copyright file="Potato.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace Kitchen
{
    /// <summary>
    /// Creates a potato
    /// </summary>
    public class Potato : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Potato" /> class.
        /// The potato is not cut or peeled
        /// </summary>
        /// <param name="isFresh">A boolean value - is the vegetable fresh or rotten</param>
        public Potato(bool isFresh)
            : base(isFresh, false, false)
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Potato" /> class.
        /// </summary>
        /// <param name="isFresh">A boolean value - is the vegetable fresh or rotten</param>
        /// <param name="isPeeled">A boolean value - is the vegetable peeled or not</param>
        /// <param name="isCut">A boolean value - is the vegetable cut or not</param>
        public Potato(bool isFresh, bool isPeeled, bool isCut)
            : base(isFresh, isPeeled, isCut)
        {
        }

        /// <summary>
        /// Get the potato characteristics
        /// </summary>
        public void GetPotato()
        {
        }
    }
}