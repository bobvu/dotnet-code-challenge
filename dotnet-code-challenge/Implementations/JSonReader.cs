using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using dotnet_code_challenge.Interfaces;
using dotnet_code_challenge.Models;
using Newtonsoft.Json;

namespace dotnet_code_challenge.Implementations
{
    public class JSonReader : IJSonReader
    {
        private string _filePath;
        private StreamReader _stream;
        public JSonReader(string filePath)
        {
            _filePath = filePath;
        }

        public WolferHamptonHorseModel FetchData()
        {
            try
            {
                WolferHamptonHorseModel wolferHamptonHorse;
                using (_stream = new StreamReader(_filePath))
                {
                    var js = new JsonSerializer();
                    wolferHamptonHorse = (WolferHamptonHorseModel)js.Deserialize(_stream, typeof(WolferHamptonHorseModel));
                }
                return wolferHamptonHorse;
            }
            catch (JsonReaderException)
            {

                throw new InvalidOperationException("Serialization error: Wrong json format ");
            }
            catch (IOException)
            {
                throw new IOException("File path is wrong or File not found");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
