package unity.location;

import android.location.Location;
import android.location.LocationManager;
import com.unity3d.player.UnityPlayer;

public class LocationBridge {
    private LocationManager _manager;

    public LocationBridge() {
        _manager = UnityPlayer.currentActivity.getSystemService(LocationManager.class);
    }

    private Location getLastLocation() {
        if (_manager.isProviderEnabled(LocationManager.GPS_PROVIDER)) {
            return _manager.getLastKnownLocation(LocationManager.GPS_PROVIDER);
        }

        return null;
    }

    public double getLongitude() {
        Location location = getLastLocation();
        if (location != null) {
            return location.getLongitude();
        }

        return 0;
    }

    public double getLatitude() {
        Location location = getLastLocation();
        if (location != null) {
            return location.getLatitude();
        }

        return 0;
    }
}
