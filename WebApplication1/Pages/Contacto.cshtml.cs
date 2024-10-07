using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Pages
{
    public class ContactoModel : PageModel
    {
		[BindProperty]
		[Required(ErrorMessage = "Un Nombre es requerido.")]
		public required string Nombre { get; set; }

		[BindProperty]
		[Required(ErrorMessage = "Un Email es requerido.")]
		[EmailAddress(ErrorMessage = "Dirección de Email invalido.")]
		public required string Email { get; set; }

		[BindProperty]
		[Required(ErrorMessage = "Un Mensaje es requerido.")] 
		public required string Mensaje { get; set; }
		public void OnGet()
        {
        }

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			// Process form submission (e.g., save to database, send an email)
			TempData["SuccessMessage"] = "Tu Mensaje fue enviado con exito!";
			return RedirectToPage();
		}
	}
}