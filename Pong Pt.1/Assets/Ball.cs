using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{

    public float speed = 5f;
    public int player1score = 0;
    public int player2score = 0;
    public float zoom = 2f;

    public AudioSource hitAudio;

    //TextMeshPro p1_text = GameObject.FindWithTag("P1_Score_Text").GetComponent<TextMeshPro>();
    //TextMeshPro p2_text = GameObject.FindWithTag("P2_Score_Text").GetComponent<TextMeshPro>();



    // Start is called before the first frame update
    void Start()
    {
	    hitAudio = GetComponent<AudioSource>();
	    //hitAudio = gameObject.AddComponent<AudioSource>();
	    //
	    //TextMeshPro p1_text = GameObject.FindWithTag("P1_Score_Text").GetComponent<TextMeshPro>();
	    //TextMeshPro p2_text = GameObject.FindWithTag("P2_Score_Text").GetComponent<TextMeshPro>();

	    Direction();
    }

    // Update is called once per frame
    void Update()
    {
	TextMeshPro p1_text = GameObject.FindWithTag("P1_Score_Text").GetComponent<TextMeshPro>();
    	TextMeshPro p2_text = GameObject.FindWithTag("P2_Score_Text").GetComponent<TextMeshPro>();

	if(transform.position.x > 12){
		transform.position = new Vector3(0,0,0);
		player1score++;
		zoom = zoom + 0.025f;
		p1_text.SetText(player1score.ToString());
		Debug.Log("P1 Scored \nP1: " + player1score + " P2: " + player2score);
		Direction();
	}
	else if(transform.position.x < -12){
		transform.position = new Vector3(0,0,0);
		player2score++;
		p2_text.SetText(player2score.ToString());
		zoom = zoom + 0.025f;
		Debug.Log("P2 Scored \nP1: " + player1score + " P2: " + player2score);
		Direction();
	}

	if(player1score == 11){
		Debug.Log("Player 1 won \nThe Score was P1: " + player1score + " P2: " + player2score);
		Reset();
	}
	else if(player2score == 11){
		Debug.Log("Player 2 won \nThe Score was P1: " + player1score + " P2: " + player2score);
		Reset();
	}

        
    }

    void OnCollisionEnter(Collision collision) 
    {
	    hitAudio.Play();
    }

    public void Direction()
    {
	    float sx = Random.Range(0,2) == 0 ? -1 : 1;
            float sy = Random.Range(0,2) == 0 ? -1 : 1;
	    

            GetComponent<Rigidbody>().velocity = new Vector3(zoom * speed * sx, zoom * speed * sy, 0f);
    }

    void Reset(){
	    player1score = 0;
	    player2score = 0;
	    zoom = 2f;
    }

}
