using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace RepoLayer
{
    public class CampaignEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Campaign_name { get; set; }
        public string Campaign_Short_Name { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public int Pass_Percentage { get; set; }
        public int Maximum_Attempts { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("TestFormat")]
        public int FormatId { get; set; }
        [JsonIgnore]
        public virtual TestFormatEntity TestFormat { get; set; }
        [ForeignKey("LoginEntity")]
        public int LoginId { get; set; }
        [JsonIgnore]
        public virtual UserEntity LoginEntity { get; set; }

    }
}
