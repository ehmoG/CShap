using Unity.VisualScripting;
using UnityEngine;

public class TryCathFirnallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5, y = 5, r =0;
        try
        {
            r = x / y;
            Debug.Log($"{x}/{y}={r}");
        }   
        catch
        {
            Debug.Log("���ܰ� �߻�");
        }
        finally
        {
            Debug.Log("���α׷�����");
        }
    }
}
