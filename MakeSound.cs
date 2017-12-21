using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    //Audiosource is nodig om een geluidsfragment af te kunnen spelen in een scene.
	public AudioSource SoundSource;

	//Een public variable van het geluidsfragment die in Unity gedefinieerd moet worden
	public AudioClip Sound;

    //Wanneer het object collide (botst) met een ander object die "set as trigger"
    //aan heeft staan.
	void OnTriggerEnter(Collider other) {

        //Stop het geluid voor het geval dat het al aan het spelen is,
        //dit gaat anders mis en speelt hij het geluid vaker tegelijk af.
        SoundSource.Stop();

        //Speelt het geluidje 1 keer af.
        SoundSource.PlayOneShot(Sound);

    }
}
