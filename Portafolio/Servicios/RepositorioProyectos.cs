using Markdig;
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
                Titulo = "Sistema de Gestión Cinematográfica con ASP.NET Core y Entity Framework Core",
                Descripcion = Markdown.ToHtml("\r\nEste proyecto es una aplicación web API basada en ASP.NET Core y Entity Framework Core, diseñada para gestionar las operaciones clave de un cine. Desde la gestión de actores y géneros hasta detalles específicos de las películas y cines, esta API proporciona una interfaz eficiente para la administración y consulta de información cinematográfica." + Environment.NewLine + Environment.NewLine + "**Tecnologías y Dependencias Utilizadas:**" + Environment.NewLine + Environment.NewLine + "-Microsoft.EntityFrameworkCore.InMemory: Proveedor de base de datos en memoria para pruebas y desarrollo." + Environment.NewLine + Environment.NewLine + "-Microsoft.EntityFrameworkCore.Proxies: Habilita la carga perezosa (lazy loading) y la creación de proxies para las entidades." + Environment.NewLine + Environment.NewLine + "-Microsoft.EntityFrameworkCore.SqlServer: Proveedor de base de datos SQL Server para Entity Framework Core." + Environment.NewLine + Environment.NewLine + "-Microsoft.EntityFrameworkCore.SqlServer.NetTopologySuite: Extensión para manejar tipos geoespaciales en SQL Server con Entity Framework Core." + Environment.NewLine + Environment.NewLine + "-Microsoft.EntityFrameworkCore.Tools: Herramientas de línea de comandos para Entity Framework Core, útiles para migraciones y otros procesos de desarrollo."),
                Link = "http://cyefc01-001-site1.ftempurl.com/swagger/index.html",
                LinkRepositorio = "https://github.com/cyberpunkangel/EntityFrameworkCore/tree/main/EFCorePeliculas",
                ImagenURL = "/imagenes/efc.png"
            },
                new Proyecto
            {
                Titulo = "Manejo de Presupuestos: Controla tus Finanzas de manera Eficiente",
                Descripcion = "Esta aplicación web, desarrollada en ASP.NET Core, utiliza tecnologías avanzadas como SQL Server, DAPPER, Auto Mapper y más, para ofrecerte una experiencia completa y segura en la gestión de tus ingresos y gastos diarios. Desde la generación de base de datos con llaves primarias y foráneas, hasta la exportación a Excel, autenticación con Identity y visualización de transacciones en calendario, esta aplicación te permite mantener un balance adecuado entre tus ingresos y gastos de manera efectiva y sencilla en tu vida cotidiana.",
                Link = "http://mapre01-001-site1.gtempurl.com/",
                LinkRepositorio = "https://github.com/cyberpunkangel/ManejoPresupuesto",
                ImagenURL = "/imagenes/manejo-presupuesto.png"
            },
                new Proyecto
            {
                Titulo = "Taskify: Gestor de Tareas y Pasos Inteligente",
                Descripcion = "Es una aplicación web que ofrece una completa gestión de tareas y pasos, desarrollada con Entity Framework Core para crear y administrar entidades. La implementación de tablas de Identity simplifica el sistema de usuarios, mientras que la integración de login externo de Microsoft brinda una experiencia de registro y login sin complicaciones. Además, la asignación de roles permite asignar categorías a los usuarios. La aplicación es altamente personalizable con globalización e IStringLocalizer para traducir el contenido a distintos idiomas. El uso de KnockoutJS hace que la aplicación sea interactiva, y se aprovechó al máximo el poder de C# y Entity Framework Core para realizar consultas y operaciones CRUD. También se solucionó el problema de ciclos de objetos con el serializador de JSON de ASP.NET Core. La aplicación permite el almacenamiento local de archivos y su registro en la base de datos, ofreciendo así una solución completa y versátil para la gestión de tareas y pasos.",
                Link = "https://taskify02-001-site1.atempurl.com/",
                LinkRepositorio = "https://github.com/cyberpunkangel/tareas_mvc/tree/main",
                ImagenURL = "/imagenes/tareas-mvc.png"
            },
                new Proyecto
            {
                Titulo = "BlazorDex",
                Descripcion = "Es una aplicación web interactiva desarrollada con Blazor que te permite explorar y descubrir información detallada sobre los Pokémon. Utiliza la PokeAPI para obtener datos precisos y actualizados sobre cada Pokémon, y cuenta con una elegante interfaz de usuario con paginación y botones para una experiencia de usuario fluida y agradable.",
                Link = "http://pokedex01-001-site1.dtempurl.com/",
                LinkRepositorio = "https://github.com/cyberpunkangel/BlazorDex",
                ImagenURL = "/imagenes/pokedex.png"
            },
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
