using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q:
            Console.WriteLine("Введите предложение используя скобки и символы");
            Console.WriteLine();
            string S1 = Console.ReadLine();
            string S2 = S1.Replace(" ", "");
            char[] S3 = S2.ToCharArray();

            Stack<char> stack1 = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            int round, figured, squared;
            round = figured = squared = 0;

            try
            {
                foreach (char A in S3)
                {

                    switch (A)
                    {
                        case '(':
                            stack1.Push(')');
                            round++;
                            break;

                        case ')':
                            round++;
                            if (stack1.Count == 0)
                            {
                                stack2.Push('(');
                                continue;
                            }
                            if (stack1.Peek() == ')')
                            {
                                stack1.Pop();
                                continue;
                            }
                            if (stack2.Peek() == '(')
                            {
                                stack2.Pop();
                                continue;
                            }

                            break;

                        case '{':
                            stack1.Push('}');
                            figured++;
                            break;

                        case '}':
                            figured++;
                            if (stack1.Count == 0)
                            {
                                stack2.Push('{');
                                continue;
                            }
                            if (stack1.Peek() == '}')
                            {
                                stack1.Pop();
                                continue;
                            }
                            if (stack2.Peek() == '{')
                            {
                                stack2.Pop();
                                continue;
                            }

                            break;

                        case '[':
                            stack1.Push(']');
                            squared++;
                            break;

                        case ']':
                            squared++;
                            if (stack1.Count == 0)
                            {
                                stack2.Push('[');
                                continue;
                            }
                            if (stack1.Peek() == ']')
                            {
                                stack1.Pop();
                                continue;
                            }
                            if (stack2.Peek() == '[')
                            {
                                stack2.Pop();
                                continue;
                            }

                            break;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            if (stack1.Count == 0 & stack2.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Скобки расставлены верно");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Скобки расставлены не правильно");
            }

            Console.WriteLine("Круглые {0} шт, Фигурные {1} шт, Квадратные {2} шт", round, figured, squared);
            Console.WriteLine();
            //Console.WriteLine("Количество в стэке1 {0}", stack1.Count);
            //Console.WriteLine("Количество в стэке2 {0}", stack2.Count);
            //goto Q;

            Console.ReadKey();
        }

    }
}
