using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopBottomBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
	    if(collider.gameObject.name == "P1"){
		    Debug.Log("P1 Touched!");
	    }
	    /*else if(collider.GetComponent<P2>()){
		    Debug.Log("P2 Touched!");

	    }*/
    }
}
