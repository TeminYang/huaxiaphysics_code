using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private Collider triggerCollider;

    void Awake()
    {
        // ��ȡVideoPlayer���
        videoPlayer = GetComponent<VideoPlayer>();

        // ��ȡCollider���
        triggerCollider = GetComponent<Collider>();

        // ȷ��VideoPlayer�����ڿ�ʼʱ�Զ�����
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
