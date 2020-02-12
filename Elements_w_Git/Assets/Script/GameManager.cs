using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // public static int element;
    public static int clickCounter;
    public static char elementName;

    public static void addCounter()
    {
        clickCounter++;
    }
    public static void updateElementName(char e)
    {
        elementName = e;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
