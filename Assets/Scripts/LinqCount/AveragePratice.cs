using UnityEngine;

public class AveragePratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] d = { 90, 65, 78, 50, 95 };
        double a = 0;
        int c = 0, s = 0;

        for (int i = 0; i < d.Length; i++)
            if (d[i] > 70 && d[i] < 90)
            {
                s = s + d[i];
                c++;
            }
        if (c > 0)
            a = (double)s / c;

        Debug.Log(a);

    }
}
