using UnityEngine;

public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num;
        double su;
        bool flag;
        string str;
        char c;

        num = 1234;
        su = 3.14159;
        flag = true;
        str = "æ»≥Á«œººø‰";
        c = 'a';

        Debug.Log("num" + num + "su" + su + "flag" + flag + "string" + str + "char" + c);
    }
}
