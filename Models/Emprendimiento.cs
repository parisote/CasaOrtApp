using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CasaOrtApp.Models
{
    public class Emprendimiento
    {
        public int Id { get; set; }

        [RegularExpression(@"\D{3,60}$", ErrorMessage = "No acepta numeros ni palabras con menos de 3 caracteres o mayores a 60.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "No acepta numeros ni palabras con menos de 3 caracteres o mayores a 60.")]
        [Required(ErrorMessage = "Campo requerido.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [RegularExpression(@"\d*$", ErrorMessage = "Solo acepta caracteres numericos.")]
        public int Number { get; set; }

        [RegularExpression(@"\d*$", ErrorMessage = "Solo acepta caracteres numericos.")]
        [Required(ErrorMessage = "Campo requerido.")]
        public int Size { get; set; }

        public bool Garden { get; set; }
        public bool SwimmingPool { get; set; }

        [RegularExpression(@"((http|https)://.*?.(jpg|png|gif))$", ErrorMessage = "Solo pueden ser vinculos terminados en jpg, png o gif.")]
        public string Path { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        [RegularExpression(@"\d*$", ErrorMessage = "Solo acepta caracteres numericos.")]
        public decimal Price { get; set; }

        [EnumDataType(typeof(Etapa))]
        public Etapa etapa { get; set; }

        [Required(ErrorMessage = "Campo requerido.")]
        public DateTime ReleaseDate { get; set; }
    }
}
