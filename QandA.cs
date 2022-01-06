
namespace SQLrepetition
{
    public class QandA
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public QandA(string q, string a)
        {
            Question = q;
            Answer = a;
        }
    }
}
