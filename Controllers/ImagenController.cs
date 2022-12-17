using System.Data.SqlClient;
using Catalogo.Data;
using Catalogo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Controllers
{
    public class ImagenController : Controller
    {
        private readonly BD_Contexto _Contexto;

        public ImagenController(BD_Contexto contexto)
        {
            _Contexto = contexto;
        }

        [HttpGet]
        public IActionResult Catalogo()
        {
            using (SqlConnection con = new(_Contexto.Conexion))
            {
                List<Imagen> lista_imagenes = new();
                using (SqlCommand cmd = new("sp_Obtener_Imagenes", con))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    con.Open();

                    var dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista_imagenes.Add(new Imagen
                        {
                            Id_Imagen = (int)dr["Id_Imagen"],
                            Nombre = dr["Nombre"].ToString(),
                            Image = dr["Imagen"].ToString(),
                            Fuente = dr["Fuente"].ToString()
                        });
                    }
                }
                ViewBag.Cat = lista_imagenes;

                return View();
            }
        }
    }
}