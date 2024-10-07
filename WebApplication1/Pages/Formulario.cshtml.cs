using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Pages
{
    public class FormularioModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Nombre requerido.")]
        public required string FirstName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Apellido requerido.")]
        public required string LastName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Direcci�n requerida.")]
        public required string Address { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Correo Electr�nico requerido.")]
        [EmailAddress(ErrorMessage = "Formato de correo electr�nico no v�lido.")]
        public required string EmailC { get; set; }

        public void OnGet()
        {
        }
	}
}
