using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using dotnet_code_challenge.Models;
using dotnet_code_challenge.Interfaces;
using dotnet_code_challenge.Implementations;
using System.IO;
using Moq;

namespace dotnet_code_challenge.Test
{
    public class Test_Parsers:BaseTest
    {

        [Fact]
        public void Test_CaulFieldParser()
        {

        }

        [Fact]
        public void Test_CaulfieldParser()
        {
            var xmlReader = new XmlReader(xmlPath);
            var caulfieldParser = new CaulfieldParser(xmlReader);
            var caulfieldHorses = caulfieldParser.GetHorses();
            Assert.Equal("Advancing", caulfieldHorses[0].Name);
            Assert.Equal(4.2m, caulfieldHorses[0].Price);

            var xmlReaderWithBadPath = new XmlReader(wrongPath);
            var exception = Record.Exception(() => new CaulfieldParser(xmlReaderWithBadPath));
            Assert.IsType<IOException>(exception);
            Assert.Equal("File path is wrong or File not found", exception.Message);
        }

        [Fact]
        public void Test_WolferHapmtonParser()

        {
            var jsonReader = new JSonReader(jsonPath);
            var wolferHamptonParser = new WolferHamptonParser(jsonReader);
            var wolferHamptonHorses = wolferHamptonParser.GetHorses();
            Assert.Equal("Toolatetodelegate", wolferHamptonHorses[0].Name);
            Assert.Equal(10.0m, wolferHamptonHorses[0].Price);

            var jsonReaderWithBadPath = new JSonReader(wrongPath);
            var exception1 = Record.Exception(() => new WolferHamptonParser(jsonReaderWithBadPath));
            Assert.IsType<IOException>(exception1);
            Assert.Equal("File path is wrong or File not found", exception1.Message);


            //var xmlReader1 = new Mock<IXmlReader>();
            //xmlReader1.Setup(rpr => rpr.FetchData()).Returns(caulfieldModelWithEmptyData);
            //var exception2 = Record.Exception(() => new CaulfieldParser(xmlReader1.Object));
            //Assert.IsType<NullReferenceException>(exception2);
        }

    }
}
