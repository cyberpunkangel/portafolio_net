using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Slot 1",
                Descripcion = "Descripción slot 1",
                Link = "https://www.google.com/",
                LinkRepositorio = "https://google.com",
                ImagenURL = "/imagenes/amazon.png"
            },
            //    new Proyecto
            //{
            //    Titulo = "Ejemplo1",
            //    Descripcion = "Página de noticias en React",
            //    Link = "https://nytimes.com",
            //    ImagenURL = "/imagenes/nyt.png"
            //},
            //    new Proyecto
            //{
            //    Titulo = "Ejemplo2",
            //    Descripcion = "Red social para compartir en comunidades",
            //    Link = "https://reddit.com",
            //    ImagenURL = "/imagenes/reddit.png"
            //},
            //    new Proyecto
            //{
            //    Titulo = "Ejemplo3",
            //    Descripcion = "Tienda en línea para comprar videojuegos",
            //    Link = "https://store.steampowered.com",
            //    ImagenURL = "/imagenes/steam.png"
            //},
            };
        }
    }
}
