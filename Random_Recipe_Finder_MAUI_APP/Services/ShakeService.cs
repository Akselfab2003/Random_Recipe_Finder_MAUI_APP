using Microsoft.Maui.Devices.Sensors;
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
        public ShakeService()
        {
            _accelerometer = Accelerometer.Default;
        }

        public bool IsRunning()
        {
            return _accelerometer.IsMonitoring;
        }

        public void StartShakeService()
        {
            if (_accelerometer.IsSupported)
            {
                if (!_accelerometer.IsMonitoring)
                {
                    _accelerometer.Start(SensorSpeed.Default);
                }
            }

        }

        public void StopShakeService()
        {
            if (_accelerometer.IsSupported)
            {
                if (_accelerometer.IsMonitoring)
                {
                    _accelerometer.Stop();
                }
            }
        }

        public void SubscribeToShakeEvent(EventHandler action)
        {
            _accelerometer.ShakeDetected += action;
        }

    }
}
