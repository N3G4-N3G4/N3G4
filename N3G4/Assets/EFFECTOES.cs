using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EFFECTOES : MonoBehaviour
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
public void PRESSED()
    {
    	amin.SetBool("started", true);
    	amin.SetBool("ended", false);

    }
public void PRESSEDOFF()
	{
		amin.SetBool("ended", true);
		amin.SetBool("started", false);

	}
}
