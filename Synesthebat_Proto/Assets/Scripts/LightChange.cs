using UnityEngine;
using System.Collections;

public class LightChange : MonoBehaviour 
{

	public Light pointlight;
	public float intensity = 1.5f;
	public float range = 150f;


	void Start () 
	{
		pointlight = GetComponent<Light> ();
		pointlight.intensity = intensity;
		pointlight.range = range;

	}
	

	void Update () 
	{
		pointlight.intensity = pointlight.intensity - 0.001f;
		pointlight.range = pointlight.range - 0.1f;


	//	float A = Input.GetAxis ("BoutonA");

		if (Input.GetKey(KeyCode.Space))
		{
			pointlight.intensity = pointlight.intensity + 0.02f;
			pointlight.range = pointlight.range + 1f;

		}

	}
}
