using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOne.Models
{
    public class Mission
    {
        [Key]
        public int MissionID { get; set; }

        [Required(ErrorMessage = "Mission Name required")]
        [Display(Name = "Mission Name")]
        public string MissionName { get; set; }

        [Required (ErrorMessage ="Mission President name required")]
        [Display (Name = "Mission President's Name")]
        public string PresidentName { get; set; }



        [Required(ErrorMessage = "Mission Address required")]
        [Display(Name = "Mission Address")]
        public string MissionAddress { get; set; }


        [Required(ErrorMessage = "Mission language required")]
        [Display(Name = "Mission Language")]
        public string Language { get; set; }


        [Required(ErrorMessage = "Mission climate required")]
        [Display(Name = "Mission Climate")]
        public string Climate { get; set; }


        [Required(ErrorMessage = "Mission dominant religion required")]
        [Display(Name = "Dominant Religion")]
        public string DominantReligion { get; set; }

        [Required]
        [Display(Name ="Country Identifier")]
        public string Picture { get; set; }



    }
}