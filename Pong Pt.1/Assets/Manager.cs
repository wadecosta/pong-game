using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private int player1score = 0;
    private int player2score = 0;

    public AudioSource winAudio;

    // Start is called before the first frame update
    void Start()
    {
	    winAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
	    if(transform.position.x > 12){
		    player1score++;
	    }
	    else if(transform.position.x < -12)
	    {
		    player2score++;
	    }

	    if((player1score == 11) || (player2score == 11))
	    {
		    winAudio.Play();
		    player1score = 0;
		    player2score = 0;

	    }
    }



}

