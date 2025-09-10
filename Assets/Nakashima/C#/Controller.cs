using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] InputAction action;
    public Vector2 leftStick;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // ゲームパッドの取得
        var gamePad = Gamepad.current;
        if (gamePad == null)
        {
            return;
        }

        leftStick = gamePad.leftStick.ReadValue();

        Debug.Log("leftStick" + leftStick.ToString());
    }
}
