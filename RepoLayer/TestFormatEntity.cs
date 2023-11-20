using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepoLayer
{
    public class TestFormatEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Test_Format { get; set; }
        public DateTime Test_Duration { get; set; }
        public int Question_Distribution { get; set; }
        public int Total_Questions { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("LoginEntity")]
        public int LoginId { get; set; }
        public virtual UserEntity LoginEntity { get; set; }
    }
}
