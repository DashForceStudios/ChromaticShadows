using UnityEngine;
using System.Collections;

public class HeistObjectTrigger : MonoBehaviour {

	void OnTriggerEnter()
	{
        Renderer rend = GetComponent<Renderer>();
		rend.material.color = new Color(Color.red.r, Color.red.b, Color.red.g, 1f);
	}
}
