using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Recipe_Finder_MAUI_APP.Services
{
    public interface IShakeService
    {

        public bool IsRunning();
        public void StartShakeService();
        public void StopShakeService();
        public void SubscribeToShakeEvent(EventHandler action);

    }
}
