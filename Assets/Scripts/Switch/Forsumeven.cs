using UnityEngine;

public class Forsumeven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int s = 1;
        int[] b, v;
        b = new int[5];
        v = new int[5];
        for (int i = 0; i <= 5; i++)
        {
            b[i] = s + i;
            v[i] = s + 4 - i;
            Debug.Log($"{b[i]}");
            Debug.Log($"{v[i]}");
        }
        
    }
}
