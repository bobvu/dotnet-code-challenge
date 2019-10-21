using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Test
{
    public class BaseTest
    {
        protected readonly string xmlPath = @"..\..\..\FeedData\Caulfield_Race1.xml";
        protected readonly string jsonPath = @"..\..\..\FeedData\Wolferhampton_Race1.json";
        protected readonly string wrongPath = @"..\..\..\FeedData\SomeFile.dat";
        protected readonly string badFile = @"..\..\..\FeedData\BadFile.txt";
        protected WolferHamptonHorseModel wolferWithEmptydata;
        protected CaufieldHorseModel caulfieldModelWithEmptyData;

        public BaseTest()
        {
            caulfieldModelWithEmptyData = new CaufieldHorseModel
            {
                Races = new Races
                {
                    RaceList = new List<Race>()
                }
            };

            

            wolferWithEmptydata = new WolferHamptonHorseModel
            {
                RawData = new RawData()
                {
                    Markets = new List<Market>()
                    {
                        new Market()
                        {
                            Selections = new List<Selection>()
                        }
                    }
                }
            };
        }

    }
}
