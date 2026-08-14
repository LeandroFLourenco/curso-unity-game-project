using Unity.VisualScripting;
using UnityEngine;

public class variaveis : MonoBehaviour
{
    int estados = 1;
    

    void Start()
    {
        //if (estados == 1)
        //{
        //    print("Mate o heroi!");
        //}
        //else if (estados == 2)
        //{
        //    print("Mate se puder!");
        //}
        //else if (estados == 3)
        //{
        //    print("Corra!");
        //}
        //else
        //{
        //    print("Nenhum estado selecionado!");
        //}

        //    switch (estados)
        //    {
        //        case 1:
        //            print("Mate o heroi!");
        //            break;
        //        case 2:
        //            print("Mate se puder!");
        //            break;
        //        case 3:
        //            print("Corra!");
        //            break;
        //        default:
        //            print("Nenhum estado selecionado!");
        //            break;
        //    }

        for (int x = 0 ; (x > 0 && x <= 10); x++)
        {
            print("Hello World!" + " " + "-" + " " + x);
        }
    }

    void Update()
    {
        //moedas += 1;

        //if(moedas == 15)
        //{
        //    print(moedas);
        //}
    }
}
