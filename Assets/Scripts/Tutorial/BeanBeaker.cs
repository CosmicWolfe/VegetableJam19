using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanBeaker : MonoBehaviour
{

    public GameObject Player;
    public GameObject Cursor;

    public GameObject Actual;
    public Animator Anim;
    public float distance;
    
    void Awake()
    {
        Actual = FindObjectOfType<aaaaaaaaa>().gameObject;
        Actual.GetComponent<SpriteRenderer>().enabled = false;
        Actual.GetComponents<Collider2D>()[0].enabled = false;
        Anim = Actual.GetComponent<Animator>();
        Player = Camera.main.GetComponent<CameraController>().Player.gameObject;
        Cursor = Camera.main.GetComponent<CameraController>().Cursor.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(this.transform.position.x - Actual.transform.position.x) < distance &&
            Mathf.Abs(this.transform.position.y - Actual.transform.position.y) < 6 &&
            Vector3.Distance(this.transform.position, Player.transform.position) < distance &&
            Player.GetComponentInChildren<Holding>().HeldItem == "Bean")
        {
            Actual.GetComponent<SpriteRenderer>().enabled = true;
            Actual.GetComponents<Collider2D>()[0].enabled = true;
            Anim.SetBool("Growing", true);
            Player.GetComponentInChildren<Holding>().BurnItem();
            GameObject.Destroy(this.gameObject);
        }
    }
}
