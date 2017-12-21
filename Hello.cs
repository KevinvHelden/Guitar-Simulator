using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Hello : MonoBehaviour {

	public Text CollisionText;

	void Start () {
		CollisionText.text = "";
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("box"))
		{
			CollisionText.text = "Hello";
		}
	}
}
