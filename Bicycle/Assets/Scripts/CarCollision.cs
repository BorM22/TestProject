using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarCollision : MonoBehaviour
{
    GameObject gameObject;
    public void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
        
       
        Debug.Log("Enter To Collision Car");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
