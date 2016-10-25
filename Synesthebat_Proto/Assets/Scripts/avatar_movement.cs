using UnityEngine;
using System.Collections;

public class avatar_movement : MonoBehaviour 
{

	public float speed = 10f;
	public float speedrotateH = 100f;
	public float speedrotateV = 100f;


	void Start()
	{

	}

	void Update () 
	{
		float translate = Input.GetAxis ("VerticalG") * speed * Time.deltaTime;
		float rotateH = Input.GetAxis ("HorizontalG") * speedrotateH * Time.deltaTime;
		float rotateV = Input.GetAxis ("VerticalD") * speedrotateV * Time.deltaTime;

		transform.Translate (0, 0, translate);
		transform.Rotate (0, rotateH, 0);
		transform.Rotate (rotateV, 0, 0);




	}
}
