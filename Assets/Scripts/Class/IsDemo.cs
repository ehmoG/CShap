using UnityEngine;

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object d ="dd";
        object t = 1;

        if (d is string) Debug.Log("����");
        if (t is int) Debug.Log("����");
    }
}
