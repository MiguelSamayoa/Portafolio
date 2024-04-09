using Portafolio.Models;

namespace Portafolio.Services
{
    public class RepositorioProyectos
    {
        public List<Proyecto> GetProyectos()
        {
            List<Proyecto> proyectos = new List<Proyecto>() { 
            
            
            new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "Descripcion 1",
                Imagen = "/Images/Amazon.jfif",
                Url = "https://amazon.com"
            },

            new Proyecto
            {
                Titulo = "New York Times",
                Descripcion = "Descripcion 2",
                Imagen = "/Images/Nytimes.jfif",
                Url = "https://nytimes.com"
            },

            new Proyecto
            {
                Titulo = "Reddit",
                Descripcion = "Descripcion 3",
                Imagen = "/Images/reddit.jpg",
                Url = "https://reddit.com"
            },

            new Proyecto
            {
                Titulo = "steam 4",
                Descripcion = "Descripcion 4",
                Imagen = "/Images/steam.jpg",
                Url = "https://store.steampowered.com"
            }
            };
            return proyectos;
        }
    }
}
