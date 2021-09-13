using System;

class Program {
    public static void Main (string[] args) {

        bool response = true;
        int [,]matriz = 
        { { 2, 5, 11 }, { 5, 4, 17 }, { 11, 17, 6 } };

        for (int x = 0; x < 3; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                if (matriz[x, y] != matriz[y, x])
                {
                    response = false;
                }
            }   
        }

        Console.WriteLine(response);

        if (response)
        {
            Console.WriteLine("A matriz é simétrica");
        }
        else
        {
            Console.WriteLine("A matriz não é simétrica");
        }
    }
}
