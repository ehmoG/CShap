using UnityEngine;

public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "ȫ�浿";
        int age = 20;
        if (name == "ȫ�浿")
            if (age == 20)
                Debug.Log($"�̸��� {name}, ���̴� {age}");
    }
}
