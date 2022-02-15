using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public AudioSource letsGo;

    // Start is called before the first frame update
    void Start()
    {
	    letsGo = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
