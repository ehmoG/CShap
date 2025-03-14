using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LineSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string[] color = { "red", "blue", "Green" };
        IEnumerable<string> sort = color.OrderBy(s => s);
        foreach(var co in sort)
        {
            Debug.Log(co);
        }
    }
}
