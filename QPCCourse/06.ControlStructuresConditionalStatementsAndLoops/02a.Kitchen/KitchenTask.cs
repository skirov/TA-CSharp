// <copyright file="KitchenTask.cs" company="Telerik Academy">
// 2013 Telerik Academy homework.
// </copyright>
namespace RefactorIfStatements
{
    using System;
    using Kitchen;

    /// <summary>
    /// This class represents part one from task 2 from homework Control structures, conditional statements and loops
    /// </summary>
    public class KitchenTask
    {
        /// <summary>
        /// The entry point of the application.
        /// </summary>
        public static void Main()
        {
            Chef cook = new Chef();

            Vegetable potato = new Potato(true, false, false);

            if (potato != null && potato.IsFresh)
            {
                if (!potato.IsPeeled)
                {
                    cook.Peel(potato);
                }

                cook.Cut(potato);

                cook.PutInBowl(potato);
            }

            foreach (Vegetable vegetable in cook.VegitablesInBowl)
            {
                Console.WriteLine(vegetable.ToString());
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
}
