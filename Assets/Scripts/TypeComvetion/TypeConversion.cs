using UnityEngine;

public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double d = 12.34;
        int i = 1234;
        d = i;
        Debug.Log("�Ϲ������ĺ�ȯ" + d);
        d = 12.34;
        i = 1234;
        i = (int)d;
        Debug.Log("����������ĺ�ȯ" + i);
        string s = "";
        s = d.ToString();
        Debug.Log("�ٸ� ���ĺ�ȯ"+s);
    }
}
