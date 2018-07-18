using UnityEngine;

namespace Assets.Scripts.Location {
    public class AndroidGpsManager : IGpsManager {
        private AndroidJavaObject _locationBridge;

        public AndroidGpsManager() {
            _locationBridge = new AndroidJavaObject("unity.location.LocationBridge");
        }

        public double Longtitude {
            get { return _locationBridge.Call<double>("getLongitude"); }
        }

        public double Latitude {
            get { return _locationBridge.Call<double>("getLatitude"); }
        }
    }
}
