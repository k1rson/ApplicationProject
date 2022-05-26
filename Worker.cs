using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationProject
{
    public class Worker
    {
        public void Work()
        {
            for (int i = 0; i < 100; i++)
            {
                // поток пашет як сибирская кобыла 
                ProcessChanged(i); 
            }
        }
        public event Action<int> ProcessChanged;
    }
}
