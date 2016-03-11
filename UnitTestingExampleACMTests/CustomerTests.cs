using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingExampleACM;

namespace UnitTestingExampleACMTests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //vamos a testear con un no,bre correcto si nos da el nombre completo
            //arrange
            Customer customer = new Customer(); //crear una instancia de Customer -> objeto customer de la calse Customer
            customer.FirstName = "Moni"; //hard-code
            customer.LastName = "Argento";
            string expected = "Argento, Moni"; //esperado
            //act
            string actual = customer.FullName; //invocamos lo que queremos testear
            //assert
            Assert.AreEqual(expected, actual); //if expected == actual -> ok
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //vamos a probar si no pasamos priumer nombre
            //arrange
            Customer customer = new Customer();
            customer.LastName = "Olkies";
            string expected = "Olkies";
            //act
            string actual = customer.FullName;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //vamos a probar si no pasamos apellido
            //arrange
            Customer customer = new Customer();
            customer.FirstName = "Ilan";
            string expected = "Ilan";
            //act
            string actual = customer.FullName;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //vamos a probar la propiedad estatica que cuenta la cantidad de instanciaciones
            //arrange
            Customer.InstanceCount = 0; //recordemos que ya aumentamos el InstanceCount con los tests anteriores
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            var c2 = new Customer();
            c2.FirstName = "Frodo";
            var c3 = new Customer();
            c3.FirstName = "Rosie";
            //act
            //instanciarlo es lo que queremos hacer
            //assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
        [TestMethod]
        public void ValidateValid()
        {
            //probamos el validate con datos validos
            //arrange
            var customer = new Customer();
            customer.LastName = "Olkies";
            customer.EmailAdress = "ilan@kinetica-solution.com";
            var expected = true;
            //act
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //probamos el validate con un dato invalido
            //arrange
            var customer = new Customer();
            customer.EmailAdress = "ilan@kinetica-solution.com";
            var expected = false;
            //act
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(actual, expected);
        }
    }
}
