using UnityEngine;
using System.Collections;

public class LightChange : MonoBehaviour 
{

	public Light pointlight;
	public float intensity = 1.5f;
	public float range = 150f;
	public bool lightUp = false;

	void Start () 
	{
		pointlight = GetComponent<Light> ();
		pointlight.intensity = intensity;
		pointlight.range = range;

	}
	

	void Update () 
	{

		if (Input.GetMouseButton (0)) {
			pointlight.intensity = pointlight.intensity + 0.02f;
			pointlight.range = pointlight.range + 1f;
			lightUp = true;
		} else {
			lightUp = false;
			if (pointlight.intensity > 0)
				pointlight.intensity = pointlight.intensity - 0.02f;
			if (pointlight.range > 20)
				pointlight.range = pointlight.range - 1f;
		}

	}
}
