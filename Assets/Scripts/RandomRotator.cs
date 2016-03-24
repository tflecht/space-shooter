using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {

	public float tumble;

	private Rigidbody rg;

	void Start ()
	{
		rg = GetComponent<Rigidbody> ();
		rg.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
