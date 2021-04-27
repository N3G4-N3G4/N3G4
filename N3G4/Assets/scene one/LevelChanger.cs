using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelChanger : MonoBehaviour {

	public Animator animator;

	public float transitionTime = 1f;

	
	// Update is called once per frame
	void Update () {

	}
	public void press()
	{
		FadeToNextLevel();
	}

	public void FadeToNextLevel ()
	{
		StartCoroutine(FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1));
	}

	IEnumerator FadeToLevel (int levelIndex)
	{
		animator.SetTrigger("FadeOut");
		
		yield return new WaitForSeconds(transitionTime);
		
		SceneManager.LoadScene(levelIndex);
	}
}
