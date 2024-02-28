using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScaler : MonoBehaviour
{
   [SerializeField] private float _ScaleFactor = 0.1f;

    void Update()
    {
        // Mărire la apăsarea tastei 'P'
        if (Input.GetKeyDown(KeyCode.P))
        {
            transform.localScale += new Vector3(_ScaleFactor, _ScaleFactor, _ScaleFactor);
        }

        // Micșorare la apăsarea tastei 'O'
        if (Input.GetKeyDown(KeyCode.O))
        {
            transform.localScale -= new Vector3(_ScaleFactor, _ScaleFactor, _ScaleFactor);
        }
    }
}
