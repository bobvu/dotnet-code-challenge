using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.IO;
using dotnet_code_challenge.Implementations;
namespace dotnet_code_challenge.Test
{
    public class Test_Readers: BaseTest
    {
        [Fact]
        public void WhenFilePathIsWrongOrFileNotFound_ReadersShouldRaise_IOException()
        {


            var exception1 = Record.Exception(() => new XmlReader(wrongPath).FetchData());
            Assert.IsType<IOException>(exception1);
            Assert.Equal("File path is wrong or File not found", exception1.Message);

            var exception2 = Record.Exception(() => new JSonReader(wrongPath).FetchData());
            Assert.IsType<IOException>(exception2);
            Assert.Equal("File path is wrong or File not found", exception2.Message);

        }

        [Fact]
        public void WhenFileFormatNotRight_ShouldRaise_InvaliOperationdException()
        {

            var exception1 = Record.Exception(() => new XmlReader(badFile).FetchData());
            Assert.IsType<InvalidOperationException>(exception1);
            Assert.Equal("Serialization error: Wrong xml format", exception1.Message);

            var exception2 = Record.Exception(() => new JSonReader(badFile).FetchData());
            Assert.IsType<InvalidOperationException>(exception1);
            Assert.Equal("Serialization error: Wrong json format ", exception2.Message);


        }
    }
}
