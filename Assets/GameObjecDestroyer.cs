using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjecDestroyer : MonoBehaviour {

    private Ray ray;
    private RaycastHit hit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Click to destroy object help: https://answers.unity.com/questions/444374/destroy-a-single-prefab-with-a-click-.html
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 1000.0f) && Input.GetMouseButtonDown(0))
        {
            if (hit.collider.gameObject.tag != "Ignore")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
