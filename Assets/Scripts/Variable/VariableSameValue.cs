using UnityEngine;

public class VariableSameValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a, b, c;
        a = b = c = 10;
        Debug.Log(a + "," + b + "," + c);
    }
}
