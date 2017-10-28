using SVS.TDD.Negocio.Entidades;
using System;
using System.Collections.Generic;

namespace SVS.TDD.Negocio
{
    public class ManagerPersona
    {
        public static bool ValidarId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return false;
            }

            return true;
        }
        public static bool ValidarDni(string dni)
        {
            if (string.IsNullOrEmpty(dni))
            {
                return false;
            }
            int resultado;
            int.TryParse(dni, out resultado);

            if (resultado == 0)
            {
                return false;

            }

            if (dni.Length != 8)
            {
                return false;
            }
            
            return true;
        }

        public List<Persona> ObtenerListaPersonas()
        {
            throw new NotImplementedException();
        }
    }
}
