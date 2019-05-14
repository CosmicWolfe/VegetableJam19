using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butt : MonoBehaviour
{

    public DialogueManager DM;
    // Start is called before the first frame update


    private void OnMouseDown()
    {
        DM.DisplayNextSentence();
    }
}
