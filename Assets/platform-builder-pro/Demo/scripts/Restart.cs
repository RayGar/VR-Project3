using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour{

	void OnTriggerEnter(Collider collider)
    {
        Application.LoadLevel(Application.loadedLevel);

        //this is how you move to the next scene: 
        //Application.LoadLevel(Application.loadedLevel);

        //player = GameObject.FindGameObjectWithTag("Player");
        //player.transform.position = new Vector3(-5, 100, 2);
    }
}