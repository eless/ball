using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public sealed class Button : MonoBehaviour
{
  public GameObject door;
  public Button[] btns;
  

  //public event Action<bool> ImPressed;
  private bool state = false;
  private int ColliderCount = 0;
  private Vector3 startDoorPosition;

  private void Start()
  {
    startDoorPosition = door.transform.localPosition;
  }


  private void OnTriggerEnter(Collider other)
  {

    if (ColliderCount == 0)
    {
      transform.localPosition -= new Vector3(0, 0.3f, 0);
      renderer.material.color = new Color(1, 0, 0);

      foreach (var button in btns)
      {
        if (!Equals(button.transform.localPosition.y, transform.localPosition.y))
        {
          state = false;
          break;
        }
        else
        {
          state = true;
        }

      }
      if(state)
        door.transform.localPosition -= new Vector3(0, 1f, 0);

      //var handler = ImPressed;
      //if (handler != null)
      //{
      //  Debug.Log("go true!");
      //  state = true;
      //  handler(state);
      //}
    }
    ColliderCount++;
  }

  private void OnTriggerExit(Collider other)
  {
    ColliderCount--;
    if (ColliderCount == 0)
    {
      transform.localPosition += new Vector3(0, 0.3f, 0);
      renderer.material.color = new Color(0, 1, 0);
      door.transform.localPosition = startDoorPosition;
      //if (ImPressed != null)
      //{
      //  Debug.Log("go false!");
      //  state = false;
      //  ImPressed(state);
      //}
    }
  }
}
