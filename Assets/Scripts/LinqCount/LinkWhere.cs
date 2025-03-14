using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class LinkWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] n = { 1, 2, 3, 4, 5 };
        
        IEnumerable<int> nber = n.Where(c => c > 3 && c % 2 == 0).ToList();

        foreach(var c in nber)
        {
            Debug.Log(c);
        }
    }
}
