using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {

    public GameObject WaterBeaker;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReplaceDryBeakerWithAWaterFilledBeaker()
    {
        GameObject.Instantiate(WaterBeaker, this.transform.position, Quaternion.identity);
        GameObject.Destroy(this.gameObject);
    }
}
