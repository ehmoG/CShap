using Unity.VisualScripting;
using UnityEngine;

public class TryCatchDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {
            int now = System.DateTime.Now.Second;
            Debug.Log($"ÇöÀçÃÊ:{now}");
            int result = 2 / (now % 2);
            Debug.Log("È¦¼ö");
        }
        catch
        {
            Debug.Log("Â¦¼ö");
        }
    }
}
