using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDetection : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RectViewDown()
    {
        gameObject.SetActive(true);
        audioSource.Play();
    }
    public void RectViewUp()
    {
        gameObject.SetActive(false);
        audioSource.Pause();
    }
}
