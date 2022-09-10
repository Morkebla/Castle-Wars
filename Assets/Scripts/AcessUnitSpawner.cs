using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcessUnitSpawner : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (CheckCastleClick())
        {
            OpenSpawnMenu();
        }
    }
    bool CheckCastleClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (MouseCursorOverCastle())
            {
                return true;
            }
        }
        return false;
    }
    void OpenSpawnMenu()
    {
        Debug.Log("SpawnMenuOpened");
    }
    bool MouseCursorOverCastle()
    {
        //Convert the mouse click from screen coordinates to world coordinates.
        Ray MouseInWorldRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Debug.DrawRay(MouseInWorldRay.origin, MouseInWorldRay.direction*100, Color.red, 30); Extremely usefull Debug Tool!!!

        RaycastHit hitInfo;
        if( Physics.Raycast(MouseInWorldRay, out hitInfo, 100.0f))
        {
            return hitInfo.transform.gameObject == gameObject;
        }

        return false;
    }
}
