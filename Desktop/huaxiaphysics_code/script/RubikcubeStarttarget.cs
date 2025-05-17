using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RubikcubeStarttarget : MonoBehaviour
{
    // Start is called before the first frame update
    public bool rubikcube=false;
    void Start()
    {
        GameObject.Find("mofang").GetComponent<ImageTargetBehaviour>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rubikcube)
        {
            GameObject.Find("mofang").GetComponent<ImageTargetBehaviour>().enabled = true;
        }
        else
        {
            GameObject.Find("mofang").GetComponent<ImageTargetBehaviour>().enabled = false;
        }
        
    }
    public void rubikcubeimagetarget()
    {
        //rubikcube.SetActive(true);
        rubikcube = true;
    }
}
