using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Classe TorreArqueira : Defina uma torre m�gica

//Interface ITorreDano: classe TorreArqueira que implementa essa interface, o que indica que ela possui funcionalidades relacionadas a causar danos a inimigos
public class TorreArqueira : ITorreDano
{
    public string Nome { get; set; } // propriedade que armazena o nome da torre. Ela pode ser lida ou escrita por outras classes

    public TorreArqueira() //Inicializa uma inst�ncia da torre. O nome da torre � definido como "Atiradora". Toda vez que uma nova torre arqueira for criada, ela ter� esse nome.
    {
        Nome = "Atiradora";
    }
    public int Dano => 25; //Uma propriedade somente leitura (get), que retorna o valor fixo de 25. Esse valor representa o dano que a torre arqueira causa ao atacar inimigos.
    public float Alcance => 2; //Uma propriedade somente leitura (get), que define o alcance da torre como 2. Isso significa que a torre s� pode atacar inimigos que estejam a uma dist�ncia de 2 ou menos.

    public void Atacar(IDamageble alvo) //Esse � o m�todo principal da torre, que recebe como par�metro um inimigo ( alvo), que deve implementar uma interface IDamageble
    {
        if (alvo != null) //O m�todo primeiro verifica se o alvo � v�lido (ou seja, se n�o � null)
        {
            Debug.Log($"{Nome} ataca o inimigo com {Dano} de dano."); //Se o alvo for v�lido, ele registra no console (Debug.Log) uma mensagem que a torre est� atacando o inimigo com o valor de Dano

            alvo.TakeDamage(Dano); //Em seguida, o m�todo chama o TakeDamage(Dano)no alvo, o que aplica o dano ao inimigo.
        }
    }

    /*
     Este script define o comportamento de uma torre arqueira que ataca inimigos dentro do seu alcance. 
     A torre tem um nome ("Atiradora"), um dano fixo de 25 e um alcance de 2 unidades. Quando um inimigo 
     est� dentro desse alcance, o m�todo Atacar � chamado, aplicando o dano ao inimigo.
    */
}

