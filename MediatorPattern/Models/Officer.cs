using MediatorPattern.Mediator;

using System;

namespace MediatorPattern.Models
{
    public class Officer : ArmyIndividual
    {
        public Officer(string code, IMilitaryRadio radio) : base(code, radio)
        {
        }

        public override void ConfirmRecievedMessage(ArmyIndividual fromIndividual)
        {
            Console.WriteLine($"Officer {Code}: recieved a message...");
            base.ConfirmRecievedMessage(fromIndividual);
        }

    }
}
