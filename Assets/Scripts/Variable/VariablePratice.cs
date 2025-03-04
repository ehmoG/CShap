using UnityEngine;

public class VariablePratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int v;
        string o;
        int[] reading = new int[] { 10, 20, 30 };
        string[] charting = new string[] { "frist", "second", "third" }; ;

        for (int i = 0; 0 < charting.Length; i++)
        {
            v = reading[i];
            o = charting[i];
            Debug.Log(o + " = " + v);
        }
        return ;
    }
}
