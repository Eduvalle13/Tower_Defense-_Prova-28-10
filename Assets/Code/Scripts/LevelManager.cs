using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{
    public static LevelManager principal;

    public Transform pontoInicial;
    public Transform[] caminho;

    private void Awake()
    {
        principal = this;

    }
}
