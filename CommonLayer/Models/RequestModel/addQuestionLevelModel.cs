using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLayer.RequestModel
{
    public class AddQuestionLevelModel
    {
        public string DifficultyLevel { get; set; }
        public int Points { get; set; }
        public DateTime Time { get; set; }
    }
}
