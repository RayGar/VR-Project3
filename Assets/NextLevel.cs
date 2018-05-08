using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{

    void OnTriggerEnter(Collider collider)
    { 
        Application.LoadLevel(Application.loadedLevel + 1);
       
    }
}
