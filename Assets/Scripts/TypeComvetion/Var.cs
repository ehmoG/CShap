using UnityEngine;

public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "홍길동";
        var version = 8.0;
        var car = 1;


        Debug.Log("이름:" + name + "타입" + name.GetType());
        Debug.Log("version:" + version + "타입" + version.GetType());
        Debug.Log("car:" + car + "타입" + car.GetType());
    }
}
