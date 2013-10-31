using UnityEngine;
using System.Collections;

public class GUIController : MonoBehaviour
{
  [SerializeField] private UILabel leveLabel = null;

  private void Awake()
  {
    if (leveLabel != null)
      leveLabel.text = string.Format("Level: {0}", (Application.loadedLevel + 1));
  }
}
