using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Introduce : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent palyEvent, pauseEvent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.K))
        //{
        //    palyEvent.Invoke();

        //}
    }


    private void OnTriggerEnter(Collider other)
    {
        palyEvent.Invoke();
        
    }

    private void OnTriggerExit(Collider other)
    {
        pauseEvent.Invoke();

    }

   
}
