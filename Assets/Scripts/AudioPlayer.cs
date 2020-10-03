using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    private GameObject  player;
    private Transform other1;
    private Transform other2;
    private float dist, dist1, dist2 = 0f;


    void Start(){
        player = GameObject.FindWithTag("Player");
        other1 = player.GetComponent<Transform>();
        other2 = audioSource.GetComponent<Transform>();
	audioSource.Stop();
    }


    void Update(){
        dist1 = Vector3.Distance(transform.position, other1.position);
        dist2 = Vector3.Distance(transform.position, other2.position);
        dist = Mathf.Abs(dist1-dist2);
	print("Distance to player: " + dist);
        if (dist<5 && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
	else{
	    audioSource.Stop();	
	}
	
    }
}
