using MediatorPattern.Mediator;
using MediatorPattern.Models;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var radio = new MilitaryRadio();

            var soldier1 = new Soldier("A1", radio);
            var soldier2 = new Soldier("B6", radio);
            var soldier3 = new Soldier("N89", radio);
            var soldier4 = new Soldier("F57", radio);
            var soldier5 = new Soldier("M80", radio);
            var soldier6 = new Soldier("D13", radio);
            var soldier7 = new Soldier("S156", radio);
            var soldier8 = new Soldier("U108", radio);
            var soldier9 = new Soldier("P19", radio);
            var soldier10 = new Soldier("W14", radio);
            var officer = new Officer("OFF001", radio);

            soldier3.Message = "reporting for duty!!!";
        }
    }
}
