using UnityEngine;

public class StringPractice1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 3;
        string result = "홀수";
        Debug.Log($"{number}은(는) {result}입니다.");

    }
}
