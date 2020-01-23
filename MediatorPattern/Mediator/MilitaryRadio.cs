using MediatorPattern.Models;

using System.Collections.Generic;
using System.Linq;

namespace MediatorPattern.Mediator
{
    public class MilitaryRadio : IMilitaryRadio
    {
        private List<ArmyIndividual> _individuals = new List<ArmyIndividual>();
        public void RegisterArmyIndividual(ArmyIndividual individual)
        {
            _individuals.Add(individual);
        }

        public void ReportToOthers(ArmyIndividual callingIndividual)
        {
            foreach (var individual in _individuals.Where(x => x != callingIndividual))
            {
                individual.ConfirmRecievedMessage(callingIndividual);
            }
        }
    }
}
