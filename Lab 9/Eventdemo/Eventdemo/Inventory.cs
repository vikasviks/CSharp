using System;
using System.Collections.Generic;
using System.Text;

namespace Eventdemo
{
    public class Inventory
    {
        public void Subscribe(Clock theclock)
        {
            theclock.SecondChanged += new Clock.SecondChangeHandler(InventoryTimeHasChanged);
        }
        public void InventoryTimeHasChanged(object theclock,TimeInfoEventArgs ti)
        {
            Console.WriteLine("Inventor Time: {0}:{1}:{2}",
            ti.hour.ToString(),ti.minute.ToString(),ti.second.ToString());
        }
    }
}
