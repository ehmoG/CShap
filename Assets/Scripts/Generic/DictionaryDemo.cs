using UnityEngine;
using System.Collections.Generic;
public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IDictionary<string, string> data = new Dictionary<string, string>();

        data.Add("��", "����Ư����");
        data.Add("��", "������");
        data.Remove("��");

        data["��"] = "õȣ��";
        try
        {
            data["��"] = "������";
        }
        catch(System.Exception ex)
        {
            Debug.Log(ex.Message);
        }
        foreach (KeyValuePair<string, string>i in data)
        {
            Debug.Log($"{i.Key}-{i.Value}");
        }
    }
}
