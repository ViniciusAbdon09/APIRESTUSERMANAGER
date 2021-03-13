using System.ComponentModel.DataAnnotations;

namespace Manager.API.ViewModels
{
    public class UserUpadateViewModel
    {
        [Required(ErrorMessage = "O campo Id não pode ser nulo")]
        [Range(1, int.MaxValue, ErrorMessage = "O Id não deve ser menor que 1")]
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo Nome não pode ser nulo")]
        [MinLength(3, ErrorMessage = "O campo Nome deve conter no minimo 3 caracteres")]
        [MaxLength(80, ErrorMessage = "O campo Nome deve conter no maximo 80 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Nome não pode ser nulo")]
        [MinLength(10, ErrorMessage = "O campo Nome deve conter no minimo 10 caracteres")]
        [MaxLength(180, ErrorMessage = "O campo Nome deve conter no maximo 180 caracteres")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "O campo Email deve conter @ e .")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha não pode ser nulo")]
        [MinLength(6, ErrorMessage = "O campo Senha deve conter no minimo 6 caracteres")]
        [MaxLength(30, ErrorMessage = "O campo Senha deve conter no maximo 30 caracteres")]
        public string Password { get; set; }
    }
}