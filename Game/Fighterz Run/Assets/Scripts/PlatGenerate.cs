using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatGenerate : MonoBehaviour {
    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;
    private float platformWidth;

	// Use this for initialization
	void Start () {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
