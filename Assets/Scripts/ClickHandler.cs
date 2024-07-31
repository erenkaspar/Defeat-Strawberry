using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    public GameManager gameManager;
    void OnMouseDown() {
        if( gameObject.CompareTag("Strawberry")) {
            gameManager.AddScore();
        }
    }
}
