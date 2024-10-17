using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoFogo : MonoBehaviour, ITipoInimigo//implementa a interface ITipoInimigo. Isso significa que a classe InimigoFogo precisa fornecer as implementações dos membros definidos na interface ITipoInimigo.
{
    public string Nome
    {
        get
        {
            return "Fogo"; //Essa propriedade tem apenas um  (get), que retorna a string "Fogo". Isso significa que, sempre que chamar o nome do tipo de inimigo, o valor "Fogo" será retornado.
        }
    }
}