using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holding : MonoBehaviour {
    
	public SpriteRenderer SR;
	public string HeldItem;
    public Sprite Pic;
	public GameObject Thing;
    public GameObject EmptyBeaker;
    public GameObject WaterBeaker;

    // Use this for initialization
    void Start () {
		SR = this.gameObject.GetComponent<SpriteRenderer>();
		SR.enabled = false;
		HeldItem = null;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(1) && HeldItem != null) DropItem();
	}

	void DropItem() {
        if (HeldItem == "Beaker"){
            GameObject.Instantiate(EmptyBeaker, this.transform.position, Quaternion.identity);
        } else if (HeldItem == "Water Beaker") {
            GameObject.Instantiate(WaterBeaker, this.transform.position, Quaternion.identity);
        } else {
            GameObject drop = GameObject.Instantiate(Thing, this.transform.position, Quaternion.identity);
            Pickup P = drop.GetComponent<Pickup>();
            P.GetComponent<SpriteRenderer>().sprite = Pic;
            P.itemName = HeldItem;
        }
		HeldItem = null;
		SR.enabled = false;
	}

	public void BurnItem() {
		HeldItem = null;
		SR.enabled = false;
	}
}
