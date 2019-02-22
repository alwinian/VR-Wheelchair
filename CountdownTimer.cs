using UnityEngine;
using System.Collections;

public class CountdownTimer : MonoBehaviour 

{
	public float time = 30.0f;
	public static AudioSource alarmSound;
	public bool alarmOn; 
	TextMesh tm;


	// init
	void Start () 
	{
		tm = GetComponent<TextMesh>();
		alarmSound = GetComponent<AudioSource> ();
		alarmOn = false;
	}


	// each frame
	void Update ()
	{
		time -= Time.deltaTime;

		if (time < 0) {
			tm.text = ":(";
			tm.text.ToString ();
			tm.color = Color.red;
			//start coroutine
			StartCoroutine ("PlayAlarmCoRoutine");
			//alarmSound.Play ();
		} else {	
			//update timer with new number
			tm.text = Mathf.RoundToInt (time).ToString ();
		}


	
	} // end voic update



	//coroutine definiton
			
	IEnumerator PlayAlarmCoRoutine()
		{
		if (!alarmOn) // if alarmOn is false
			{
			//alarmSound.Play ();
			//print ("supposed to play sound");
			yield return new WaitForSeconds (2000);
			alarmOn = true;
			}
		}
		
}