using UnityEngine;

public class IfAnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int nunber = 1234;
        if (nunber == 1234 && nunber >= 1000) Debug.Log("t");
        if (nunber == 1234 || nunber <= 1000) Debug.Log("y");

    }
}
