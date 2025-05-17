using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform model;
    private Rigidbody rb;
    private Animator anim;

    [SerializeField] private Vector2 moveDir;
    [SerializeField] private Vector3 rootMotionVec;

    private void Awake()
    {
        model = transform.GetChild(0);
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        anim.avatar = model.GetComponent<Animator>().avatar;
    }

    private void Update()
    {
        moveDir.x = Input.GetAxis("Horizontal");
        moveDir.y = Input.GetAxis("Vertical");

        TransRotate();

        anim.SetFloat("speed",Mathf.Lerp(anim.GetFloat("speed"),moveDir.magnitude,0.2f));
    }

    private void FixedUpdate()
    {
        rb.position += model.forward * rootMotionVec.magnitude;
        rootMotionVec = Vector3.zero;
    }

    private void OnAnimatorMove()
    {
        Vector3 t = anim.deltaPosition;
        t.y = 0;
        rootMotionVec += t;
    }

    private void TransRotate() 
    {
        if (moveDir.magnitude < 0.1f)
            return;
        Vector3 f = Camera.main.transform.forward;
        Vector3 r = Camera.main.transform.right;
        f.y = 0;
        r.y = 0;
        model.forward = Vector3.RotateTowards(model.forward,f * moveDir.y + r * moveDir.x,30 * Time.deltaTime,0);
    }
}
