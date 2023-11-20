using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepoLayer
{
    public class QuestionDifficultyEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Difficulty_Level { get; set; }
        public int Points { get; set; }
        public DateTime Time { get; set; }
        [ForeignKey("LoginEntity")]
        public int LoginId { get; set; }
        public virtual UserEntity LoginEntity { get; set; }
    }

}
