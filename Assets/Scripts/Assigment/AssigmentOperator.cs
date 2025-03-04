using UnityEngine;

public class AssigmentOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100, j = 200, tmp;
        Debug.Log($"i={i}" + $"j={j}");
        tmp = i;
        i = j;
        j = tmp;
        Debug.Log($"i={i}" + $"j={j}");
    }
}
