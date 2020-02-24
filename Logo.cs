using System;
using System.Text;
using System.Collections.Generic;

namespace MMLogo
{
    class Logo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = n + 1;  //Rows count
            List<string> logo = new List<string>();

            FirstRow(n, logo);

            SecondRowToTheMiddle(n, m, logo);

            int varP, varT, varZ, varR;
            FirstRowAfterTheMiddle(n, m, logo, out varP, out varT, out varZ, out varR);

            EndRows(n, m, logo, ref varP, ref varT, ref varZ, ref varR);

            foreach (var item in logo)
            {
                Console.WriteLine(item);
            }
        }

        private static void EndRows(int n, int m, List<string> logo, ref int varP, ref int varT, ref int varZ, ref int varR)
        {
            for (int i = (m / 2) + 1; i < m; i++)
            {
                string nextRow = string.Empty;
                varP -= 1;
                varT += 2;
                varZ -= 2;
                varR -= 1;

                for (int a = 0; a < varP; a++)
                {
                    nextRow += "-";
                }
                for (int b = 0; b < n; b++)
                {
                    nextRow += "*";
                }
                for (int c = 0; c < varT; c++)
                {
                    nextRow += "-";
                }
                for (int d = 0; d < varZ; d++)
                {
                    nextRow += "*";
                }
                for (int c = 0; c < varT; c++)
                {
                    nextRow += "-";
                }
                for (int b = 0; b < n; b++)
                {
                    nextRow += "*";
                }
                for (int e = 0; e < varR; e++)
                {
                    nextRow += "-";
                }

                nextRow += nextRow;
                logo.Add(nextRow);
            }
        }

        private static void FirstRowAfterTheMiddle(int n, int m, List<string> logo, out int varP, out int varT, out int varZ, out int varR)
        {
            varP = n - (m / 2);
            varT = 1;
            varZ = (n * 2) - 1;
            varR = (n - 1) / 2;
            string firstRowAfterTheMiddle = string.Empty;

            for (int i = 0; i < varP; i++)
            {
                firstRowAfterTheMiddle += "-";
            }
            for (int i = 0; i < n; i++)
            {
                firstRowAfterTheMiddle += "*";
            }

            firstRowAfterTheMiddle += "-";

            for (int i = 0; i < varZ; i++)
            {
                firstRowAfterTheMiddle += "*";
            }

            firstRowAfterTheMiddle += "-";

            for (int i = 0; i < n; i++)
            {
                firstRowAfterTheMiddle += "*";

            }

            for (int i = 0; i < varR; i++)
            {
                firstRowAfterTheMiddle += "-";
            }

            firstRowAfterTheMiddle += firstRowAfterTheMiddle;

            logo.Add(firstRowAfterTheMiddle);
        }

        private static void SecondRowToTheMiddle(int n, int m, List<string> logo)
        {
            int starsVariable = n;
            int firstAndLastDashes = n;
            int middleDashes = n;

            for (int i = 2; i <= m / 2; i++)
            {
                string nextRowsToTheMiddle = string.Empty;

                firstAndLastDashes -= 1;
                starsVariable += 2;
                middleDashes -= 2;

                for (int a = 0; a < firstAndLastDashes; a++)
                {
                    nextRowsToTheMiddle += "-";
                }
                for (int b = 0; b < starsVariable; b++)
                {
                    nextRowsToTheMiddle += "*";
                }
                for (int c = 0; c < middleDashes; c++)
                {
                    nextRowsToTheMiddle += "-";
                }
                for (int b = 0; b < starsVariable; b++)
                {
                    nextRowsToTheMiddle += "*";
                }
                for (int a = 0; a < firstAndLastDashes; a++)
                {
                    nextRowsToTheMiddle += "-";
                }
                nextRowsToTheMiddle += nextRowsToTheMiddle;
                logo.Add(nextRowsToTheMiddle);
            }
        }

        private static void FirstRow(int n, List<string> logo)
        {
            string firstRow = string.Empty;

            for (int i = 1; i <= 5; i++)
            {
                if (i % 2 == 0)
                {
                    for (int a = 0; a < n; a++)
                    {
                        firstRow += "*";
                    }
                }
                else if (i % 2 != 0)
                {
                    for (int b = 0; b < n; b++)
                    {
                        firstRow += "-";
                    }
                }
            }

            firstRow += firstRow;
            logo.Add(firstRow);
        }
    }
}
