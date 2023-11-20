using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace RepoLayer
{
    public class QuestionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Question_Type { get; set; }

        public string Question_Difficulty_Level { get; set; }

        public bool Status_Flag { get; set; }

        public int TopicId { get; set; }

        public TopicEntity Topic { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime LastUpdated_At { get; set;}
        [ForeignKey("LoginEntity")]
        public int LoginId { get; set; }
        public virtual UserEntity LoginEntity { get; set; }

    }
}
