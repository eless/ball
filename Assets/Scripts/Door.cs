//using UnityEngine;
//using System.Collections;

//public sealed class Door : MonoBehaviour
//{
//    [SerializeField] private Button[] buttons;
//    private int countOfPressedButton = 0;

//    private void Awake()
//    {
//        foreach (var b in buttons)
//            b.ImPressed += ButtonPressed;
//    }

//    private void OnDestroy()
//    {
//        foreach (var b in buttons)
//            b.ImPressed -= ButtonPressed;
//    }

//  private void ButtonPressed(bool state)
//  {
//    if (state)
//    {
//      countOfPressedButton++;
//    }
//    else
//    {
//       countOfPressedButton--;
//    }

//    if (countOfPressedButton >= buttons.Length)
//    {
//      gameObject.transform.localPosition -= new Vector3(0, 1f, 0);
//    }
//    else
//    {
//      gameObject.transform.localPosition -= new Vector3(0, 1f, 0);
    
//    }

//  }

//}
