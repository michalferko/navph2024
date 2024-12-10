using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonClick : MonoBehaviour
{
    public void OnButtonClick()
    {
        Debug.Log("Button clicked!");
    }
}
