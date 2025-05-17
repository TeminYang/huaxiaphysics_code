using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class xiaoqiu : MonoBehaviour
{
    public GameObject targetObject; // 需要被找到的物体
    public Rigidbody ballRigidbody; // 小球的Rigidbody组件
    public float checkInterval = 0.5f; // 检测间隔
    public float detectionDistance = 5f; // 检测距离

    private bool objectFound = false;

    void Start()
    {
        // 初始时禁用重力
        if (ballRigidbody != null)
        {
            ballRigidbody.useGravity = false;
        }

        // 开始定期检测
        InvokeRepeating("CheckForObject", 0f, checkInterval);
    }

    void CheckForObject()
    {
        if (objectFound || targetObject == null) return;

        // 计算与目标物体的距离
        float distance = Vector3.Distance(transform.position, targetObject.transform.position);

        // 如果物体在检测范围内
        if (distance <= detectionDistance)
        {
            objectFound = true;
            EnableGravity();
        }
    }

    void EnableGravity()
    {
        if (ballRigidbody != null)
        {
            ballRigidbody.useGravity = true;
            Debug.Log("目标物体已找到，重力已启用");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
