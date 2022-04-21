using System.Collections;
using UnityEngine;

public class Trap : MonoBehaviour {
	public float delayTime;

	// Use this for initialization
	void Start () {
		StartCoroutine (Go ());
	}

	IEnumerator Go()
	{
		while(true)
		{
			gameObject.GetComponent<Animation>().Play ();
			yield return new WaitForSeconds(delayTime);
		}
	}
}
