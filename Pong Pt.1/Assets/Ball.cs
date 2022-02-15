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

    public byte player1_color = 255;
    public byte player2_color = 255;

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

	//AudioSource winner = GameObject.

	if(transform.position.x > 10){
		transform.position = new Vector3(0,0,0);
		player1score++;
		zoom = zoom + 0.025f;
		p1_text.SetText(player1score.ToString());
		player1_color -= 15;
		p1_text.color = new Color32(255, player1_color, 0, 255);
		Debug.Log("P1 Scored \nP1: " + player1score + " P2: " + player2score);
		Direction();
	}
	else if(transform.position.x < -10){
		transform.position = new Vector3(0,0,0);
		player2score++;
		zoom = zoom + 0.025f;
		p2_text.SetText(player2score.ToString());
                player2_color -= 15;
                p2_text.color = new Color32(255, player2_color, 0, 255);
		Debug.Log("P2 Scored \nP1: " + player1score + " P2: " + player2score);
		Direction();
	}

	if(player1score == 11){
		Debug.Log("Player 1 won \nThe Score was P1: " + player1score + " P2: " + player2score);
		Reset();
		player1_color = 255;
		player2_color = 255;
		p1_text.color = new Color32(255, player1_color, 0, 255);
		p2_text.color = new Color32(255, player1_color, 0, 255);

		//TODO look at this later
		p1_text.SetText("0");
		p2_text.SetText("0");
	}
	else if(player2score == 11){
		Debug.Log("Player 2 won \nThe Score was P1: " + player1score + " P2: " + player2score);
		Reset();
		player1_color = 255;
		player2_color = 255;
		p1_text.color = new Color32(255, player1_color, 0, 255);
                p2_text.color = new Color32(255, player2_color, 0, 255);

		//TODO look at this later
		p1_text.SetText("0");
                p2_text.SetText("0");
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
