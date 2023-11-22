using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLayer.ResponseModel
{
    public class addQuestionLevelResponse
    {
        public int Id { get; set; }
        public string difficult_Level { get; set; }
        public int Points { get; set; }
        public DateTime Time { get; set; }
        public int loginId { get; set; }
    }
}
