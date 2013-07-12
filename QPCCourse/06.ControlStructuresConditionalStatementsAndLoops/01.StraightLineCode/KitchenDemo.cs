// <copyright file="KitchenDemo.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace Kitchen
{
    using System;

    /// <summary>
    /// This class represents task 1 from homework Control structures, conditional statements and loops
    /// </summary>
    public class KitchenDemo 
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        public static void Main()
        {
            Chef gordonRamsey = new Chef();

            Vegetable potato = new Potato(true);
            Vegetable carrot = new Carrot(true, false, false);

            gordonRamsey.Peel(potato);
            gordonRamsey.Peel(carrot);

            gordonRamsey.Cut(carrot);

            gordonRamsey.PutInBowl(potato);
            gordonRamsey.PutInBowl(carrot);

            foreach (Vegetable vegetable in gordonRamsey.VegitablesInBowl)
            {
                Console.WriteLine(vegetable.ToString());
                Console.WriteLine();
            }
        }
    }
}
