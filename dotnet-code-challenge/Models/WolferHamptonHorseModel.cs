using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge.Models
{
    public class WolferHamptonHorseModel
    {
        public string FixtureId { get; set; }
        public DateTime Timestamp { get; set; }
        public RawData RawData { get; set; }
        public List<DummyClass> DummyList { get; set; }
    }

    public class DummyClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class SelectionTags
    {
        public string participant { get; set; }
        public string name { get; set; }
    }

    public class Selection
    {
        public string Id { get; set; }
        public double Price { get; set; }
        public SelectionTags Tags { get; set; }
    }

   

    public class Market
    {
        public List<Selection> Selections { get; set; }
    }

    public class RawData
    {
        public List<Market> Markets { get; set; }
    }
}
