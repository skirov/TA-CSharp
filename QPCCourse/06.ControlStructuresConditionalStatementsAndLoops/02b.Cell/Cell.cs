// <copyright file="Cell.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace RefactorIfStatements
{
    using System;

    /// <summary>
    /// This class represents part two from task 2 from homework Control structures, conditional statements and loops
    /// </summary>
    public class Cell
    {
        #region Feilds

        /// <summary>
        /// The minimum row to enter
        /// </summary>
        private const int MinRow = 0;

        /// <summary>
        /// The maximum row to enter
        /// </summary>
        private const int MaxRow = 200;

        /// <summary>
        /// The minimum col to enter
        /// </summary>
        private const int MinCol = 0;

        /// <summary>
        /// The maximum col to enter
        /// </summary>
        private const int MaxCol = 200;

        /// <summary>
        /// A public static readonly boolean field indicating cell access - can you 
        /// or can you not access the cell
        /// </summary>
        private static readonly bool CanVisitCell = true; // for example. If in a real project should have some logic behind the value.

        #endregion

        /// <summary>
        /// Message to display when a cell is visited
        /// </summary>
        public static void VisitCell()
        {
            Console.WriteLine("Cell visited");
        }

        /// <summary>
        /// The entry point of the application.
        /// </summary>
        public static void Main()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            if (MinRow <= row && row <= MaxRow &&
                MinCol <= col && col <= MaxCol)
            {
                if (CanVisitCell)
                {
                    VisitCell();
                }
            }
        }
    }
}
