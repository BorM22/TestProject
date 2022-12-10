using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinTrigger : MonoBehaviour
{

public GameObject buttonMenu;
public GameObject buttonNextLevel;
public GameObject winMenu;

public void OnTriggerEnter(Collider coll)
{
    if(coll.CompareTag("Player"))
    {
       
        winMenu.SetActive(true);
        buttonMenu.SetActive(true);
        buttonNextLevel.SetActive(true);
    Debug.Log("Win");
    }
}
}
