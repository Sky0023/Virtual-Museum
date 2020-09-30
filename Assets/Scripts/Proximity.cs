using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Proximity : MonoBehaviour
{
    public string newTitle;
    public string newAuthor;
    public string newDesc;
    public string newDate;
    private Transform other;
    private Text myTitle;
    private Text myAuthor;
    private Text myDesc;
    private Text imgDate;
    private float dist;
    private GameObject player;
    private GameObject message1;
    private GameObject message2;
    private GameObject message3;
    private GameObject message4;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        other = player.GetComponent<Transform>();
        message1 = GameObject.FindWithTag("ImageTitle");
        message2 = GameObject.FindWithTag("Author");
        message3 = GameObject.FindWithTag("Description");
        message4 = GameObject.FindWithTag("Date");
        myTitle = message1.GetComponent<Text>();
        myTitle.text = "";
        myAuthor = message2.GetComponent<Text>();
        myAuthor.text = "";
        myDesc = message3.GetComponent<Text>();
        myDesc.text = "";
        imgDate = message4.GetComponent<Text>();
        imgDate.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
           dist = Vector3.Distance(transform.position, other.position);
            print("Distance to player: " + dist);
            if (dist < 4)
            {
                myTitle.text = newTitle;
                myAuthor.text = newAuthor;
                myDesc.text = newDesc;
                imgDate.text = newDate;
            }
	    else{
	    	myTitle.text = "";
		myAuthor.text = "";
		myDesc.text = "";
                imgDate.text = "";
            }	
          
        }

    }
}
