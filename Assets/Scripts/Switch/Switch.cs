using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int answer = 1;
        if (answer < 5)
            Debug.Log($"{answer}�� ���� �����߽��ϴ�.");
        else
            Debug.Log("�߸� �����߽��ϴ�.");
    }
}
