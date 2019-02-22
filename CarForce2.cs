using UnityEngine;

public class CarForce2 : MonoBehaviour 
{
	public float thrust;
	public Rigidbody rb;
	public Vector3 rbstart;
	public int restartNum;


	void Start() 
	{
		rb = GetComponent<Rigidbody>();
		rbstart = transform.position;
		print ("rbstart position is " + rbstart);
	}

// This is CarForce2 - Goes Westbound

	void FixedUpdate() 
	{
		rb.AddForce(-thrust,0,0,ForceMode.Force);

		if (rb.transform.position.x < restartNum)
		{ 
			rb.transform.position = rbstart;
			rb.velocity = Vector3.zero;
		}

	}
}



//psuedo-code
// if rb.position.x is < endPos.x then transform car to begPos x
// if rb.
//the car is beyond endPos, then move car to, begPos

//transform.position = new Vector3(0, 0, 0);