using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class settinggenerator : MonoBehaviour
{
	public Animator lkl;
    public Animator lol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void setted()
	{
		lkl.SetBool("setting", true);
	}
public void unsetted()
	{
		lkl.SetBool("setting", false);
	}
public void config()
  {
        lol.SetBool("config", true);
  }
public void configoff()
  {
        lol.SetBool("config", false);
  }
}
