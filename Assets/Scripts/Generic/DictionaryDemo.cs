using UnityEngine;
using System.Collections.Generic;
public class DictionaryDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IDictionary<string, string> data = new Dictionary<string, string>();

        data.Add("시", "서울특별시");
        data.Add("구", "강동구");
        data.Remove("시");

        data["동"] = "천호동";
        try
        {
            data["구"] = "강남구";
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
