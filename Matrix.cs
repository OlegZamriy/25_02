using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class Matrix
    {
        private int[,] matrixData;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            matrixData = new int[rows, cols];
        }

        public void InputMatrix()
        {
            Console.WriteLine("Введіть елементи матриці:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Елемент [{i},{j}]: ");
                    matrixData[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void DisplayMatrix()
        {
            Console.WriteLine("Матриця:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrixData[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int FindMax()
        {
            int max = matrixData[0, 0];

            foreach (int element in matrixData)
            {
                if (element > max)
                {
                    max = element;
                }
            }

            return max;
        }

        public int FindMin()
        {
            int min = matrixData[0, 0];

            foreach (int element in matrixData)
            {
                if (element < min)
                {
                    min = element;
                }
            }

            return min;
        }
    }

}
