using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    [SerializeField] private Texture2D DefaultCursor;
    [SerializeField] private Texture2D WaterCursor;
    [SerializeField] private Texture2D SunCursor;
    [SerializeField] private Texture2D WindCursor;

    public string whatCursor;

    private Vector2 cursorHotspot;

    // Start is called before the first frame update
    void Start()
    {
        cursorHotspot = new Vector2(DefaultCursor.width, DefaultCursor.height);
        Cursor.SetCursor(DefaultCursor, cursorHotspot, CursorMode.Auto);
        whatCursor = "default";
        Debug.Log(whatCursor);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cursorHotspot = new Vector2(DefaultCursor.width, DefaultCursor.height);
            Cursor.SetCursor(DefaultCursor, cursorHotspot, CursorMode.Auto);
            whatCursor = "default";
            Debug.Log(whatCursor);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cursorHotspot = new Vector2(WaterCursor.width / 2, WaterCursor.height / 2);
            Cursor.SetCursor(WaterCursor, cursorHotspot, CursorMode.Auto);
            whatCursor = "water";
            Debug.Log(whatCursor);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            cursorHotspot = new Vector2(SunCursor.width / 2, SunCursor.height / 2);
            Cursor.SetCursor(SunCursor, cursorHotspot, CursorMode.Auto);
            whatCursor = "sun";
            Debug.Log(whatCursor);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            cursorHotspot = new Vector2(WindCursor.width / 2, WindCursor.height / 2);
            Cursor.SetCursor(WindCursor, cursorHotspot, CursorMode.Auto);
            whatCursor = "wind";
            Debug.Log(whatCursor);
        }

    }
}
