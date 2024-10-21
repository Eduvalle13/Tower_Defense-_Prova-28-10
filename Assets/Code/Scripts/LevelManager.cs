using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{
    public static LevelManager principal;//Armazena uma inst�ncia est�tica do LevelManager, permitindo que outras classes acessem facilmente as informa��es do n�vel.

    public Transform pontoInicial;//Representa o ponto inicial do caminho, ou seja, o local onde os inimigos come�am a se mover.
    public Transform[] caminho;//Um array de Transform que define o caminho que os inimigos devem seguir, com cada elemento representando um waypoint.

    private void Awake()
    {
        principal = this;//O objetivo deste m�todo � garantir que a inst�ncia do LevelManager seja atribu�da � vari�vel est�tica principal. Isso estabelece um ponto de acesso global para o LevelManager, permitindo que outras partes do jogo acessem seus dados (como o caminho dos inimigos) sem precisar criar novas inst�ncias ou passar refer�ncias manualmente.

    }
    //Este script serve como o gerenciador de n�vel no jogo, armazenando e disponibilizando o ponto inicial e o caminho que os inimigos devem seguir. Atrav�s da vari�vel est�tica principal, ele facilita o acesso global �s informa��es necess�rias para que inimigos e outros sistemas do jogo possam funcionar corretamente. Em resumo, ele centraliza e disponibiliza os dados cr�ticos do n�vel para o restante do jogo.
}
