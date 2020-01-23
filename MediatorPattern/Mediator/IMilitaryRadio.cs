using MediatorPattern.Models;

namespace MediatorPattern.Mediator
{
    public interface IMilitaryRadio
    {
        void ReportToOthers(ArmyIndividual individual);
        void RegisterArmyIndividual(ArmyIndividual individual);
    }
}
