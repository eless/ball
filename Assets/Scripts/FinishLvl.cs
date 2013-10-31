using UnityEngine;
using System.Collections;

public class FinishLvl : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(Application.loadedLevel + 1 != Application.levelCount)
                Application.LoadLevel(Application.loadedLevel + 1);
            else
            {
                Application.LoadLevel(0);
            }

        }
    }
}
