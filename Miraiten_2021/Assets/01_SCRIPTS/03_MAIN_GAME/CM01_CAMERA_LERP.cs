using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM01_CAMERA_LERP : MonoBehaviour
{
    public Transform middlePointTranform;
    public Transform rightPointTranform;
    public Transform leftPointTranform;

    Vector3 start;
    Vector3 end;

    float currentTimeLerp;
    float maxLerpTime = 1;

    void Awake()
    {
        start = middlePointTranform.position;
        end = rightPointTranform.position;

        currentTimeLerp = 0;
    }

    void LerpProcess()
    {
        float t = currentTimeLerp / maxLerpTime;

        if (t > 1)
        {
            t = 1;
        }

        Vector3 result = Vector3.Lerp(start, end, t);
        transform.position = result;

        if (currentTimeLerp >= maxLerpTime)
        {
            currentTimeLerp = 0;
        }
        else
        {
            currentTimeLerp += Time.deltaTime;
        }
    }
}
