using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FaceLoginApp.Modelos;

namespace FaceLoginApp.Servicios
{
    interface IServicioBaseDatos
    {
        Task<Usuario> ObtenerUsuario(string key);
        Task<bool> RegistrarUsuario(Usuario dato);
        Task<bool> ActualizarUsuario(Usuario dato);
    }
}
