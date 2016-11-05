using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class changing_scene : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
	
}
