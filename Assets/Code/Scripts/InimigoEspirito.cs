using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoEspirito : MonoBehaviour, ITipoInimigo//implementa a interface ITipoInimigo. Isso significa que a classe InimigoEspirito precisa fornecer as implementa��es dos membros definidos na interface ITipoInimigo.
{
    public string Nome//Essa propriedade tem apenas um  (get), que retorna a string "Espirito". Isso significa que, sempre que chamar o nome do tipo de inimigo, o valor "Espirito" ser� retornado.
    {
        get { return "Espirito"; }
    }
}
