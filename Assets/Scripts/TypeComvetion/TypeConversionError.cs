using UnityEngine;

public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        long l = long.MaxValue;
        Debug.Log($"long°ª" + l);
        int i;
        i = ((int)l);
        

        Debug.Log("i°ª" + i);
        

    }
}
