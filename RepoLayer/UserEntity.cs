using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RepoLayer
{
    public class UserEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Phone_Number { get; set; }
        public string User_Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        [JsonIgnore]
        public DateTime Created_At { get; set; }
        [JsonIgnore]
        public DateTime Updated_At { get; set; }
        [Column("isActive", TypeName = "bit")]
        [DefaultValue(false)]
        public bool isActive { get; set; }

    }
}