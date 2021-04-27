using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lal : MonoBehaviour
{
	public Animator amin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Presser()
    {
    		amin.SetBool("blen" , true);
    }
     public void Presseroff()
    {
    		amin.SetBool("blen" , false);
    }
}
