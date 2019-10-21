using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Models;
namespace dotnet_code_challenge.Interfaces
{
    public interface IJSonReader
    {
        WolferHamptonHorseModel FetchData();
    }
}
