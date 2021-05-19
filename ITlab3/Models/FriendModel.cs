using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ITlab3.Models
{
    public class FriendModel
    {
        public FriendModel()
        {
            friends = new List<FriendModel>();
        }
        public int id { get; set; }
        [Key]
        [Required]
        [Display(Name ="ИД")]
        [Range(0,200,ErrorMessage ="Вредноста на ИД мора да биде од 0 до 200")]
        public int indeks { get; set; }
        [Required]
        [Display(Name = "Име")]
        public string ime { get; set; }
        [Required]
        [Display(Name = "Место на живеење")]
        public string mestonaziveenje { get; set; }
        public virtual ICollection<FriendModel> friends { get; set; }
    }
}