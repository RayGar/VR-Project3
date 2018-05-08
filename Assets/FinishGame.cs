using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour {

    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        Application.Quit();
    }
}
