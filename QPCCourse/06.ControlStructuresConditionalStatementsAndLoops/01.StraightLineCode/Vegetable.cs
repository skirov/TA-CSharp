// <copyright file="Vegetable.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace Kitchen
{
    using System.Text;

    /// <summary>
    /// Create a vegetable
    /// </summary>
    public class Vegetable : IVegetable
    {
        #region Fields

        /// <summary>
        /// Is the vegetable fresh
        /// </summary>
        private bool isFresh;

        /// <summary>
        /// Is the vegetable peeled
        /// </summary>
        private bool isPeeled;

        /// <summary>
        /// Is the vegetable cut
        /// </summary>
        private bool isCut;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Vegetable" /> class.
        /// </summary>
        public Vegetable()
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vegetable" /> class.
        /// </summary>
        /// <param name="isFresh">A boolean value - is the vegetable fresh or rotten</param>
        /// <param name="isPeeled">A boolean value - is the vegetable peeled or not</param>
        /// <param name="isCut">A boolean value - is the vegetable cut or not</param>
        public Vegetable(bool isFresh, bool isPeeled, bool isCut)
        {
            this.IsPeeled = isPeeled;
            this.IsFresh = isFresh;
            this.IsCut = isCut;
        }

        #region Properies

        /// <summary>
        /// Gets or sets a value indicating whether the vegetable is fresh.
        /// </summary>
        public bool IsFresh
        {
            get
            {
                return this.isFresh;
            }

            set
            {
                this.isFresh = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the vegetable is peeled.
        /// </summary>
        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }

            set
            {
                this.isPeeled = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the vegetable is cut.
        /// </summary>
        public bool IsCut
        {
            get
            {
                return this.isCut;
            }

            set
            {
                this.isCut = value;
            }
        }

        #endregion

        /// <summary>Returns a string that represents the current object.</summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.AppendFormat("+++ Vegetable type - {0}", this.GetType().Name.ToString());
            toString.AppendLine();

            toString.AppendFormat("+++ Is the {0} fresh - {1}", this.GetType().Name.ToString().ToLower(), this.IsFresh);
            toString.AppendLine();

            toString.AppendFormat("+++ Is the {0} peeled - {1}", this.GetType().Name.ToString().ToLower(), this.IsPeeled);
            toString.AppendLine();

            toString.AppendFormat("+++ Is the {0} cut - {1}", this.GetType().Name.ToString().ToLower(), this.IsCut);
            toString.AppendLine();

            return toString.ToString();
        }
    }
}