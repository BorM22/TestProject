using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bicycle : MonoBehaviour
{
    public GameObject gameObj;
    public float speedPedals = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        gameObj.transform.Rotate(0.0f + speedPedals,0.0f,0.0f);
    }
}
