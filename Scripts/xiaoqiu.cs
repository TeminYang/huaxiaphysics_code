using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class xiaoqiu : MonoBehaviour
{
    public GameObject targetObject; // ��Ҫ���ҵ�������
    public Rigidbody ballRigidbody; // С���Rigidbody���
    public float checkInterval = 0.5f; // �����
    public float detectionDistance = 5f; // ������

    private bool objectFound = false;

    void Start()
    {
        // ��ʼʱ��������
        if (ballRigidbody != null)
        {
            ballRigidbody.useGravity = false;
        }

        // ��ʼ���ڼ��
        InvokeRepeating("CheckForObject", 0f, checkInterval);
    }

    void CheckForObject()
    {
        if (objectFound || targetObject == null) return;

        // ������Ŀ������ľ���
        float distance = Vector3.Distance(transform.position, targetObject.transform.position);

        // ��������ڼ�ⷶΧ��
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
            Debug.Log("Ŀ���������ҵ�������������");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
