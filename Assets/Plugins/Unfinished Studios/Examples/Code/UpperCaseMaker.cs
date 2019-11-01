using UnityEngine;
using UnfinishedStudios;

public class UpperCaseMaker : MonoBehaviour
{
    [SerializeField]
    private string[] someStrings;

    private void Start()
    {
        //Make every string uppercase.
        Loops.Do(someStrings, ToUpperCase);
    }

    private static void ToUpperCase(string someString)
    {
        //Uppercase the string.
        someString = someString.ToUpper();
        Debug.Log(someString);
    }
}