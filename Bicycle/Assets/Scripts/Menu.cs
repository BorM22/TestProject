﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{ 

    public GameObject buttonMenu;
    public GameObject buttonNextLevel;
    

    void Start()
    {
        gameObject.SetActive(false);
    }
    
    public void menu()
    {
      SceneManager.LoadScene("menu");
    }
     public void nextLevel()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
