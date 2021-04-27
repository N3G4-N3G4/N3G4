using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class menugenerator : MonoBehaviour
{
	public Animator lkl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void shoped()
	{
		lkl.SetBool("shop", true);
	}
public void unshoped()
	{
		lkl.SetBool("shop", false);
	}
}
