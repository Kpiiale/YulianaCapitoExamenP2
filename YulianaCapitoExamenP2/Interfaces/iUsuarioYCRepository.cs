using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YulianaCapitoExamenP2.Models;

namespace YulianaCapitoExamenP2.Interfaces
{
    interface iUsuarioYCRepository
    {
        List<iUsuarioYCRepository> DevuelveListadoUsuario();
        UsuarioYC GetUsuario(int id);
        Boolean CrearUsuario(UsuarioYC estudiante);
        Boolean ActualizarUsuario(UsuarioYC estudiante);
        Boolean EliminarUsuario(int id);
    }
}
