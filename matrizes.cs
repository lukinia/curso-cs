using System;
namespace Course
{
    class matrizes
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de linhas e colunas: ");
            string[] nm = Console.ReadLine().Split(' ');
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int l = 0; l < m; l++)
                {
                    mat[i, l] = int.Parse(valores[i]);
                }
            }

            Console.Write("Visualizar a matriz: ");
            string[] separador = Console.ReadLine().Split(' ');
            int x = int.Parse(separador[0]);
            int y = int.Parse(separador[1]);
            Console.WriteLine(mat[x, y]);
        }
    }
}