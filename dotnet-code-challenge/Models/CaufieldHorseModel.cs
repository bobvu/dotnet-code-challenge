using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace dotnet_code_challenge.Models
{
    [XmlRoot(ElementName = "meeting")]
    public class CaufieldHorseModel
    {

        [XmlElement(ElementName = "races")]
        public Races Races { get; set; }
    }

    [XmlRoot(ElementName = "horse")]
    public class Horse
    {
        [XmlElement(ElementName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

    }

    [XmlRoot(ElementName = "horses")]
    public class Horses
    {
        [XmlElement(ElementName = "horse")]
        public List<Horse> HorseList { get; set; }
    }

    [XmlRoot(ElementName = "horses")]
    public class HorsesWithPrice
    {
        [XmlElement("horse", typeof(HorseWithPrice))]
        public List<HorseWithPrice> HorseListWithPrice { get; set; }
    }

    [XmlRoot(ElementName = "horse")]
    public class HorseWithPrice
    {
        [XmlAttribute("number")]
        public string Number { get; set; }

        [XmlAttribute("Price")]
        public string Price { get; set; }
    }

    [XmlRoot(ElementName = "price")]
    public class Price
    {

        [XmlElement("horses", typeof(HorsesWithPrice))]
        public HorsesWithPrice HorsesWithPrice { get; set; }
    }

    [XmlRoot(ElementName = "prices")]
    public class Prices
    {
        [XmlElement(ElementName = "price")]
        public Price Price { get; set; }
    }

    [XmlRoot(ElementName = "race")]
    public class Race
    {

        [XmlElement(ElementName = "horses")]
        public Horses Horses { get; set; }
        [XmlElement(ElementName = "prices")]
        public Prices Prices { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
    }

    [XmlRoot(ElementName = "races")]
    public class Races
    {
        [XmlElement(ElementName = "race")]
        public List<Race> RaceList { get; set; }
    }
}
