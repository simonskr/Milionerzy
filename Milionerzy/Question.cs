﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milionerzy
{
    class Question
    {
        public int ID { get; set; }

        public string Text { get; set; }

        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }

        public char Answer { get; set; }

        public bool IsCorrectAnswer(char answer)
        {
            if (char.ToUpperInvariant(answer) == char.ToUpperInvariant(Answer))
                return true;
            else
                return false;
        }
    }
}
