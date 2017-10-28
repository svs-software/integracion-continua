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

        public List<Persona> ObtenerListaPersonas()
        {
            throw new NotImplementedException();
        }
    }
}
