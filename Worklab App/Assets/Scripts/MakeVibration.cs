using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVibration : MonoBehaviour {

    // THIS SCRIPT IS TO CREATE VIBRATION FOR DEVICES.

	public void OnClickShortVibrate() {
		Vibration.Vibrate(100);
	}

	public void OnClickMediumVibrate() {
		Vibration.Vibrate(1000);
	}

	public void OnClickLongVibrate() {
		Vibration.Vibrate(5000);
	}
}