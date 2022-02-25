using UnityEngine;

public class myTest : MonoBehaviour
{
    Vector vector1 = new Vector(2, 4);
    Vector vector2 = new Vector(2, 1);
    Vector vectorPlus;
    Vector vectorSubs;
    Vector vectorMulti;
    Vector vectorNor;
    float magni1, magni2;
    void Start()
    {

        vectorPlus = vector1.add(vector2);
        vectorSubs = vector1.sub(vector2);
        vectorMulti = vector2.multi(3);
        magni1 = vector1.magni();
        magni2 = vector2.magni();
        vectorNor = vector1.normalice();
        Debug.Log("la magnitud del vector 1 es: " + magni1);
        Debug.Log("la magnitud del vector 2 es: " + magni2);
    }

    private void Update()
    {
        /*vector1.Draw();
        vector2.Draw();
        vectorPlus.Draw(vector1);
        vectorSubs.Draw(vector2);
        vectorNor.Draw();*/
    }
}
