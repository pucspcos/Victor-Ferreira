using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class change_level : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		//print("OLA");
		SceneManager.LoadScene("cena_fimdejogo");
	}

}
