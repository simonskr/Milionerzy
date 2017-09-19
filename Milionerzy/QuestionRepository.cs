using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    class QuestionRepository
    {
        private readonly Random random = new Random();

        public Question GetNextQuestion()
        {
            int questionIndex = random.Next(questions.Count);

            return questions[questionIndex];
        }

        private List<Question> questions = new List<Question>()
        {
            new Question()
            {
                ID = 1,
                Text = "Jakiego koloru jest chaber bławatek?",
                AnswerA = "Żółtego",
                AnswerB = "Białego",
                AnswerC = "Niebieskiego",
                AnswerD = "Czerwonego",
                Answer = 'C'
            },
            new Question()
            {
                ID = 2,
                Text = "Które z wymienionych nie jest rybą?",
                AnswerA = "Rekin",
                AnswerB = "Delfin",
                AnswerC = "Flądra",
                AnswerD = "Makrela",
                Answer = 'B'
            },
            new Question()
            {
                ID = 3,
                Text = "Które z poniższych nie jest owadem ani pająkiem",
                AnswerA = "Jelonek rogacz",
                AnswerB = "Tygrzyk paskowany",
                AnswerC = "Czubajka",
                AnswerD = "Komar",
                Answer = 'C'
            },
            new Question()
            {
                ID = 4,
                Text = "Które z wymienionych anime nie należy do gatunku harem?",
                AnswerA = "Sword Art Online",
                AnswerB = "Kono Subarashii Sekai ni Shukufuku wo!",
                AnswerC = "Date a Live",
                AnswerD = "No.6",
                Answer = 'D'
            },
            new Question()
            {
                ID = 5,
                Text = "Która z wymienionych metodologii nie dotyczy zarządzania projektami?",
                AnswerA = "SCRUM",
                AnswerB = "Kanban",
                AnswerC = "Agile",
                AnswerD = "SOLID",
                Answer = 'D'
            }
        };
    }
}
