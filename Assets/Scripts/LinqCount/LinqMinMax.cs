using UnityEngine;
using System.Linq;
public class LinqMinMax : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] n = { 1, 2, 3 };
        int min = 0, max = 0;

        Debug.Log($"{n.Min()}{n.Max()}");

    }
}
