using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimayionCam : MonoBehaviour
{
    private Animator camera_anim;
    private Camera camActive;
    public GameObject animationActive; 

    void Start()
    {
      //  camActive = GetComponent<Camera>();
        camera_anim = GetComponent<Animator>();
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
           camera_anim.SetBool("Blow",true);
        }

        camera_anim.SetBool("Blow", false);
    }
}
