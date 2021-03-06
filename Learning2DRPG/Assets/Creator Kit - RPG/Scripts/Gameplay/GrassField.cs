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
    /// 2Dの侵入判定です
    /// OnTriggerEnter2Dは侵入時に行う判定です
    /// 〈/summary〉
    /// 〈param name="characterCollider"〉プレイヤーのキャラクター〈/param〉

    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;
    }

    /// <summary>
    /// 2Dの侵入判定です
    /// OntoriggerExit2Dは侵入してから抜けてからの判定です
    /// </summary>
    /// 〈param name="characterCollider"〉プレイヤーのキャラクター〈/param〉
    void OnTriggerExit2D(Collider2D charactercollider)
    {
        charactercollider.GetComponent<CharacterController2D>().speed *= 2f;
    }




    public void Multiplication(int a, int b)
    { int MultiplicatinValue = a * b;
        Debug.Log(MultiplicatinValue);
    }
}
