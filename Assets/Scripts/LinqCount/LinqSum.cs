using System.Linq;
using UnityEngine;

public class LinqSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] n = { 1, 2, 3 };
        int s = 0;
        s = n.Sum();
        Debug.Log($"{s}");
    }
}
