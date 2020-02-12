using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int count = GameManager.clickCounter;
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.addCounter();
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                string name = hit.collider.gameObject.name;

                if (name == "Carbon")
                {
                    GameManager.clickCounter = 0;
                    GameManager.updateElementName('C');
                    GameManager.addCounter();
                    Debug.Log(GameManager.clickCounter + "ae");
                }

                if (name == "Hydrogen")
                {
                    GameManager.clickCounter = 0;
                    GameManager.updateElementName('H');
                    Debug.Log("Hydrogen was clicked");
                    GameManager.addCounter();
                    Debug.Log(GameManager.clickCounter);
                }

            }
        }

    }
}
