using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Earth : MonoBehaviour {

    public GameObject Planet;

	// Use this for initialization
	void Start () {
        if (GetComponent<GameObject>())
            Planet = GetComponent<GameObject>();
        else
            Debug.LogError("Char need GameObject.");
    }
	
	// Update is called once per frame
	void Update () {

        Planet.transform.localRotation *= Quaternion.AngleAxis(Time.deltaTime *100, Vector3.up);
    }
}
