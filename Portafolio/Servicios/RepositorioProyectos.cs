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
                Titulo = "Manejo de Presupuestos: Controla tus Finanzas de manera Eficiente",
                Descripcion = "Esta aplicación web, desarrollada en ASP.NET Core, utiliza tecnologías avanzadas como SQL Server, DAPPER, Auto Mapper y más, para ofrecerte una experiencia completa y segura en la gestión de tus ingresos y gastos diarios. Desde la generación de base de datos con llaves primarias y foráneas, hasta la exportación a Excel, autenticación con Identity y visualización de transacciones en calendario, esta aplicación te permite mantener un balance adecuado entre tus ingresos y gastos de manera efectiva y sencilla en tu vida cotidiana.",
                Link = "http://perfil1-001-site1.atempurl.com/",
                LinkRepositorio = "https://github.com/cyberpunkangel/ManejoPresupuesto",
                ImagenURL = "/imagenes/manejo-presupuesto.png"
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
