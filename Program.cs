using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SQLrepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new();
            int rightAnswer = 0;
            int wrongAnswer = 0;
            ConsoleKeyInfo keyPressed;

            var v = File.ReadAllText("QandA.txt").Split(new string[] { "Q:", "A:" }, StringSplitOptions.None).Where(x => !string.IsNullOrWhiteSpace(x)).ToList();


            for (int i = 0; i < v.Count; i += 2)
            {
                quiz.AddQuestion(new QandA(v[i], v[i + 1]));
            }

            foreach (var item in quiz.GetQuestions())
            {
                Console.Clear();
                string userAnswer;
                Console.WriteLine(item.Question);
                Console.Write("Svar: ");
                userAnswer = Console.ReadLine();
                Console.WriteLine("Rätt svar: " + item.Answer);
                Console.WriteLine("Svarade du rätt? J/N");
                while (true)
                {
                    keyPressed = Console.ReadKey(true);
                    if (keyPressed.Key == ConsoleKey.J)
                    {
                        rightAnswer++;
                        break;
                    }
                    else if (keyPressed.Key == ConsoleKey.N)
                    {
                        wrongAnswer++;
                        break;
                    }
                }
            }

            Console.Clear();
            Console.WriteLine($"Du hade {rightAnswer} rätt och {wrongAnswer} fel");
            Console.ReadKey(true);

        }
    }
}
