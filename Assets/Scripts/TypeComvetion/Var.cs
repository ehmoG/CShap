using UnityEngine;

public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var name = "ȫ�浿";
        var version = 8.0;
        var car = 1;


        Debug.Log("�̸�:" + name + "Ÿ��" + name.GetType());
        Debug.Log("version:" + version + "Ÿ��" + version.GetType());
        Debug.Log("car:" + car + "Ÿ��" + car.GetType());
    }
}
