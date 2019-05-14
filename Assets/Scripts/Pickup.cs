using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	private CameraController CC;
	private Transform Cursor;
	private Holding Inventory;

	private Transform Player;
	public float pickupDist;
	public float clickDist;
	public string itemName;
	public string description;
	public GameObject Popup;
	public bool ShowPopup;

	public int SizeReq;

	private GameObject pointingArrow;

	// Use this for initialization
	void Start () {
		CC = Camera.main.GetComponent<CameraController>();
		Cursor = CC.Cursor;
		Inventory = CC.Inventory;
		Player = Camera.main.GetComponent<CameraController>().Player;
		pointingArrow = GetComponentInChildren<Bobble>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(CC.Size == SizeReq && Vector3.Distance(Player.transform.position, this.transform.position) < pickupDist) {
			pointingArrow.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log(Inventory.HeldItem);
			if (Inventory.HeldItem == null && Input.GetMouseButtonDown(0) && Vector3.Distance(Cursor.transform.position, this.transform.position) < clickDist) {
				if (ShowPopup) {
					GameObject pop = Instantiate(Popup);
                    pop.transform.localScale = new Vector3(0.033f * CC.SizeNow, 0.033f * CC.SizeNow, 1.0f);
					ItemPopup IP = pop.GetComponent<ItemPopup>();
					IP.title = itemName;
					IP.words = description;
					IP.Sp = GetComponent<SpriteRenderer>().sprite;
				}
				Inventory.HeldItem = itemName;
				Inventory.SR.sprite = GetComponent<SpriteRenderer>().sprite;
				Inventory.SR.enabled = true;
                Inventory.Pic = GetComponent<SpriteRenderer>().sprite;
				GameObject.Destroy(this.gameObject);
			}
		} else {
			pointingArrow.GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
