namespace Assets.Scripts.Location {
    public static class GpsManagerFactory {
        public static IGpsManager GetManager() {
            #if UNITY_ANDROID
                return new AndroidGpsManager();
            #else
                return new DummyGpsManager();
            #endif
        }
    }
}
