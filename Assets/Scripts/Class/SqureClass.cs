using UnityEngine;

public class SqureClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = Squre.GetName();
        Debug.Log(name);
    }

}
