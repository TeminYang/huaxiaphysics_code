using Photon.Pun.Demo.PunBasics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public int SceneChangeName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("���봥����: " + other.name);
        SceneManager.LoadScene(SceneChangeName);

        //// ʾ�������ʰȡ��Ʒ
        //if (other.CompareTag("Collectible"))
        //{
        //    Destroy(other.gameObject);
        //    GameManager.Instance.AddScore(10); // ��������Ϸ������
        //}
    }

    public void Scene_Change()
    {
        SceneManager.LoadScene(SceneChangeName);
    }
}
