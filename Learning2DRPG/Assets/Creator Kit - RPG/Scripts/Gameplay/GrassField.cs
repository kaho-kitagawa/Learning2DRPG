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
    /// 2D�̐N������ł�
    /// OnTriggerEnter2D�͐N�����ɍs������ł�
    /// �q/summary�r
    /// �qparam name="characterCollider"�r�v���C���[�̃L�����N�^�[�q/param�r

    void OnTriggerEnter2D(Collider2D characterCollider)
    {
        characterCollider.GetComponent<CharacterController2D>().speed *= 0.5f;
    }

    /// <summary>
    /// 2D�̐N������ł�
    /// OntoriggerExit2D�͐N�����Ă��甲���Ă���̔���ł�
    /// </summary>
    /// �qparam name="characterCollider"�r�v���C���[�̃L�����N�^�[�q/param�r
    void OnTriggerExit2D(Collider2D charactercollider)
    {
        charactercollider.GetComponent<CharacterController2D>().speed *= 2f;
    }




    public void Multiplication(int a, int b)
    { int MultiplicatinValue = a * b;
        Debug.Log(MultiplicatinValue);
    }
}
