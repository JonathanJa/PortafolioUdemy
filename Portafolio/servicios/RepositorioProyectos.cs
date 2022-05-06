using Portafolio.Models;

namespace Portafolio.servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyecto();
    }
    public class RepositorioProyectos:IRepositorioProyectos
    {
      

        public List<Proyecto> ObtenerProyecto()
        {
            return new List<Proyecto>() {
               new Proyecto {
                   titulo="Amazon",
                   Descripcion="E-Commerce realizado en ASP.NET core",
                   Link="https://amazon.com",
                   ImagenURL="/imagenes/amazon.png"
               },
               new Proyecto {
                   titulo="New York Times",
                   Descripcion="Pagina de noticia con React",
                   Link="https://nytimes.com",
                   ImagenURL="/imagenes/nyt.png"
               },
               new Proyecto {
                   titulo="Reddit",
                   Descripcion="Red social para compartir en comunidades",
                   Link="https://reddit.com",
                   ImagenURL="/imagenes/reddit.png"
               },
               new Proyecto {
                   titulo="Steam",
                   Descripcion="Tienda en línea para comprar videosjuegos",
                   Link="https://store.steampowered.com",
                   ImagenURL="/imagenes/steam.png"
               },
            };
        }

    }
}
