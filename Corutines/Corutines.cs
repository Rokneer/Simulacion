using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corutines : MonoBehaviour
{
    void Start()
    {
        Enumerable();
        var enumerator = Wait();
        StartCoroutine((string)enumerator);
    }

    private IEnumerable Wait()
    {
        int initial = 5;
        Debug.Log("Initial: " + initial);
        yield return new WaitForSeconds(5);
        initial += 5;
        Debug.Log("Initial: " + initial);
    }
    private void Enumerable()
    {
        int[] arr = { 1, 2, 3 };
        foreach (int i in arr) Debug.Log(i);
        Debug.Log("----------");

        foreach (int i in arr) Debug.Log(i);
        Debug.Log("----------");

        Collection collection = new Collection();
        foreach (string i in collection) Debug.Log(i);

        Debug.Log("----------");
        var easyEnum = EasyEnum();
        foreach (string i in easyEnum) Debug.Log(i);

        Debug.Log("----------");
        var enumerator = easyEnum.GetEnumerator();
        enumerator.MoveNext();
        Debug.Log(enumerator.Current);
        enumerator.MoveNext();
        Debug.Log(enumerator.Current);
        enumerator.MoveNext();
        Debug.Log(enumerator.Current);
    }
    private IEnumerable<string> EasyEnum()
    {
        yield return "Hola";
        yield return "Mundo";
        yield return "Zzz";
    }
}
class Collection : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        return new Enumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new Enumerator();
    }
}

class Enumerator : IEnumerator<string>
{
    public string Current => currentString;

    object IEnumerator.Current => currentString;

    int currentIndx = 0;
    string currentString;

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public bool MoveNext()
    {
        switch (currentIndx)
        {
            case 0: currentString = "Hola"; break;
            case 1: currentString = "Mundo"; break;
            case 2: currentString = "Zzz"; break;
        }

        ++currentIndx;
        if (currentIndx < 4) return true;
        else return false;
    }

    public void Reset()
    {
        throw new System.NotImplementedException();
    }
}
