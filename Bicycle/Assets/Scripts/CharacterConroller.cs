using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;


public class CharacterConroller : MonoBehaviour
{
    public static float speed = 2f;
    public  Rigidbody _rigidbody;
    public Animator animator;
    public FixedJoystick _joystick;
    public GameObject Handle;


    
    void Update()
    {
        
        if(Handle.transform.localPosition.x == 0 )
        {
        animator.SetBool("SpeedMinus", false);     
        animator.SetBool("SpeedPlus", false);    
        speed = 2f;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (Handle.transform.localPosition.x > 0)
        {
        animator.SetBool("SpeedMinus", false);      
        animator.SetBool("SpeedPlus", true);
        speed = 8f;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
         else if (Handle.transform.localPosition.x < 0)

        {
        animator.SetBool("SpeedPlus", false);     
        animator.SetBool("SpeedMinus", true);    
        speed = 0.5f;
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
      
    
    }
}
