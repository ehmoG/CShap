using UnityEngine;

public class MyFristClass : MonoBehaviour
{
    ClassMember member = new ClassMember(); ////�ν��Ͻ� �޼��� ȣ��
    void Start()
    { 
        ClassMember.staticMethod(); //���� �޼��� ȣ��
        member.InstanceMethod(); //�ν��Ͻ� �޼��� ȣ��
    }
}
