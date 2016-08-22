using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    internal class matrix
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public double[,] Matrix { get; set; }

        public matrix()
        {
            Rows = Columns = 0;
            Matrix = new double[Rows, Columns];
        }
        public matrix(int rows, int cols)
            : this()
        {
            this.Rows = rows;
            this.Columns = cols;
            Matrix = new double[Rows, Columns];
        }

        public matrix(int rows, int cols, double[,] matrix)
            : this(rows, cols)
        {
            this.copyMatrix(this.Matrix, matrix, rows, cols);
        }
        public void copyMatrix(double[,] src, double[,] dest, int rows, int cols)
        {
            src = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    src[i, j] = dest[i, j];
                }
            }
        }

        public static matrix add(matrix m1, matrix m2)
        {
            matrix res = new matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    res.Matrix[i, j] = m1.Matrix[i, j] + m2.Matrix[i, j];
                }
            }
            return res;
        }

        public static matrix sub(matrix m1, matrix m2)
        {
            matrix res = new matrix(m1.Rows, m1.Columns);
            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    res.Matrix[i, j] = m1.Matrix[i, j] - m2.Matrix[i, j];
                }
            }
            return res;
        }
        public void scalarProduct(double scalar)
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    this.Matrix[i, j] *= scalar;
                }
            }
        }
        public static matrix multiplication(matrix m1, matrix m2)
        {
            if (m1.Columns != m2.Rows)
                return null;
            matrix res = new matrix(m1.Rows, m2.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    for (int k = 0; k < m2.Rows; k++)
                    {
                        res.Matrix[i, j] = m1.Matrix[i, k] * m2.Matrix[k, j];
                    }
                }
            }
            return res;
        }

        public void transpose()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Columns; j++)
                {
                    this.Matrix[i, j] = this.Matrix[j, i];
                }
            }
        }
        public void consoleInputRows()
        {
            Console.WriteLine("enter number of rows");
            while (true)
            {
                try
                {
                    Rows = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input , please try again");
                }
            }
        }
        public void consoleInputColumns()
        {

            Console.WriteLine("enter number of columns");
            while (true)
            {
                try
                {
                    Columns = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong input , please try again");
                }
            }
        }
        public void consoleInputMatrix()
        {
            this.Matrix = new double[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                Console.WriteLine("enter row number {" + (i+1) + "} , leave space among values");
                while (true)
                {
                    try
                    {
                        string line = Console.ReadLine();
                        line = line.Replace("  ", " ");
                        string[] inputs = line.Split(' ');
                        if (inputs.Length < Columns)
                            throw new NotImplementedException();
                        for (int j = 0; j < Columns; j++)
                        {
                            this.Matrix[i, j] = double.Parse(inputs[j]);
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("wrong input , please input " + Columns + " numbers and leave spaces among values");
                    }
                }
            }
        }
        public void consoleOutputMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
