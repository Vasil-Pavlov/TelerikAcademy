using System;

class Matrix
{
    private int[,] value { set; get; }

    public Matrix()
    {
        value = new int[5, 5];
    }
    public Matrix(int a, int b)
    {
        value = new int[a, b];
    }
    public Matrix(int[,] a)
    {
        value = new int[a.GetLength(0), a.GetLength(1)];
        Array.Copy(a, value, a.Length);
    }

    public void show()
    {
        for (int i = 0; i < value.GetLength(0); i++)
        {
            for (int j = 0; j < value.GetLength(1); j++)
            {
                Console.Write(value[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public override string ToString()
    {
        return value.ToString();
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(a.value.GetLength(0), a.value.GetLength(1));
        for (int i = 0; i < a.value.GetLength(0); i++)
        {
            for (int j = 0; j < a.value.GetLength(1); j++)
            {
                c.value[i, j] = a.value[i, j] + b.value[i, j];
            }
        }
        return c;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(a.value.GetLength(0), a.value.GetLength(1));
        for (int i = 0; i < a.value.GetLength(0); i++)
        {
            for (int j = 0; j < a.value.GetLength(1); j++)
            {
                c.value[i, j] = a.value[i, j] - b.value[i, j];
            }
        }
        return c;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(a.value.GetLength(0), a.value.GetLength(1));
        for (int i = 0; i < a.value.GetLength(0); i++)
        {
            for (int j = 0; j < a.value.GetLength(1); j++)
            {
                c.value[i, j] = a.value[i, j] * b.value[j, i];
            }
        }
        return c;
    }
}

class OverloadedMethods
{
    static void Main()
    {
        Matrix a = new Matrix();
        Console.WriteLine();
        a.show();
        int[,] arr = { { 2, 3, 4 }, { 4, 5, 1 }, { 1, 5, 6 } };
        Matrix b = new Matrix(arr);
        Console.WriteLine();
        b.show();
        int[,] arr2 = { { 1, 5, 7 }, { 2, 3, 2 }, { 5, 7, 2 } };
        Matrix c = new Matrix(arr2);
        Console.WriteLine();
        c.show();
        Console.WriteLine();
        Matrix d = b + c;
        d.show();
        Console.WriteLine();
        d = b - c;
        d.show();
        Console.WriteLine();
        d = b * c;
        d.show();
    }
}

