using UnityEngine;

public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 85;
        string g = "��", s = "��", i = "��",None = "����", deffin;


        if (score >= 90)
            deffin = g;
        else
            if (score < 90 && score >= 80)
                deffin = s;
        else if (score < 80 && score >= 70)
            deffin = i;
        else
            deffin = None;
        Debug.Log($"({deffin})�� �����Ͽ����ϴ�.");
    }
}
