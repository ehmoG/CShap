using UnityEngine;

public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int value = 8;
        value = +value;
        value = -8;
        value = +value;
        value = 8;
        value = -value;
        value = -8;
        value = -value;
    }
}
