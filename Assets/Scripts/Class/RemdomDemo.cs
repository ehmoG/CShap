using UnityEngine;

public class RemdomDemo : MonoBehaviour
{
    System.Random random = new System.Random();
    void Start()
    {
        int o;
        bool C = false;
        int[] p = new int[6];

        for (int i = 0, j = 6; i < j; i++)
        {
            C = false;
            o = random.Next(1, 46);

            if (i > 0) for (j = 0; j < i; j++) if (p[j] == o) C = true;
            
            if (C == false) p[i] = o;
            
            else i--;
        }

        Debug.Log("로또번호: " + p[0] + ',' + p[1] + ',' + p[2] + ',' + p[3] + ',' + p[4] + ',' + p[5]);
    }
}
