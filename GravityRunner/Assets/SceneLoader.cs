using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : ScriptableObject
{
    public bool sceneLoaded;
    Scene shopScene;
    Scene menuScene;
    AsyncOperation async;
    public SceneLoader()
        
        
    {

    }
    // Start is called before the first frame update
    public void Start()
    {
        shopScene = SceneManager.GetSceneByName("Shop");
        menuScene = SceneManager.GetSceneByName("Menu");
        Debug.Log("loader online");
    }
    
    // Load the Scene when this Button is pressed
    public void LoadScene(int scene)
    {
        Debug.Log(SceneManager.GetSceneByBuildIndex(scene).isLoaded);
        // Check that the Scene hasn't been added yet
        if (!SceneManager.GetSceneByBuildIndex(scene).isLoaded)
        {
            Debug.Log("Trying to load scene at build index "+scene);
            
            //Debug.Log(SceneManager.GetSceneAt(scene).name);
            // Loads the second Scene
            SceneManager.LoadScene(scene);
            Debug.Log("Scene Loaded");
            //SceneManager.LoadSceneAsync(SceneManager.GetSceneByPath(scene).name,LoadSceneMode.Additive);
            //Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
            if (SceneManager.GetSceneByBuildIndex(scene).isLoaded)
            {
                Debug.Log("Scene at build index " + scene + " is successfully loaded");
            }
            else
            {
                Debug.Log("Failed to load scene at build index " + scene);
            }
        }
    }

    // Change the newly loaded Scene to be the active Scene if it is loaded
    public void SetScene(int scene)
    {
        if (SceneManager.GetSceneByBuildIndex(scene).isLoaded)
        {
            // Set Scene2 as the active Scene
            SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(scene));
            //SceneManager.SetActiveScene(SceneManager.GetSceneByName(SceneManager.GetSceneByName("Scenes/" + scene).name));
            Debug.Log("Active Scene : " + SceneManager.GetActiveScene().name);
        }
    }
    public void UnloadScene(int scene)
    {
        SceneManager.UnloadSceneAsync(scene);
    }
}
