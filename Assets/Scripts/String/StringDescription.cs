using UnityEngine;

public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "hello World!";

        Debug.Log("기본" + message);
        
        Debug.Log("대문자" + message.ToUpper());
        
        Debug.Log("소문자" + message.ToLower());

        Debug.Log("바꾸기" + message.Replace("hello", "안녕하세요").Replace("World!", "세계!"));
    }
}
