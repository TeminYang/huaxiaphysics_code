using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubikcubeCamercontrol : MonoBehaviour
{

    public GameObject Rubikcubetarget;
    public float distance;
    [Range(0.1f, 20f)] public float Rollerssensitive = 4.0f;//滚轮灵敏度
    public float mindistance = 4f;
    public float maxdistance = 10f;

    public float Xvelocity;
    public float Yvelocity;
    private float x;
    private float y;
    float XRotation = 0;
    float YRotation = 0;
    private float XMouseRotation = 0;
    private float YMouseRotation = 0;
    private Touch oldTouch1; 
    private Touch oldTouch2; 

    public float minYRotation = 0;
    public float maxYRotation = 0;
    int cubeID;
    private bool IsChoiseRubikcube;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
        cubeID = LayerMask.NameToLayer("mofang");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {
        
            if (Input.touchCount == 1)
        {
            XMouseRotation = (Input.GetTouch(0).deltaPosition.x * Xvelocity - XMouseRotation) * Time.deltaTime * 10;
            YMouseRotation = (Input.GetTouch(0).deltaPosition.y * Yvelocity - YMouseRotation) * Time.deltaTime * 10;

            Ray Check_ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).deltaPosition);
            RaycastHit cube_target;
            if (Physics.Raycast(Check_ray.origin, Check_ray.direction, out cube_target, 100f, 1 << cubeID))
            {
                IsChoiseRubikcube = true;
            }
            else
            {
                IsChoiseRubikcube = false;
            }
        }

        if (Input.touchCount >1)
        {
            Touch newTouch1 = Input.GetTouch(0);
            Touch newTouch2 = Input.GetTouch(1);

            //点刚开始接触屏幕, 只记录，不做处理
            if (newTouch2.phase == TouchPhase.Began)
            {
                oldTouch2 = newTouch2;
                oldTouch1 = newTouch1;
                return;
            }
            float oldDistance = Vector2.Distance(oldTouch1.position, oldTouch2.position);
            float newDistance = Vector2.Distance(newTouch1.position, newTouch2.position);
            float offset = newDistance - oldDistance;
            float scaleFactor = offset / 100f;
            distance += scaleFactor;
            
        }
        
        if (Input.GetMouseButton(0))
        {
            XMouseRotation = (Input.GetAxis("Mouse X") * Xvelocity - XMouseRotation) * Time.deltaTime * 10;
            YMouseRotation = (Input.GetAxis("Mouse Y") * Yvelocity - YMouseRotation) * Time.deltaTime * 10;
            Ray Check_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit cube_target;
            if (Physics.Raycast(Check_ray.origin, Check_ray.direction, out cube_target, 100f, 1 << cubeID))
            {
                IsChoiseRubikcube = true;
            }
            else
            {
                IsChoiseRubikcube = false;
            }
        }
        else
        {
            XMouseRotation -= XMouseRotation * Time.deltaTime * 4;
            YMouseRotation -= YMouseRotation * Time.deltaTime * 4;
        }

        XRotation += (XMouseRotation - XRotation) * Time.deltaTime * 20;
        YRotation += (YMouseRotation - YRotation) * Time.deltaTime * 20;

        x += XRotation;
        y -= YRotation;

        y = angleLimitation(y, minYRotation, maxYRotation);

        distance -= Input.GetAxis("Mouse ScrollWheel") * Rollerssensitive;
        distance = Mathf.Clamp(distance, mindistance, maxdistance);

        if (!IsChoiseRubikcube)
        {
            Quaternion rotation = Quaternion.Euler(y, x, 0);
            transform.rotation = rotation;
            Vector3 position = rotation * new Vector3(0.0f, 3.0f, -distance) + Rubikcubetarget.transform.position;
            transform.position = position;
        }
        

    }

    float angleLimitation(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
