using UnityEngine;

public class ClassMember
{
    public static void staticMethod()
    {
        Debug.Log("정적 메서드");
    }
    public void InstanceMethod()
    {
        Debug.Log("인스턴스 메서드");
    }
}
