using UnityEngine;
using System.Collections;
public class HeshTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hashtable hash = new Hashtable();

        hash[0] = "대한민국";
        hash["시이름"] = "서울특별시";
        hash["구이름"] = "강동구";

        Debug.Log(hash[0]);
        Debug.Log(hash["시이름"]);
        Debug.Log(hash["구이름"]);

        foreach (var item in hash.Keys) Debug.Log($"{item.ToString()}-{hash[item]}");
    }
}
