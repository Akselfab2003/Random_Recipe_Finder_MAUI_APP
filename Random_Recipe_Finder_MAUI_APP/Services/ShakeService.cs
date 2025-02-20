using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Recipe_Finder_MAUI_APP.Services
{
    public class ShakeService: IShakeService
    {
        private readonly IAccelerometer _accelerometer;
        private bool _isShakeServiceRunning = false;
        public ShakeService()
        {
            _accelerometer = Accelerometer.Default;
        }

        public bool IsRunning()
        {
            return _isShakeServiceRunning;
        }

        public void StartShakeService()
        {
            _isShakeServiceRunning = true;
            _accelerometer.Start(SensorSpeed.Default);
        }

        public void StopShakeService()
        {
            _isShakeServiceRunning = false;
            _accelerometer.Stop();
        }

        public void SubscribeToShakeEvent(EventHandler action)
        {
            _accelerometer.ShakeDetected += action;
        }

    }
}
