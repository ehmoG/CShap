using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double d = 12.34;
        int i = 1234;
        d = i;
        Debug.Log("암묵적형식변환" + d);
        d = 12.34;
        i = 1234;
        i = (int)d;
        Debug.Log("명시적인형식변환" + i);
        string s = "";
        s = d.ToString();
        Debug.Log("다른 형식변환"+s);
    }
}
