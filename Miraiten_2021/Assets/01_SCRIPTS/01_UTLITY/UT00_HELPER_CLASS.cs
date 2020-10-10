using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UT00_HELPER_CLASS 
{
    public static float LinearIntrepolation(float one, float two, float t)
    {
        float result = 0;

        result = one * (1 - t) + two * (t);

        return result;
    }

    public static Vector2 LinearIntrepolation(Vector2 one, Vector2 two, float t)
    {
        Vector2 tmp = new Vector2(0, 0);

        tmp = one * (1 - t) + two * (t);

        return tmp;
    }

    public static Vector3 LinearIntrepolation(Vector3 one, Vector3 two, float t)
    {
        Vector3 tmp = new Vector3(0, 0, 0);

        tmp = one * (1 - t) + two * (t);

        return tmp;
    }

    public static float QuadraticBezierCurves(float start, float controlPoint, float end, float t)
    {
        float result = 0;

        float oneMt = 1 - t;
        float oneMtU2 = oneMt * oneMt;

        float oneMtU2Xp0 = oneMtU2 * start;

        //2(1 - t) tP1
        float twoXoneMt = 2 * oneMt;
        float tXp1 = t * controlPoint;

        float twoXoneMtXtXp1 = twoXoneMt * tXp1;

        //t^2 P2
        float tU2 = t * t;
        float tU2Xp2 = tU2 * end;

        //P(t) = (1 - t)^2 P0 + 2(1 - t) tP1 + t^2 P2
        result = oneMtU2Xp0 + twoXoneMtXtXp1 + tU2Xp2;

        return result;
    }

    public static Vector2 QuadraticBezierCurves(Vector2 start, Vector2 controlPoint, Vector2 end, float t)
    {
        Vector2 result = new Vector2(0, 0);

        float oneMt = 1 - t;
        float oneMtU2 = oneMt * oneMt;

        Vector2 oneMtU2Xp0 = oneMtU2 * start;

        //2(1 - t) tP1
        float twoXoneMt = 2 * oneMt;
        Vector2 tXp1 = t * controlPoint;

        Vector2 twoXoneMtXtXp1 = twoXoneMt * tXp1;

        //t^2 P2
        float tU2 = t * t;
        Vector2 tU2Xp2 = tU2 * end;

        //P(t) = (1 - t)^2 P0 + 2(1 - t) tP1 + t^2 P2
        result = oneMtU2Xp0 + twoXoneMtXtXp1 + tU2Xp2;

        return result;
    }

    public static Vector3 QuadraticBezierCurves(Vector3 start, Vector3 controlPoint, Vector3 end, float t)
    {
        Vector3 result = new Vector3(0, 0, 0);

        float oneMt = 1 - t;
        float oneMtU2 = oneMt * oneMt;

        Vector3 oneMtU2Xp0 = oneMtU2 * start;

        //2(1 - t) tP1
        float twoXoneMt = 2 * oneMt;
        Vector3 tXp1 = t * controlPoint;

        Vector3 twoXoneMtXtXp1 = twoXoneMt * tXp1;

        //t^2 P2
        float tU2 = t * t;
        Vector3 tU2Xp2 = tU2 * end;

        //P(t) = (1 - t)^2 P0 + 2(1 - t) tP1 + t^2 P2
        result = oneMtU2Xp0 + twoXoneMtXtXp1 + tU2Xp2;

        return result;
    }

    public static float CubicBezierCurves(float start, float controlOne, float controlTwo, float end, float t)
    {
        float result = 0;

        //(1 - t)
        float oneMt = 1 - t;
        //(1 - t)^2
        float oneMtU2 = oneMt * oneMt;
        //(1 - t)^3
        float oneMtU3 = oneMt * oneMt * oneMt;
        //t^2
        float tU2 = t * t;
        //t^3
        float tU3 = tU2 * t;

        //(1 - t)^3 * P0
        float oneMtU3Mp0 = oneMtU3 * start;

        //3 * t * (1 - t)^2 * P1
        float threeXtXoneMtU2Xp1 = 3 * t * oneMtU2 * controlOne;

        //3 * t^2 * (1 - t) * P2
        float threeXtU2XoneMtXp2 = 3 * tU2 * oneMt * controlTwo;

        //t^3 * P3
        float tU3Xp3 = tU3 * end;

        //P(t) = (1 - t)^2 P0 + 2(1 - t) tP1 + t^2 P2 || 0 < t < 1
        result = oneMtU3Mp0 + threeXtXoneMtU2Xp1 + threeXtU2XoneMtXp2 + tU3Xp3;

        return result;
    }

    public static Vector2 CubicBezierCurves(Vector2 start, Vector2 controlOne, Vector2 controlTwo, Vector2 end, float t)
    {
        Vector2 result = new Vector2(0, 0);

        //(1 - t)
        float oneMt = 1 - t;
        //(1 - t)^2
        float oneMtU2 = oneMt * oneMt;
        //(1 - t)^3
        float oneMtU3 = oneMt * oneMt * oneMt;

        //t^2
        float tU2 = t * t;
        //t^3
        float tU3 = tU2 * t;

        //(1 - t)^3 * P0
        Vector2 oneMtU3Mp0 = oneMtU3 * start;

        //3 * t * (1 - t)^2 * P1
        Vector2 threeXtXoneMtU2Xp1 = 3 * t * oneMtU2 * controlOne;

        //3 * t^2 * (1 - t) * P2
        Vector2 threeXtU2XoneMtXp2 = 3 * tU2 * oneMt * controlTwo;

        //t^3 * P3
        Vector2 tU3Xp3 = tU3 * end;

        //P(t) = (1 - t)^2 P0 + 2(1 - t) tP1 + t^2 P2 || 0 < t < 1
        result = oneMtU3Mp0 + threeXtXoneMtU2Xp1 + threeXtU2XoneMtXp2 + tU3Xp3;

        return result;
    }

    public static Vector3 CubicBezierCurves(Vector3 start, Vector3 controlOne, Vector3 controlTwo, Vector3 end, float t)
    {
        Vector3 result = new Vector3(0, 0, 0);

        //(1 - t)
        float oneMt = 1 - t;
        //(1 - t)^2
        float oneMtU2 = oneMt * oneMt;
        //(1 - t)^3
        float oneMtU3 = oneMt * oneMt * oneMt;

        //t^2
        float tU2 = t * t;
        //t^3
        float tU3 = tU2 * t;

        //(1 - t)^3 * P0
        Vector3 oneMtU3Mp0 = oneMtU3 * start;

        //3 * t * (1 - t)^2 * P1
        Vector3 threeXtXoneMtU2Xp1 = 3 * t * oneMtU2 * controlOne;

        //3 * t^2 * (1 - t) * P2
        Vector3 threeXtU2XoneMtXp2 = 3 * tU2 * oneMt * controlTwo;

        //t^3 * P3
        Vector3 tU3Xp3 = tU3 * end;

        //P(t) = (1 - t)^2 P0 + 2(1 - t) tP1 + t^2 P2 || 0 < t < 1
        result = oneMtU3Mp0 + threeXtXoneMtU2Xp1 + threeXtU2XoneMtXp2 + tU3Xp3;

        return result;
    }

    public static float MapValue(float valueToCheck, float minRange, float maxRange, float minOutput, float maxOutput)
    {
        float result = 0;

        result = minOutput + ((maxOutput - minOutput) / (maxRange - minRange)) * (valueToCheck - minRange);

        return result;
    }
}
