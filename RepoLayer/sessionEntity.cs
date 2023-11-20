using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepoLayer
{
    public class SessionEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string token { get; set; }
        public DateTime session_Start_DateTime { get; set; }
        public DateTime session_End_DateTime { get; set; }
        [ForeignKey("LoginEntity")]
        public int LoginId { get; set; }
        public virtual UserEntity LoginEntity { get; set; }
    }
}