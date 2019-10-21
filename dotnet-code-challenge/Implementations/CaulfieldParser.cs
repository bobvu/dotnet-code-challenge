using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Interfaces;
using dotnet_code_challenge.Models;
namespace dotnet_code_challenge.Implementations
{
    public class CaulfieldParser : IParticipants
    {
        private IXmlReader _xml;
        private CaufieldHorseModel _caulfieldHorse;
        public CaulfieldParser(IXmlReader xmlReader)
        {
           
            _caulfieldHorse = xmlReader.FetchData();
           
        }
        public List<Participant> GetHorses()
        {
            List<Participant> participants = new List<Participant>();
            var races = _caulfieldHorse.Races;
            if (races != null)
            {

                races.RaceList.ForEach(race =>
                {

                    var horses = race.Horses;
                    var prices = race.Prices.Price.HorsesWithPrice.HorseListWithPrice;
                    horses.HorseList.ForEach(horse =>
                    {

                        var price = prices.Find(item => item.Number == horse.Number).Price;
                        var participant = new Participant
                        {
                            Name = horse.Name,
                            Number = int.Parse(horse.Number),
                            Price = decimal.Parse(price)

                        };

                        participants.Add(participant);
                    });
                });

            }
            return participants;
        }
    }
}
