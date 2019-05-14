using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeDrop : MonoBehaviour
{

    public GameObject ROpe;
    public GameObject DialogPopup;
    public bool dialogstarted;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogPopup.activeInHierarchy && !dialogstarted) dialogstarted = true;
        if(!DialogPopup.activeInHierarchy && dialogstarted)
        {
            Instantiate(ROpe,this.transform.position,Quaternion.identity);
            GameObject.Destroy(this.gameObject);
        }
    }
}
