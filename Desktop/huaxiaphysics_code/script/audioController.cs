using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioController : MonoBehaviour
{
    private AudioSource videoPlayer;
    private Collider triggerCollider;

    void Awake()
    {
        // 获取VideoPlayer组件
        videoPlayer = GetComponent<AudioSource>();

        // 获取Collider组件
        triggerCollider = GetComponent<Collider>();

        videoPlayer.playOnAwake = false;
        
    }

    void OnTriggerEnter(Collider other)
    {
        // 检测进入触发器范围的对象是否是人物（你可以根据需要进行修改）
        if (other.CompareTag("Player"))
        {
            // 如果视频没有在播放，则开始播放
            if (!videoPlayer.isPlaying)
            {
                videoPlayer.Play();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // 检测离开触发器范围的对象是否是人物（你可以根据需要进行修改）
        if (other.CompareTag("Player"))
        {
            // 如果视频正在播放，则暂停
            if (videoPlayer.isPlaying)
            {
                videoPlayer.Pause();
            }
        }
    }
}
