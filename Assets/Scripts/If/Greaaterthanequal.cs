using UnityEngine;

public class Greaaterthanequal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int first = 5, second = 8;
        if (first >= second)
            Debug.Log($"{first}");
        else
            Debug.Log($"{second}");
    }
}
