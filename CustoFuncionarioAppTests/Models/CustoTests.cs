using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustoFuncionarioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace CustoFuncionarioApp.Models.Tests
{
    [TestClass()]
    public class CustoTests
    {
        private Custo _custo;
        [TestInitialize]

        public void Inicializar()
        {
            _custo = new Custo();
        }
        [TestMethod()]
        [DataRow(4000.03, 12)]
        [DataRow(7000.03, 14)]
        [DataRow(7789.00, 0)]
        [DataRow(1545.00, 9)]
        [DataRow(1412.00, 7.5)]
        public async Task Valor_DeveRetornarCustoAsync(double valor, double esperado)
        {
            //Act
            _custo.SalarioBruto = (decimal)valor;
            var obtido = _custo.getINSS_Aliquota();
            decimal obtidoDecimal = (decimal)obtido;
            decimal esperadoDecimal = (decimal)esperado;

            //Assert
            Assert.AreEqual(esperadoDecimal, obtidoDecimal);
        }
    }
}
