using UnityEngine;

public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!!!");

        UnityEngine.Debug.Log("Hello unity!!!");

        Debug.Log("�����:" + 5);

        Debug.Log("�����:" + (5+10));

        Debug.Log("�����:" + 5 + 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
