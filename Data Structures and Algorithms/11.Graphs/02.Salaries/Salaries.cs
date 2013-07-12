using System;
class Salaries
{
    static int employeesCount;
    static char[,] hierarchy;
    static long totalSalary = 0;
    static long[] visited;

    static bool IsRowEmpty(int row)
    {
        for (int col = 0; col < hierarchy.GetLength(1); col++)
        {
            if (hierarchy[row, col] == 'Y')
            {
                return false;
            }
        }
        return true;
    }

    static long DFS(int row)
    {
        if (visited[row] > 0)
        {
            return visited[row];
        }

        if (IsRowEmpty(row))
        {
            return 1;
        }

        long salary = 0;

        for (int col = 0; col < hierarchy.GetLength(1); col++)
        {
            if (hierarchy[row, col] == 'Y')
            {
                salary += DFS(col);
            }
        }
        visited[row] = salary;

        return salary;
    }

    static void Main()
    {
        employeesCount = int.Parse(Console.ReadLine());
        hierarchy = new char[employeesCount, employeesCount];
        visited = new long[employeesCount];

        for (int row = 0; row < hierarchy.GetLength(0); row++)
        {
            string employee = Console.ReadLine();

            for (int col = 0; col < employeesCount; col++)
            {
                hierarchy[row, col] = employee[col];
            }
        }

        for (int i = 0; i < hierarchy.GetLength(0); i++)
        {
            totalSalary += DFS(i);
        }

        Console.WriteLine(totalSalary);
    }
}