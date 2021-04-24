using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2Ofi.Models
{
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="Ingrese un Nombre de 3 a 30 caracteres",MinimumLength =3)]
        public string Name { get; set; }

        public string NickName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Cumpleaños")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime Birthdate { get; set; }
    }
}