using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using dotnet_code_challenge.Interfaces;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Implementations
{
    public class XmlReader : IXmlReader
    {

        private StreamReader _stream;
        private string _filePath; 
        public XmlReader(string filePath)
        {
            _filePath = filePath;
        }
        public CaufieldHorseModel FetchData()
        {
            try
            {
                CaufieldHorseModel caufieldHorse;

                using (_stream = new StreamReader(_filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(CaufieldHorseModel));
                    caufieldHorse= (CaufieldHorseModel)serializer.Deserialize(_stream);
                    
                }

                return caufieldHorse;
            }
            catch (InvalidOperationException)
            {

                throw new InvalidOperationException("Serialization error: Wrong xml format");
            }
            catch (IOException)
            {
                throw new IOException("File path is wrong or File not found");
            }
            catch (Exception)
            {
                throw;
            }

        }

       
    }
}
