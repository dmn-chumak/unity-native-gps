using Assets.Scripts.Location;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts {
    public class Startup : MonoBehaviour {
        public void Start () {
            Text element = transform.Find("Text").GetComponent<Text>();

            try {
                IGpsManager manager = GpsManagerFactory.GetManager();

                element.text = string.Format(
                    "Longtitude: {0}\nLatitude: {1}",
                    manager.Longtitude,
                    manager.Latitude
                );
            } catch (Exception exc) {
                element.text = exc.Message;
            }
        }
    }
}
