using System;
using System.Collections.Generic;
using System.Linq;

namespace SQLrepetition
{
    public class Quiz
    {
        List<QandA> questionList = new();

        public void AddQuestion(QandA q)
        {
            questionList.Add(q);
        }

        public List<QandA> GetQuestions()
        {
            Random rand = new();

            return questionList.OrderBy(q => rand.Next()).ToList();
        }
    }

}