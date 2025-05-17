using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;
//using System.Debug;

public class AnimationSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    //public Slider slider;

    public Animator animator;
    private float time;
    private bool isTrigger=true;
    private bool isInTrigger = false;
    private float currentAntime;
    private float time_slider;
    void Start()
    {
        
        animator = GetComponent<Animator>();

        //slider = slider.GetComponent<Slider>();
        
        animator.speed = 0.5f;
        //currentAntime = animator.GetCurrentAnimatorClipInfo(0)[0].clip.length;
        //time_slider = 1 / currentAntime;
        //slider.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;
        if (time > 0.001 && isTrigger)
        {
            animator.enabled = false;

        }
        if (isInTrigger)
        {
            if (Keyboard.current.qKey.wasPressedThisFrame)
            {
                isTrigger = false;
                animator.enabled = true;
                //slider.enabled = true;

            }

        }
        else
        {
            if (Keyboard.current.qKey.wasPressedThisFrame)
            {
                isTrigger = true;
                animator.enabled = false;
                //slider.enabled = true;

            }

        }
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            animator.Play("pusa",0,0f);
           
        }
        if (Keyboard.current.rKey.wasPressedThisFrame)
        {
            animator.Play("building", 0, 0f);

        }
        

    }
    void OnTriggerEnter(Collider other)
    {
        isInTrigger = true;
    }
    public void PusaEvent()
    {
        animator.Play("pusa", 0, 0f);
        // 在这里编写你希望在动画事件中执行的代码
        //Debug.Log("Pusa animation event called!");
    }
    public void sliderChanger()
    {
        //animator.Play("new-vase", -1, slider.normalizedValue);
    }
}
