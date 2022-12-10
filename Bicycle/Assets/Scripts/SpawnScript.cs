using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject cars;
    public Transform spawnpoint;
    
    


    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    
    void Repeat()
    {
      
      StartCoroutine(SpawnCD());
      
    }

    IEnumerator SpawnCD()
    {
       yield return new WaitForSeconds(2.2f);
       Instantiate(cars,spawnpoint.position,Quaternion.Euler(0,90,0));
       Repeat();
    }
}
