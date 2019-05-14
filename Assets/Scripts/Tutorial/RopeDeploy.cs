using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeDeploy : MonoBehaviour
{

    public CameraController CC;
    public GameObject Player;
    public Holding Inventory;
    public GameObject RopeStringThingy;
    public float interactDist;

    // Start is called before the first frame update
    void Start()
    {
        CC = Camera.main.GetComponent<CameraController>();
        Player = CC.Player.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Inventory.HeldItem == "Rope" && CC.Size == 1 &&  Vector3.Distance(this.transform.position,Player.transform.position) < interactDist)
        {
            GameObject.Instantiate(RopeStringThingy);
            Inventory.BurnItem();
            GameObject.Destroy(this.gameObject);
        }
    }
}
