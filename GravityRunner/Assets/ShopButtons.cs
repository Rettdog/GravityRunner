using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopButtons : MonoBehaviour
{

    public Button homeButton;
    public Button testButton;
    //bool sceneLoaded;
    SceneLoader loader;
    // Start is called before the first frame update
    void Start()
    {
        //loader = new SceneLoader();
        loader = (SceneLoader)SceneLoader.CreateInstance("SceneLoader");
        Debug.Log("ShopStart");
        homeButton.onClick.AddListener(HomeOnClick);
        testButton.onClick.AddListener(makeANewMethodYESSSSSSSSS);
        //loader.SetScene("Start");
    }

    
    public void HomeOnClick()
    {
        //Debug.Log("scoobyhome");
        loader.LoadScene(0);
        //SceneManager.LoadScene("Menu",0);
        //loader.SetScene(0);
        //SceneManager.SetActiveScene(SceneManager.GetSceneByName("Menu"));
        //LoadShop();
        
        //SetShop();
    }

    public void makeANewMethodYESSSSSSSSS()
    {
        Debug.Log("pls work");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
