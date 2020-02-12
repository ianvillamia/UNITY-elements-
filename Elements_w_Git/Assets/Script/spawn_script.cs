using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_script : MonoBehaviour
{

    public GameObject object1;

    public GameObject object2;
    public void Spawn1(Vector3 position)
    {
        Instantiate(object1).transform.position = position;

    }
    public void Spawn2(Vector3 position)
    {
        Instantiate(object2).transform.position = position;

    }

    void Update()
    {
        char element = GameManager.elementName;
        int clickCounter = GameManager.clickCounter;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (Input.GetKeyDown(KeyCode.Mouse0) && element == 'C' && clickCounter > 1)
            {

                Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

                Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, object1.transform.position.z);
                Spawn1(adjustZ);
            }

            if (Input.GetKeyDown(KeyCode.Mouse0) && element == 'H' && clickCounter > 1)
            {

                Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

                Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, object1.transform.position.z);
                Spawn2(adjustZ);
            }

        }






    }
}
