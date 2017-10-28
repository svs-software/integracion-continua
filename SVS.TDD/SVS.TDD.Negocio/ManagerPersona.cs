using SVS.TDD.Negocio.Entidades;
using System;
using System.Collections.Generic;

namespace SVS.TDD.Negocio
{
    public class ManagerPersona
    {
        public static bool ValidarPersona(Persona persona)
        {
            // TODO: Validar NULL <persona>

            if (string.IsNullOrEmpty(persona.Id))
                throw new Exception("Id incorrecto");

            if (string.IsNullOrEmpty(persona.Nombre))
                throw new Exception("Nombre incorrecto");

            return true;
        }

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
