/***
 * Author: Kameron Eaton
 * Created: 10-19-2022
 * Modified: NA
 * Description: Trigger for gate
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject doorObject;
    Animator animator;
    public string animParam;


    // Start is called before the first frame update
    void Start()
    {
        animator = doorObject.GetComponent<Animator>();
        Debug.Log(animator.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool(animParam, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            animator.SetBool(animParam, false);
        }
    }
}
