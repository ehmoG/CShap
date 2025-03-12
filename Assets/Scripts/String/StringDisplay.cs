using UnityEngine;

public class StringDisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var displayName = "";
        var firstName = "길동";
        var lastName = "홍";

        displayName = "이름: " + lastName + firstName;
        Debug.Log(displayName);

        displayName = string.Format("이름: {0}{1}", lastName, firstName);
        Debug.Log(displayName);
        
        displayName = $"이름: {lastName}{firstName}";
        Debug.Log(displayName);
    }
}
