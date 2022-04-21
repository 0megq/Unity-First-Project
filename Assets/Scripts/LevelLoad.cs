using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(AudioSource))]
public class LevelLoad : MonoBehaviour 
{
	[SerializeField]private string loadLevel;
	private int scenes;

	void Start()
	{
		scenes = SceneManager.sceneCountInBuildSettings;
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player")) {
			//AudioSource audio = GetComponent<AudioSource>();
			//audio.Play();
			int i = SceneManager.GetActiveScene().buildIndex;
			if (i + 1 < scenes)
				SceneManager.LoadScene (i + 1);
			else {
				SceneManager.LoadScene (0);
			}
		}
	}
}
