using SVS.TDD.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

            if(dni.Length != 8)
            {
                return false;
            }

            var expresion = new Regex(@"[a-z]+");

            if (!expresion.IsMatch(dni)) {
                return true;
            }

            if (string.IsNullOrWhiteSpace(dni.Trim()) ){
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
