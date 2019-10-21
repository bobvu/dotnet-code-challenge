using System;
using System.Collections.Generic;
using System.Text;
using dotnet_code_challenge.Interfaces;
using dotnet_code_challenge.Implementations;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Implementations
{
    public class WolferHamptonParser : IParticipants
    {
        private WolferHamptonHorseModel model;
        public WolferHamptonParser(IJSonReader json)
        {
            try
            {
                model = json.FetchData();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public List<Participant> GetHorses()
        {
            List<Participant> participants = new List<Participant>();

            if (model.RawData != null)
            {
                try
                {
                    var markets = model.RawData.Markets;
                    markets.ForEach(market =>
                    {
                        market.Selections.ForEach(selection =>
                        {
                            var tags = selection.Tags;
                            var price = decimal.Parse(selection.Price.ToString());
                            var participant = new Participant
                            {
                                Name = tags.name,
                                Number = int.Parse(tags.participant),
                                Price = price
                            };
                            participants.Add(participant);

                        });
                    });
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            return participants;
            //throw new NotImplementedException();
        }
    }
}
