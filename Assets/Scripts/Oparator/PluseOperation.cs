using UnityEngine;

public class PluseOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 10, j = 20, x = 5, y = 3;
        int k = i + j, z = x % y;

        float f = 3.14f, g = 3.14f;
        float e = f - g;

        long a = 100, b = 200;
        long c = a * b;

        double l = 1.5, m = 0.5;
        double n = l / m;

        Debug.Log(k);
        Debug.Log(e);
        Debug.Log(c);
        Debug.Log(n);
        Debug.Log(z);
    }
}
