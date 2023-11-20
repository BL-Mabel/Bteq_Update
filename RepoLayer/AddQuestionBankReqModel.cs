
using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLayer.RequestModel
{
    public class AddQuestionBankReqModel
    {
        public string QuestionType { get; set; }

        public string QuestionDifficultyLevel { get; set; }
        public bool StatusFlag { get; set; }
        //public TopicEntity Topic { get; set; }
    }
}
