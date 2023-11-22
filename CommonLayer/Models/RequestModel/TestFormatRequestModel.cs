using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLayer.RequestModel
{
    public class TestFormatRequestModel
    {
        public string TestFormat { get; set; }
        public DateTime TestDuration { get; set; }
        public int QuestionDistribution { get; set;  }
        public int TotalQuestions { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
