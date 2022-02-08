using UnityEngine;

public class myTest : MonoBehaviour
{
    Vector vector1 = new Vector(2, 4);
    Vector vector2 = new Vector(2, 1);
    Vector vectorPlus;
    Vector vectorSubs;
    Vector vectorMulti;
    Vector vector1Nor;
    Vector vector2Nor;
    float magnitud1, magnitud2;
    void Start()
    {

        vectorPlus = vector1.add(vector2);
        vectorSubs = vector1.sub(vector2);
        vectorMulti = vector2.multi(3);
        magnitud1 = vector1.magni();
        magnitud2 = vector2.magni();
        vector1Nor = vector1.normalice();
        vector2Nor = vector2.normalice();
        Debug.Log("la magnitud del vector 1 es: " + magnitud1);
        Debug.Log("la magnitud del vector 2 es: " + magnitud2);
    }

    private void Update()
    {
        /*vector1.Draw();
        vector2.Draw();
        vectorPlus.Draw(vector1);
        vectorSubs.Draw(vector2);
        vector1Nor.Draw();
        vector2Nor.Draw();*/
    }
}
