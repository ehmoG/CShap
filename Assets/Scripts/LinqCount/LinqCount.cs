using UnityEngine;
using System.Linq;
public class LinqCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] s = { 1, 2, 3 };
        double av = s.Average();
        Debug.Log($"{av:#.##}");
    }
}
