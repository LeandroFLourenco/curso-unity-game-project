using Unity.VisualScripting;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    int moedas;

    void Start()
    {
        moedas = 10;        
    }

    void Update()
    {
        moedas += 1;

        if(moedas == 15)
        {
            print(moedas);
        }
    }
}
