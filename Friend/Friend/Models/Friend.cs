using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Friend.Models
{
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Ingresar Nombre entre a 3 a 30 Caracteres", MinimumLength = 3)]
        public string Name { get; set; }
        public string NickName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }
    }
}