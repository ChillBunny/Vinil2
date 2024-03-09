using Vinil2.Model;
namespace Vinil2.Servicios
{
    public interface IRickAndMortyService
    {
        public Task<List<PersonajeResponsive.Result>> Obtener();
    }
}
