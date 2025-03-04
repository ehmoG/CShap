using UnityEngine;

public class intTobyte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 255;
        byte y = (byte)x;
        Debug.Log("Int = 255 to Byte = " + y);
    }
}
