using UnityEngine;
using System.Collections;

public static class Vibration {

    // THIS SCRIPT IS FOR VIBRATION AND IS USED IN THE SCRIPT MAKE VIBRATION

        // BUT I FOUND OUT THAT SOME ANDRIOD DEVICES MAINLY WHAT WE USED RIGHT NOW 2018 - AMAZON FIRE 
        // DOES NOT SUPPORT VIBRATION IDK WHY SO IF YOU FOUND A WAY TO DO IT JUST REMOVE THIS BUT REMEMBER TO REPLACE SOME CODES IN THE LOGINMENU AND RESETPASS SCRIPT. OR MORE IF OTHER INTERNS ADDED. - Joseph

	#if UNITY_ANDROID && !UNITY_EDITOR
		public static AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
		public static AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
	#else
		public static AndroidJavaClass unityPlayer;
		public static AndroidJavaObject currentActivity;
		public static AndroidJavaObject vibrator;
	#endif

	public static void Vibrate() {
		if(isAndroid())
			vibrator.Call("vibrate");
		else
			Handheld.Vibrate();
	}
	
	public static void Vibrate(long milliseconds) {
		if(isAndroid())
			vibrator.Call("vibrate", milliseconds);
		else
			Handheld.Vibrate();
	}
	
	public static void Vibrate(long[] pattern, int repeat) {
		if(isAndroid())
			vibrator.Call("vibrate", pattern, repeat);
		else
			Handheld.Vibrate();
	}

	public static bool HasVibrator() {
		return isAndroid();
	}
	
	public static void Cancel() {
		if(isAndroid())
			vibrator.Call("cancel");
	}

	private static bool isAndroid() {
		#if UNITY_ANDROID && !UNITY_EDITOR
			return true;
		#else
			return false;
		#endif
	}
}