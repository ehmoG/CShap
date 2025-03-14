using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class LinSortList : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] n = { 90, 65, 78, 50, 95 };

        IEnumerable<int> nber = n.Where(c => c > 90 && c % 5 == 0).ToList();

        foreach (var c in nber)
        {
            Debug.Log(c);
        }
    }
}
