using RPGM.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassField : MonoBehaviour
{
    private void Start()
    {
        Multiplication(20, 6);
    }
    /// <summary>
    /// 2D‚ÌN“ü”»’è‚Å‚·
    /// OnTriggerEnter2D‚ÍN“ü‚És‚¤”»’è‚Å‚·
    /// q/summaryr
    /// qparam name="characterCollider"rƒvƒŒƒCƒ„[‚ÌƒLƒƒƒ‰ƒNƒ^[q/paramr

    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;
    }

    /// <summary>
    /// 2D‚ÌN“ü”»’è‚Å‚·
    /// OntoriggerExit2D‚ÍN“ü‚µ‚Ä‚©‚ç”²‚¯‚Ä‚©‚ç‚Ì”»’è‚Å‚·
    /// </summary>
    /// qparam name="characterCollider"rƒvƒŒƒCƒ„[‚ÌƒLƒƒƒ‰ƒNƒ^[q/paramr
    void OnTriggerExit2D(Collider2D charactercollider)
    {
        charactercollider.GetComponent<CharacterController2D>().speed *= 2f;
    }




    public void Multiplication(int a, int b)
    { int MultiplicatinValue = a * b;
        Debug.Log(MultiplicatinValue);
    }
}
