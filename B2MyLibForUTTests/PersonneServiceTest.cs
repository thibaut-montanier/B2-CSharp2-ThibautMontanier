using B2MyLibForUT.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace B2MyLibForUTTests {
    public class PersonneServiceTest {


        [SetUp]
        public void setup() {

        }

        [Test]
        public void CreerMessage() {
            PersonneService ps = new PersonneService();
            string resultat = ps.CreerMessage();

        }
    }
}
