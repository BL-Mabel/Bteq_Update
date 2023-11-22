using System;
using System.Collections.Generic;
using System.Text;

namespace UtilityLayer.RequestModel
{
    public class AddCampaignRequestModel
    {
        public string Campaign_name { get; set; }
        public string Campaign_Short_Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Pass_Percentage { get; set; }
        public int Maximum_Attempts { get; set; }
        public bool IsActive { get; set;}
    }
}
