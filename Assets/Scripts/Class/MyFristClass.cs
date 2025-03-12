using UnityEngine;

public class MyFristClass : MonoBehaviour
{
    ClassMember member = new ClassMember(); ////인스턴스 메서드 호출
    void Start()
    { 
        ClassMember.staticMethod(); //정적 메서드 호출
        member.InstanceMethod(); //인스턴스 메서드 호출
    }
}
