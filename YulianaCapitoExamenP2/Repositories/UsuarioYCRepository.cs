using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YulianaCapitoExamenP2.Interfaces;
using YulianaCapitoExamenP2.Models;

namespace YulianaCapitoExamenP2.Repositories
{
 

    class UsuarioYCRepository : iUsuarioYCRepository
    {
        public bool ActualizarUsuario(UsuarioYC estudiante)
        {
            throw new NotImplementedException();
        }

        public bool CrearUsuario(UsuarioYC estudiante)
        {
            throw new NotImplementedException();
        }

        public List<iUsuarioYCRepository> DevuelveListadoUsuario()
        {
          
        }

        public bool EliminarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioYC GetUsuario(int id)
        {
            throw new NotImplementedException();
        }
    }
}
