using UnityEngine;

public class intprase : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string strnumber = "1234";

        int number2 = int.Parse(strnumber);
        int number3 = System.Int32.Parse(strnumber);
        int number1 = System.Convert.ToInt32(strnumber);

        Debug.Log($"{number1} - {number1.GetType()}");
        Debug.Log($"{number2} - {number2.GetType()}");
        Debug.Log($"{number3} - {number3.GetType()}");
    }
}
