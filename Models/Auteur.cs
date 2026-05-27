using System.ComponentModel.DataAnnotations;

namespace NembotKamgueGyldas.Models
{
    public class Auteur
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est obligatoire.")]
        public string Prenom { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de Naissance")]
        public DateTime Date_Naissance { get; set; }
    }
}
