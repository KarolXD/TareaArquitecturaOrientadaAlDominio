using Microsoft.Extensions.DependencyInjection;
using Tarea.Aplicacion.Workflows;
using Tarea.Dominio.Contrato.RP;
using Tarea.Dominio.Contrato.WF;
using Tarea.Infrastructura.Repositorio;

namespace Tarea.Servicio
{
    public class StartupInyeccionDependencias
    {

        IServiceCollection _servicio;

        public StartupInyeccionDependencias(IServiceCollection servicio)
        {
            _servicio = servicio;
        }

        public void comunicacion()
        {
            _servicio.AddTransient<IRegistrarPersonaWF, RegistrarPersonaWF>();
            _servicio.AddTransient<IRegistrarPersonaRP, RegistrarPersonaRP>();

            _servicio.AddTransient<IListarPersonaWF, ListarPersonaWF>();
            _servicio.AddTransient<IListarPersonaRP, ListarPersonaRP>();

            _servicio.AddTransient<IEliminarPersonaWF, EliminarPersonaWF>();
            _servicio.AddTransient<IEliminarPersonaRP, EliminarPersonaRP>();

            _servicio.AddTransient<IFiltrarPersonaWF, FiltrarPersonaWF>();
            _servicio.AddTransient<IFiltrarPersonaRP, FiltrarPersonaRP>();

            _servicio.AddTransient<IModificarPersonaWF, ModificarPersonaWF>();
            _servicio.AddTransient<IModificarPersonaRP, ModificarPersonaRP>();
        }



    }
}
