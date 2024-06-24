// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter the values of matrix (n, m): ");
string[] valuesDimension = Console.ReadLine().Split(","); 
int n = int.Parse(valuesDimension[0]);
int m = int.Parse(valuesDimension[1]);
int[,] mat = new int[n, m];

for (int i = 0; i < n; i++)
{
    string [] aux = Console.ReadLine().Split(' ');

    for (int j = 0; j< m; j++)
    {
        mat[i, j] = int.Parse(aux[j]);
    }
}

Console.WriteLine("Enter the number:");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (mat[i, j] == number)
        {
            Console.WriteLine("Position: " + i + ", " + j);
            if (j > 0)
            {
                Console.WriteLine("Left: " + mat[i, j -1]);
            }
            if (j < m - 1)
            {
                Console.WriteLine("Right: " + mat[i, j + 1]);
            }
            if(i > 0)
            {
                Console.WriteLine("UP: " + mat[i -1, j]);
            }
            if(i < n - 1)
            {
                Console.WriteLine("Down: " + mat[i + 1, j]);
            }
        }
    }
}

