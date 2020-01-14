using System;

namespace TemplatePattern
{
    public class SuvCarAction : CarActionTemplate
    {
        protected override void OnAccelarate()
        {

        }

        protected override void OnMove()
        {
            Console.WriteLine("Keep ur eyes on the road");
        }

        protected override void OnStart()
        {
            Console.WriteLine("Press special start engine button");
        }
    }
}
