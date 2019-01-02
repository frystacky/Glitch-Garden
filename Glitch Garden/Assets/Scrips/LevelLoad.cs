using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] int loadTime = 3;
    int currentSceneIndex;


    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;       //gets current scene from build index

        //load time for splash screen
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(loadTime);
        LoadNextScene();

    }

    //loads next scene
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
