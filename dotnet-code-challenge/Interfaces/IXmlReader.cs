using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Interfaces
{
    public interface IXmlReader
    {
        CaufieldHorseModel FetchData();
    }
}
