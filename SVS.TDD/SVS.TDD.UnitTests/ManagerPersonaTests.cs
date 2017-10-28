using NUnit.Framework;
using SVS.TDD.Negocio;
using SVS.TDD.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVS.TDD.UnitTests
{
    [TestFixture]
    public class ManagerPersonaTests
    {
        [Test]
        public void IdPersonaValido_ValidarId_RetornaFalse()
        {
            var persona = new Persona();
            
            var validacionId = ManagerPersona.ValidarId(persona.Id);

            Assert.IsFalse(validacionId);
        }

        [Test]
        public void IdPersonaValido_ValidarId_RetornaTrue()
        {
            var persona = new Persona();
            persona.Id = "13PERSONA";
            var validacionId = ManagerPersona.ValidarId(persona.Id);

            Assert.IsTrue(validacionId);
        }
    }
}
