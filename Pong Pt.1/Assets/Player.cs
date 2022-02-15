using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    
    public bool isPlayer1;
    public float speed = 5f;

    public int score_difference;
    public bool p1_in_lead;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

	if((Ball.score_difference > 4) && (Ball.p1_in_lead == true)){
		if(isPlayer1)
        	{
                	transform.Translate(0f, Input.GetAxis("Vertical") * Time.deltaTime, 0f);

        	}
        	else
        	{
                	transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime * Time.deltaTime, 0f);
        	}

	}
	else if((Ball.score_difference > 4) && (Ball.p1_in_lead == false)){
		if(isPlayer1)
                {
                        transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime * Time.deltaTime, 0f);

                }
                else
                {
                        transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
                }
	}
	else{
        	if(isPlayer1)
		{
			transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);

		}
		else
		{
		transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
		}
	}




    }
    
}
