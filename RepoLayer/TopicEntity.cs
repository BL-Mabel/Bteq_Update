
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepoLayer
{
    public class TopicEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Topic_Name { get; set; }
       
        public ICollection<QuestionEntity> Questions { get; set; }
        
        [ForeignKey("LoginEntity")]
        public int LoginId { get; set; }
        
        public virtual UserEntity LoginEntity { get; set; }
    }
}
