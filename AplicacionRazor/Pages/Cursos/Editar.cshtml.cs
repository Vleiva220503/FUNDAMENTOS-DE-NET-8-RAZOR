using AplicacionRazor.modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AplicacionRazor.Pages.Cursos
{
    public class EditarModel : PageModel
    {
        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Curso Curso { get; set; }
        [TempData]
        public string Mensaje { get; set; }
        public async Task OnGet(int id)
        {
            Curso = await _contexto.Curso.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CurosDesdeBD = await _contexto.Curso.FindAsync(Curso.Id);
                CurosDesdeBD.NombreCurso = Curso.NombreCurso;
                CurosDesdeBD.CantidadClases = Curso.CantidadClases;
                CurosDesdeBD.Precio = Curso.Precio;

                await _contexto.SaveChangesAsync();
                Mensaje = "Curso Editado";
                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
