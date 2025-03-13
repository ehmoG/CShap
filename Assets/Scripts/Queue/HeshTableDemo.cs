using UnityEngine;
using System.Collections;
public class HeshTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hashtable hash = new Hashtable();

        hash[0] = "���ѹα�";
        hash["���̸�"] = "����Ư����";
        hash["���̸�"] = "������";

        Debug.Log(hash[0]);
        Debug.Log(hash["���̸�"]);
        Debug.Log(hash["���̸�"]);

        foreach (var item in hash.Keys) Debug.Log($"{item.ToString()}-{hash[item]}");
    }
}
