using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSpawner : MonoBehaviour {

    public GameObject spherePrefabVar;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Spawn", 0.0f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void Spawn()
    {
        // Random position help: https://answers.unity.com/questions/759219/spawn-a-gameobject-in-random-position-within-an-ar.html
        // Random color help: https://docs.unity3d.com/ScriptReference/Random.ColorHSV.html        
        Vector3 position = new Vector3(Random.Range(0.0F, 5.0F), 5, Random.Range(-5.0F, 5.0F));
        var go = Instantiate(spherePrefabVar, position, Quaternion.identity);
        go.GetComponent<Renderer>().material.color = Random.ColorHSV();
        Destroy(go, 5.0f);
    }
}
