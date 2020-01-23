using MediatorPattern.Mediator;

using System;

namespace MediatorPattern.Models
{
    public abstract class ArmyIndividual
    {
        protected string _message = string.Empty;
        private readonly IMilitaryRadio _radio;
        public string Code { get; }

        public ArmyIndividual(string code, IMilitaryRadio radio)
        {
            Code = code;
            _radio = radio;
            _radio.RegisterArmyIndividual(this);
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                _radio.ReportToOthers(this);
            }
        }

        public virtual void ConfirmRecievedMessage(ArmyIndividual fromIndividual)
        {
            Console.WriteLine($"Recieved a message from code: {fromIndividual.Code}");
            Console.WriteLine(fromIndividual.Message);
        }

    }
}
