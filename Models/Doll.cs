using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Apple_Dolls.Models
{
    public class Doll
    {
        public int Id { get; set; }



        [StringLength(45, MinimumLength = 3)]
        public string Name { get; set; }



        [StringLength(30)]
        public string Material { get; set; }



        [Column(TypeName = "decimal(18, 2)")]
        public decimal Doll_Height { get; set; }



        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }



        [StringLength(20)]
        public string SetTheme { get; set; }



        [Range(0, 15)]
        public int AgeGroup { get; set; }



        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }



        [Range(1, 5)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Rating { get; set; }
    }
}
