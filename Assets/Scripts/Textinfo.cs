using UnityEngine;


public class Textinfo : MonoBehaviour
{
  public TextMesh textblock;

  private void Start()
  {
    if (textblock != null)
      textblock.text += (Application.loadedLevel + 1).ToString() + "\n";
  }
}
