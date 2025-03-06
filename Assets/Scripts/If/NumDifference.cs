using UnityEngine;

public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string g = "금", s = "은", i = "동",None = "없음", deffin;


        if (score >= 90)
            deffin = g;
        else
            if (score < 90 && score >= 80)
                deffin = s;
        else if (score < 80 && score >= 70)
            deffin = i;
        else
            deffin = None;
        Debug.Log($"({deffin})를 수상하였습니다.");
    }
}
