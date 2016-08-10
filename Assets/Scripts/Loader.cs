using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.ThirdPerson; // Also requires prototyping imports

public class Loader : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		// Load player and level
		GameObject arena = Instantiate (Resources.Load ("CubeArena", typeof(GameObject)), new Vector3(0f, 0f ,0f), Quaternion.identity) as GameObject;
		GameObject player = Instantiate (Resources.Load ("Player", typeof(GameObject)), new Vector3(-40f, 25f ,-15f), Quaternion.identity) as GameObject;
		GameObject heistObject = Instantiate (Resources.Load ("HeistObject", typeof(GameObject)), new Vector3(10f, 25f ,35f), Quaternion.identity) as GameObject;
		
	}
}
