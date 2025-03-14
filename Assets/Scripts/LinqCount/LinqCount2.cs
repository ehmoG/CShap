using System.Linq;
using UnityEngine;

public class LinqCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool[] b = { true, false, true, false, true };

        Debug.Log(b.Count());

        Debug.Log(b.Count(i => i == true));
        Debug.Log(b.Count(j => j == false));
    }
}
