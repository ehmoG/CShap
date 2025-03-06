using UnityEngine;

public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";
        int age = 20;
        if (name == "홍길동")
            if (age == 20)
                Debug.Log($"이름은 {name}, 나이는 {age}");
    }
}
