using UnityEngine;
using System.Collections;

public class LightChange : MonoBehaviour 
{
	public Light pointlight;
	public float intensity;
	public float range ;

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
		} else {
			if (pointlight.intensity > 0.5f)
				pointlight.intensity = pointlight.intensity - 0.02f;
			if (pointlight.range > 20)
				pointlight.range = pointlight.range - 1f;
		}
	}
}
