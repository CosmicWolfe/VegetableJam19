using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject DialogPopup;
    public Text nameText;
    public Text dialogueText;
    public Image Img;
    public Sprite pic;
    //public Button Butt;

    //public Animator animator;

    private Queue<string> sentences;

	// Use this for initialization
	void Start () {
        DialogPopup.SetActive(false);
        sentences = new Queue<string>();
        nameText = DialogPopup.GetComponentsInChildren<Text>()[0];
        dialogueText = DialogPopup.GetComponentsInChildren<Text>()[1];
        Img = DialogPopup.GetComponentsInChildren<Image>()[1];
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Img.sprite = pic;
        DialogPopup.SetActive(true);
        FindObjectOfType<PlayerController>().freeze = true;

       // animator.SetBool("isOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
		

    public void DisplayNextSentence ()
    {
        if (sentences.Count==0){
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text=sentence;
    }

    void EndDialogue()
    {
        DialogPopup.SetActive(false);
        FindObjectOfType<PlayerController>().freeze = false;

        // animator.SetBool("isOpen", false);
    }
	
}
