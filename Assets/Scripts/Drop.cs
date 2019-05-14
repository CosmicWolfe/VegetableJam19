using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour {

	public GameObject splash;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -10.0f) GameObject.Destroy(this.gameObject);
	}

	private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.gameObject.name);
		if(other.gameObject.name == "Beaker(Clone)") {
			other.GetComponent<Bottle>().ReplaceDryBeakerWithAWaterFilledBeaker();
		}
	}
}
