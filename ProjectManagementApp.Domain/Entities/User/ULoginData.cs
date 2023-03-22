using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementApp.Domain.Entities.User
{
    public class ULoginData
    {
        public string Credential { get; set; }
        public string Password { get; set; }
        public string LoginIp { get; set; }
        public DateTime LoginDateTime { get; set; }
    }
    class UDbTable
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identify)]
        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Username")]
        [StringLength(30,MinimumLength = 5, ErrorMessage ="Username cannot be longer than 30 characters.")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [StringLength(50, MinimumLength =8, ErrorMessage = "Password cannot be shorter than 8 characters.")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email Adress")]
        [StringLength(30)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLogin { get;}

        [StringLength(30)]
        public string LastIp { get; set; }

        public URole Level { get; set; }

        //class UserContext :DbContext
        //{
        //    public UserContext() :
        //        base("name= eUseControl")
        //    {

        //    }
        //    public virtual DbSet<UDbTable> Users { get; set; }
        //}

    }
}
