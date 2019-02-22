// Play a sound when we hit an object with a big velocity
using UnityEngine;
using System.Collections;


public class CollideWithThings : MonoBehaviour 
{
	public static AudioSource audio;





	// Start
	void Start() 
	{
		audio = GetComponent<AudioSource>();
		StartCoroutine(MyCoroutine());
		gameObject.GetComponent<Renderer>().material.color = Color.white;
		print ("Color is set to white on cube");
	}


	// OnCollision
	void OnCollisionEnter(Collision collision) 
	{
		//good stuff actions on collision
		if (collision.gameObject.tag == "Player")
		{
			audio.Play ();
			print ("Collision Detected - Changed color to Red");
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
	}


	// OnExit
	void OnCollisionExit(Collision collision)
	{
		//on exit
		gameObject.GetComponent<Renderer>().material.color = Color.white;
		print ("On Exit - cube changed to white");
	}


	// Coroutine to initialize with timer
	IEnumerator MyCoroutine()
	{
		//This is a coroutine
		gameObject.GetComponent<Renderer>().material.color = Color.white;
		yield return new WaitForSeconds(3);    //Wait 3 seconds
		print("finished co-routine / changed to white");
	}




	// End

}

