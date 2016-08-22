using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region guid
            // = for guid is to clone it
            /*
            Guid g = new Guid();
            g = Guid.NewGuid();
            Guid p = g;
            p = Guid.NewGuid();
            Console.WriteLine(g+"\n");
            Console.WriteLine(p);
           */
            #endregion
            #region b7bk
            /*
            Console.WriteLine("                                                                                          uuuu            uuuu");
            Console.WriteLine("BBBBBBBBBBBBBBBB          77777777777777        BBBBBBBBBBBBBBBB      kkkk       kkkk     uuuu            uuuu");
            Console.WriteLine("BBBBBBBBBBBBBBBB          7777777777777         BBBBBBBBBBBBBBBB      kkkk     kkkk       uuuu            uuuu");
            Console.WriteLine("BBBB        BBBB                  7777          BBBB        BBBB      kkkk   kkkk         uuuu            uuuu");
            Console.WriteLine("BBBB        BBBB                 7777           BBBB        BBBB      kkkk kkkk           uuuu            uuuu");
            Console.WriteLine("BBBBBBBBBBBBBBBB                7777            BBBBBBBBBBBBBBBB      kkkkkkkk            uuuu            uuuu");
            Console.WriteLine("BBBBBBBBBBBBBBBB               7777             BBBBBBBBBBBBBBBB      kkkk kkkk           uuuu            uuuu");
            Console.WriteLine("BBBB        BBBB              7777              BBBB        BBBB      kkkk   kkkk         uuuu            uuuu");
            Console.WriteLine("BBBB        BBBB             7777               BBBB        BBBB      kkkk     kkkk       uuuu            uuuu");
            Console.WriteLine("BBBBBBBBBBBBBBBB            7777                BBBBBBBBBBBBBBBB      kkkk      kkkk      uuuuuuuuuuuuuuuuuuuu    ");
            Console.WriteLine("BBBBBBBBBBBBBBBB           7777                 BBBBBBBBBBBBBBBB      kkkk        kkkk    uuuuuuuuuuuuuuuuuuuu      ");
            Console.WriteLine("                                                                                          uuuuuuuuuuuuuuuuuuuu      ");
            */
            #endregion
            #region matrix operations
            /*
            Console.WriteLine("Welcome to Matrix Operations.....");
            matrix m1, m2, res;
            bool validOperation;
            bool exit ;
            do
            {
                Console.WriteLine("Please Select operation(+ for addition,- for substraction,* for multiplication ,s for scalar product,e for exit");
                char operation = Console.ReadLine().ToCharArray()[0];
                validOperation = true;
                exit = false;

                do
                {//for repeat
                    validOperation = true;
                    char oldOperation = operation;
                    switch (oldOperation)
                    {
                        case '+':
                            Console.WriteLine("addition");
                            Console.WriteLine("enter the first matrix values ");     
                             m1 = new matrix();
                            m1.consoleInputRows();
                            m1.consoleInputColumns();
                            m1.consoleInputMatrix();
                             m2 = new matrix(m1.Rows, m1.Columns);
                            Console.WriteLine("enter the second matrix values ");
                            m2.consoleInputMatrix();
                             res =  matrix.add(m1, m2);
                            Console.WriteLine("Result ");
                            res.consoleOutputMatrix();
                            break;
                        case '-':
                            Console.WriteLine("subtraction");
                              m1 = new matrix();
                              Console.WriteLine("enter the first matrix values ");

                            m1.consoleInputRows();
                            m1.consoleInputColumns();
                            m1.consoleInputMatrix();
                             m2 = new matrix(m1.Rows, m1.Columns);
                            Console.WriteLine("enter the second matrix values ");
                            m2.consoleInputMatrix();
                             res =  matrix.sub(m1, m2);
                            Console.WriteLine("Result ");
                            res.consoleOutputMatrix();
                            break;
                        case '*':
                            Console.WriteLine("multiplication");
                            m1 = new matrix();
                            Console.WriteLine("enter the first matrix values ");

                            m1.consoleInputRows();
                            m1.consoleInputColumns();
                            m1.consoleInputMatrix();
                            m2 = new matrix();
                            Console.WriteLine("enter the second matrix values ");

                            m2.consoleInputColumns();
                            m2.Rows = m1.Columns;
                            m2.consoleInputMatrix();
                            res = matrix.multiplication(m1, m2);
                            Console.WriteLine("Result ");
                            res.consoleOutputMatrix();
                            break;
                        case 's':
                            Console.WriteLine("scalar product");
                            m1 = new matrix();
                            Console.WriteLine("enter the matrix values ");

                            m1.consoleInputRows();
                            m1.consoleInputColumns();
                            m1.consoleInputMatrix();

                            double scalar = 0;
                            Console.WriteLine("enter scalar value ");
                            while (true)
                            {
                                try
                                {
                                    scalar = double.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (Exception e )
                                {
                                    Console.WriteLine("wrong inuput , please enter a valid value");    
                                }
                            }
                            m1.scalarProduct(scalar);
                            Console.WriteLine("Result ");
                            m1.consoleOutputMatrix();
                            break;
                        case 'e':
                            exit = true;
                            break;
                        default:

                            validOperation = false;
                            Console.WriteLine("Wrong Operation , please select a valid operation");
                            operation = Console.ReadLine().ToCharArray()[0];
                            break;
                    }

                    if (validOperation && !exit)
                    {
                        Console.WriteLine("do you want to do the same operation again ?(y,n)");
                        char again = Console.ReadLine().ToCharArray()[0];
                        if (again != 'y' && again != 'Y')
                        {
                            break;
                        }
                    }
                } while (  !exit);// end while for repeat the same operation

                if (!exit)
                {
                    Console.WriteLine("do you want to do another operation ?(y/n)");
                    char another = Console.ReadLine().ToCharArray()[0];


                    if (another != 'y' && another != 'Y')
                    {
                        break;
                        
                    }
                    else
                    {
                        exit = false;
                    }
                }

            } while (!exit);
            */
            #endregion

        }
    }

}
