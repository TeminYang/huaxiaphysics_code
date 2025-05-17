using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    private AudioSource videoPlayer;
    private Collider triggerCollider;

    void Awake()
    {
        // ��ȡVideoPlayer���
        videoPlayer = GetComponent<AudioSource>();

        // ��ȡCollider���
        triggerCollider = GetComponent<Collider>();

        videoPlayer.playOnAwake = false;
        
    }

    void OnTriggerEnter(Collider other)
    {
        // �����봥������Χ�Ķ����Ƿ����������Ը�����Ҫ�����޸ģ�
        if (other.CompareTag("Player"))
        {
            // �����Ƶû���ڲ��ţ���ʼ����
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // ����뿪��������Χ�Ķ����Ƿ����������Ը�����Ҫ�����޸ģ�
        if (other.CompareTag("Player"))
        {
            // �����Ƶ���ڲ��ţ�����ͣ
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
        }
    }
}
