using UnityEngine;
using System.Collections;

public class avatar_movement : MonoBehaviour 
{

	public float speed = 10f;


	void Start()
	{

	}

	void Update () 
	{
		float translateX = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		float translateY = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;

		transform.Translate (0, 0, translateX);
		transform.Translate (translateY, 0, 0);
	}
}
