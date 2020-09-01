using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Clases
{
    public class Usuario
    {
        
        
        private int Usr_Id { get; set; }
        private string Usr_NombreUsuario { get; set; }
        private string Usr_Contraseña { get; set; }
        private string Usr_ApellidoNombre{ get; set; }
        private string Usr_RolCodigo { get; set; }

        public Rol Rol
        {
            get => default(Rol);
            set
            {
            }
        }

        public Usuario(int usr_Id, string usr_NombreUsuario, string usr_Contraseña, string usr_ApellidoNombre, string usr_RolCodigo)
        {
            this.Usr_Id = usr_Id;
            this.Usr_NombreUsuario = usr_NombreUsuario;
            this.Usr_Contraseña = usr_Contraseña;
            this.Usr_ApellidoNombre = usr_ApellidoNombre;
            this.Usr_RolCodigo = usr_RolCodigo;
        }
    }
}