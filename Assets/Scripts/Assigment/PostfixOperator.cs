using UnityEngine;

public class PostfixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        Debug.Log(x++);
        Debug.Log(x);
        Debug.Log(++x);
    }
}
