using UnityEngine;
using System.Collections;

public class GenerateElement : MonoBehaviour
{

    public Transform water;
    public Transform fire;
    public Transform earth;
    public float createHeight = 4f;
    public float X = 10f;
    public float createRate = 5.0f;
    public Transform obup;
    public Transform obdown;
    void Start()
    {
        Random.seed = System.Guid.NewGuid().GetHashCode();
        //2秒後開始，之後每createRate秒產生
        InvokeRepeating("CreateEnemy", 2f,2.35f);
        
    }

    void CreateEnemy()
    {
        int i = Random.Range(0, 3);
        Transform element1;
        Transform element2;
        Transform element3;
        if (i == 0)
        {
            element1 = water;
            element2 = fire;
            element3 = earth;
        }
        else
        {
            if (i == 1)
            {
                element1 = fire;
                element2 = earth;
                element3 = water;
            }
            else
            {
                element1 = earth;
                element2 = water;
                element3 = fire;
            }
        }
        int k = Random.Range(0,13);

        switch (k)
        {
            case 12:
                Instantiate(element1, new Vector3(X, 2, 0f), element1.rotation);
                Instantiate(element2, new Vector3(X+3, 2, 0f), element2.rotation);
                Instantiate(element3, new Vector3(X + 6, 2, 0f), element3.rotation);
                Instantiate(element1, new Vector3(X + 9, 2, 0f), element1.rotation);
                Instantiate(element2, new Vector3(X + 12, 2, 0f), element2.rotation);
                Instantiate(element3, new Vector3(X +15, 2, 0f), element3.rotation);
                break;
            case 11:
                Instantiate(obup, new Vector3(X+3 , 4.5f, 0f), obup.rotation);
                Instantiate(obup, new Vector3(X + 9, 4.5f, 0f), obup.rotation);
                Instantiate(element1, new Vector3(X , 4, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X+3 , 2, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X +6, 4, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X +9, 2, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X +12, 4, 0f), element1.rotation);
                break;
            case 10:
                
                Instantiate(obdown, new Vector3(X +5, -3, 0f), obdown.rotation);
                Instantiate(obdown, new Vector3(X, -3, 0f), obdown.rotation);
             
                break;
            case 9:
                Instantiate(element1, new Vector3(X, 4, 0f), element1.rotation);
                Instantiate(element2, new Vector3(X + 4, 0, 0f), element2.rotation);
                Instantiate(element1, new Vector3(X + 8, 4, 0f), element1.rotation);
                Instantiate(element2, new Vector3(X + 12, 0, 0f), element2.rotation);

                break;
            case 8:
                Instantiate(element1, new Vector3(X , 3, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 4, 3, 0f), element1.rotation);
                Instantiate(obdown, new Vector3(X +2, -3, 0f), obdown.rotation);
                Instantiate(element2, new Vector3(X + 8, -1, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 10, -2, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 12, -1, 0f), element2.rotation);

                break;
            case 7:
                Instantiate(element1, new Vector3(X+1, 1, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 5, 1, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 9, 1, 0f), element1.rotation);
                Instantiate(obup, new Vector3(X + 11, 4.5f, 0f), obup.rotation);
                Instantiate(obdown, new Vector3(X + 11, -3, 0f), obdown.rotation);
                Instantiate(obdown, new Vector3(X+3, -3, 0f), obdown.rotation);
                break;

            case 6:
                Instantiate(obdown, new Vector3(X+3, -3, 0f), obdown.rotation);
                Instantiate(obdown, new Vector3(X + 9, -3, 0f), obdown.rotation);
                Instantiate(element1, new Vector3(X , 0, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X +3, 1, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 6, 0, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 9, 1, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 12, 0, 0f), element1.rotation);


                break;
            case 5:
                Instantiate(element1, new Vector3(X, 4, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 6, 4, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 12, 4, 0f), element1.rotation);
                Instantiate(obdown, new Vector3(X+3, -3, 0f), obdown.rotation);
                Instantiate(obdown, new Vector3(X+9, -3, 0f), obdown.rotation);
                Instantiate(element2, new Vector3(X  , -1.5f, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 3, -0.5f, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 6, -1f, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 9, -0.5f, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 12, -1.5f, 0f), element2.rotation);

                /*
                   *  *  *

                    *  *
                  * 0 * 0  *
                
                */

              break;
            case 4:
                Instantiate(element1, new Vector3(X , 4, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 4, 3.5f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 8, 3.5f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 12, 4, 0f), element1.rotation);

                Instantiate(element2, new Vector3(X , -2, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 4, -2, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 8, -2, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X + 12, -2, 0f), element2.rotation);
                /*
                *****

                *****
                */
                break;
         case 3:
                Instantiate(obdown, new Vector3(X + 3, -3, 0f), obdown.rotation);
                Instantiate(obdown, new Vector3(X + 9, -3, 0f), obdown.rotation);
                Instantiate(obup, new Vector3(X+1, 4.5f, 0f), obup.rotation);
                Instantiate(obup, new Vector3(X + 11, 4.5f, 0f), obup.rotation);
                Instantiate(element1, new Vector3(X, -1.5f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 3, -0.5f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 6, -1f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X +9, -0.5f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X + 12, -1.5f, 0f), element1.rotation);
                /*
                    0   0
                    *   * 
                  * 0  * 0 *
                */

              break;
            case 2:
                Instantiate(element1, new Vector3(X, 4, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X+2, 4, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X+4, 4, 0f), element1.rotation);
                Instantiate(obup, new Vector3(X+7, 4.5f, 0f), obup.rotation);
                Instantiate(element2, new Vector3(X+1, -2, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X+3, -2, 0f), element2.rotation);
                Instantiate(obdown, new Vector3(X + 8, -3, 0f), obdown.rotation);
                Instantiate(element2, new Vector3(X+6, -1, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X+8, 0, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X+10, -1, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X +12, -2, 0f), element2.rotation);

                /*
                * * * 0

                      *
                * * * 0 *
                */
          break;
            case 1:

                Instantiate(obdown, new Vector3(X + 2, -3, 0f), obdown.rotation);
                Instantiate(obdown, new Vector3(X + 5, -3, 0f), obdown.rotation);
                Instantiate(element1, new Vector3(X+1, 3.5f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X +5, 3.5f, 0f), element1.rotation);
                Instantiate(element1, new Vector3(X +9, 3.5f, 0f), element1.rotation);

                Instantiate(obup, new Vector3(X + 12, 4.5f, 0f), obup.rotation);
                
                Instantiate(element2, new Vector3(X + 12, -2, 0f), element2.rotation);
                Instantiate(element2, new Vector3(X +15, -2, 0f), element2.rotation);
                break;
            default:
                break;


                /* Instantiate(element1, new Vector3(X, Random.Range(0, createHeight), 0f), element1.rotation);
             Instantiate(ob, new Vector3(X, -2f, 0f), ob.rotation);*/

        }
    }
}
