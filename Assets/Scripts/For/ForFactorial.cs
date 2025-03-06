using UnityEngine;

public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n=100, fact = 1;
        for (int i = 1; i <= n+1; i++)
            if (i%3==i%4)
                fact = i + fact;
        Debug.Log(fact);
    }
}