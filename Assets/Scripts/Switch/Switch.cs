using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int answer = 1;
        if (answer < 5)
            Debug.Log($"{answer}번 답을 선택했습니다.");
        else
            Debug.Log("잘못 선택했습니다.");
    }
}
