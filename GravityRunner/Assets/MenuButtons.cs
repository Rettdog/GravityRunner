using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtons : MonoBehaviour
{
    
    public Button playButton, shopButton;
    public static bool loaded = false;
    //bool sceneLoaded;
    SceneLoader loader;

        // Start is called before the first frame update
    void Start()
    {
        //loader = new SceneLoader();
        loader=(SceneLoader) SceneLoader.CreateInstance("SceneLoader");
        loader.Start();
        //loader.SetScene(0);
        if (loaded == false)
        {
            loader.UnloadScene(1);
            loaded = true;
        }
        /*loader.LoadScene("Menu");
        while (!loader.sceneLoaded)
        {

        }
        loader.SetScene("Menu");*/
        playButton.onClick.AddListener(PlayOnClick);
        shopButton.onClick.AddListener(ShopOnClick);
        /*if (!loaded) {
            for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++) {
                Debug.Log(SceneManager.GetSceneByBuildIndex(i).name);
                SceneManager.LoadSceneAsync(i, LoadSceneMode.Single);
            }
            loaded = true;
        }*/
        
    }

    private void PlayOnClick()
    {
        Debug.Log("scoobyplay");
    }
    private void ShopOnClick()
    {
        //Debug.Log("scoobyshop");
        loader.LoadScene(1);
        //loader.SetScene(1);
        //LoadShop();
       // SetShop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
