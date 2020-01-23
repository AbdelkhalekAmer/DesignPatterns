using MediatorPattern.Mediator;

using System;

namespace MediatorPattern.Models
{
    public sealed class Soldier : ArmyIndividual
    {
        public Soldier(string code, IMilitaryRadio radio) : base(code, radio)
        {
        }

        public override void ConfirmRecievedMessage(ArmyIndividual fromIndividual)
        {
            Console.WriteLine($"Soldier {Code}: recieved a message...");
            base.ConfirmRecievedMessage(fromIndividual);
        }

    }
}
