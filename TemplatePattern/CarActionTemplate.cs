using System;

namespace TemplatePattern
{
    public abstract class CarActionTemplate
    {
        public void Move()
        {
            CompleteSafeChecks();
            OnStart();
            OnAccelarate();
            OnMove();
            ReduceAcceleration();
        }

        // Hooks
        protected abstract void OnStart();
        protected abstract void OnAccelarate();
        protected abstract void OnMove();
        //----------------------------------------

        private void CompleteSafeChecks()
        {
            Console.WriteLine("Fasten seatbelts.");
            Console.WriteLine("Check gas gauge");
            Console.WriteLine("Check engine temperature guage.");
        }

        private void ReduceAcceleration()
        {
            Console.WriteLine("Reduce the acceleration to a stable speed that suits the road.");
        }

    }
}
