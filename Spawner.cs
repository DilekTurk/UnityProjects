using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sphere; // The object to be spawned

    void Update()
    {
        // Creates a copy of the "sphere" object in the scene
        Instantiate(sphere);
    }

}
