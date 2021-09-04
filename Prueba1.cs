using System;
using System.Collections.Generic;
using Xunit;

namespace Investigacion1
{
    public class Prueba1
    {
        [Fact]
        public void EqualStringIgnoreCase()
        {
            string expected = "wEstEspeCIfiCacion";
            string actual = "testespecificacion";
            Assert.False(actual == expected);
            Assert.NotEqual(expected, actual);
            Assert.Equal(expected, actual, StringComparer.CurrentCultureIgnoreCase);
        }
        [Fact]
        public void Suma()

        {//método  quese encarga de verificar la  iggualdad del metodo  especificado.
            Assert.Equal(10, Add(2, 7));
        }
        int Add(int x, int y)
        {
            return x + y;
        }
        [Theory]
        // diferentes input 
        [InlineData(3)]
        [InlineData(7)]
        [InlineData(1)]
        public void NumeroPar(int value)
        {// verifica si una  numero  es par
            Assert.True(IsOdd(value));
        }
        bool IsOdd(int value)
        {// con el modulo se extraer la  verificación si el # es par o impar

            return value % 2 == 0;
        }
    }
}

  

