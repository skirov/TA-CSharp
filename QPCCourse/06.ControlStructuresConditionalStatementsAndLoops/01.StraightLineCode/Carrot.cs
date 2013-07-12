// <copyright file="Carrot.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace Kitchen
{
    /// <summary>
    /// Creates a carrot
    /// </summary>
    public class Carrot : Vegetable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Carrot" /> class.
        /// The carrot is not cut or peeled
        /// </summary>
        /// <param name="isFresh">A boolean value - is the vegetable fresh or rotten</param>
        public Carrot(bool isFresh)
            : base(isFresh, false, false)
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Carrot" /> class.
        /// </summary>
        /// <param name="isFresh">A boolean value - is the vegetable fresh or rotten</param>
        /// <param name="isPeeled">A boolean value - is the vegetable peeled or not</param>
        /// <param name="isCut">A boolean value - is the vegetable cut or not</param>
        public Carrot(bool isFresh, bool isPeeled, bool isCut)
            : base(isFresh, isPeeled, isCut)
        {
        }

        /// <summary>
        /// Get the carrot characteristics
        /// </summary>
        public void GetCarrot()
        {
        }
    }
}
