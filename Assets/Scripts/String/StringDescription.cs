using UnityEngine;

public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "hello World!";

        Debug.Log("�⺻" + message);
        
        Debug.Log("�빮��" + message.ToUpper());
        
        Debug.Log("�ҹ���" + message.ToLower());

        Debug.Log("�ٲٱ�" + message.Replace("hello", "�ȳ��ϼ���").Replace("World!", "����!"));
    }
}
