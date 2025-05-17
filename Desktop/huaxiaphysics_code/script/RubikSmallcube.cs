using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class RubikSmallcube : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3Int OffsetofCenter;

    public void setOffset(Axis axis, bool cw)//更新偏移量
    {
        switch (axis)
        {
            case Axis.None:
                break;
            case Axis.X:
                setXOffset(cw);
                break;
            case Axis.Y:
                setYOffset(cw);
                break;
            case Axis.Z:
                setZOffset(cw);
                break;
            default:
                break;
        }
    }
    private void setZOffset(bool cw)//更新Z轴偏移量
    {
        if (OffsetofCenter.x == 0 && OffsetofCenter.y == 0) return;
        if (OffsetofCenter.x == 0)
        {
            if (cw)
            {
                OffsetofCenter.x += OffsetofCenter.y;
            }
            else
            {
                OffsetofCenter.x -= OffsetofCenter.y;
            }
            OffsetofCenter.y = 0;
        }
        else if (OffsetofCenter.y == 0)
        {
            if (cw)
            {
                OffsetofCenter.y -= OffsetofCenter.x;
            }
            else
            {
                OffsetofCenter.y += OffsetofCenter.x;
            }
            OffsetofCenter.x = 0;
        }
        else
        {
            if (cw)
            {
                if (OffsetofCenter.x == OffsetofCenter.y)
                {
                    OffsetofCenter.y = -OffsetofCenter.x;
                }
                else
                {
                    OffsetofCenter.x = OffsetofCenter.y;
                }
            }
            else
            {
                if (OffsetofCenter.x == OffsetofCenter.y)
                {
                    OffsetofCenter.x = -OffsetofCenter.y;
                }
                else
                {
                    OffsetofCenter.y = OffsetofCenter.x;
                }
            }
        }
    }

    private void setYOffset(bool cw)
    {
        if (OffsetofCenter.x == 0 && OffsetofCenter.z == 0) return;
        if (OffsetofCenter.x == 0)
        {
            if (cw)
            {
                OffsetofCenter.x += OffsetofCenter.z;
            }
            else
            {
                OffsetofCenter.x -= OffsetofCenter.z;
            }
            OffsetofCenter.z = 0;
        }
        else if (OffsetofCenter.z == 0)
        {
            if (cw)
            {
                OffsetofCenter.z -= OffsetofCenter.x;
            }
            else
            {
                OffsetofCenter.z += OffsetofCenter.x;
            }
            OffsetofCenter.x = 0;
        }
        else
        {
            if (cw)
            {
                if (OffsetofCenter.x == OffsetofCenter.z)
                {
                    OffsetofCenter.z = -OffsetofCenter.x;
                }
                else
                {
                    OffsetofCenter.x = OffsetofCenter.z;
                }
            }
            else
            {
                if (OffsetofCenter.x == OffsetofCenter.z)
                {
                    OffsetofCenter.x = -OffsetofCenter.z;
                }
                else
                {
                    OffsetofCenter.z = OffsetofCenter.x;
                }
            }
        }
    }

    private void setXOffset(bool cw)
    {
        if (OffsetofCenter.y == 0 && OffsetofCenter.z == 0) return;
        if (OffsetofCenter.y == 0)
        {
            if (cw)
            {
                OffsetofCenter.y -= OffsetofCenter.z;
            }
            else
            {
                OffsetofCenter.y += OffsetofCenter.z;
            }
            OffsetofCenter.z = 0;
        }
        else if (OffsetofCenter.z == 0)
        {
            if (cw)
            {
                OffsetofCenter.z += OffsetofCenter.y;
            }
            else
            {
                OffsetofCenter.z -= OffsetofCenter.y;
            }
            OffsetofCenter.y = 0;
        }
        else
        {
            if (cw)
            {
                if (OffsetofCenter.y == OffsetofCenter.z)
                {
                    OffsetofCenter.y = -OffsetofCenter.z;
                }
                else
                {
                    OffsetofCenter.z = OffsetofCenter.y;
                }
            }
            else
            {
                if (OffsetofCenter.y == OffsetofCenter.z)
                {
                    OffsetofCenter.z = -OffsetofCenter.y;
                }
                else
                {
                    OffsetofCenter.y = OffsetofCenter.z;
                }
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
