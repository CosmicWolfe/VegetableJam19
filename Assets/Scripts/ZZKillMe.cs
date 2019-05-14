using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZZKillMe : MonoBehaviour
{

    public Holding Inv;
    private Transform Cursor;
    public GameObject rips;

    // Start is called before the first frame update
    void Start()
    {
        rips.SetActive(false);
        Cursor = Camera.main.GetComponent<CameraController>().Cursor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Inv.HeldItem == "Scissors" && Input.GetMouseButtonDown(0) && Vector3.Distance(this.transform.position, Cursor.position) < 1)
        {
            GameObject.Destroy(this.gameObject);
            rips.SetActive(true);
            Inv.BurnItem();
        }
    }
}
