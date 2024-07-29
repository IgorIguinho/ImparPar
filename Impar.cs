using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Impar : MonoBehaviour
{
    //variaveis UI
    public InputField Player1Name;
    public InputField Player2Name;
    public Text Player1;
    public Text Player2;
    public InputField NumeroPlayer1;
    public InputField ParOrImpar;
    public Text NumeroPlayer2;
    public Text Resultado_;

    // Historico variaveis
    public Text score0;
    public Text score1;
    public Text score2;
    public Text score3;
    public Text score4;

    //Variaveis gerais
    int numerogeral;
    int imparPar;
    public int[] Historico_;
    int i = 0;

     void Start()
    {
        Historico_ = new int[5];
        
    }

    public void Play()
    {
      
        NumeroPc();

        //ParImpar();
        
        Debug.Log(numerogeral);

    }

    void NumeroPc()
    {
        // variaveis para dizer os numeros dos players
        int numeroSorteado = Random.Range(0, 6);
        int nPlayer = int.Parse(NumeroPlayer1.text);
        NumeroPlayer2.text = numeroSorteado.ToString();

        // variaveis para fazer o calculor do ganhador 
        int numerogeral = numeroSorteado + nPlayer;
        int imparPar = numerogeral % 2;

        // Codigo para mostrar o resultado
        if (ParOrImpar.text == "Par" || ParOrImpar.text == "par")
        {
            if (imparPar == 0)
            {
                Resultado_.text = numerogeral.ToString() + " é par então a pessoa ganhadora é " + Player1Name.text;
            }
            else
            {
                Resultado_.text = numerogeral.ToString() + " é impar então a pessoa ganhadora é " + Player2Name.text;
            }
        }
        else if (ParOrImpar.text == "impar" || ParOrImpar.text == "Impar")
        {
            if (imparPar == 1)
            {
                Resultado_.text = numerogeral.ToString() + " é impar então a pessoa ganhadora é " + Player1Name.text;
            }
            else
            {
                Resultado_.text = numerogeral.ToString() + " é par então a pessoa ganhadora é " + Player2Name.text;
            }
        }
        else
        {
            Resultado_.text = "escreva impar ou par e somente isso";
        }

        //codigo para salvar o historico
        if (i == 0)
        {
            Historico_[i] = numerogeral;
            i = i + 1;
        }
        else if (i == 1)
        {
            Historico_[i] = numerogeral;
            i = i + 1;
        }
        else if (i == 2)
        {
            Historico_[i] = numerogeral;
            i = i + 1;
        }
        else if (i == 3)
        {
            Historico_[i] = numerogeral;
            i = i + 1;
        }
        else if (i == 4)
        {
            Historico_[i] = numerogeral;
            i = 0;
        }

        Historico();


    }
    //função para fazer o score aparecer na tela

    void Historico()
    {
       
        if (Historico_[0] == 0)
        {

        }
        else
        { 
            score0.text = Historico_[0].ToString();
        }

        if (Historico_[1] == 0)
        {

        }
        else
        {
            score1.text = Historico_[1].ToString();
        }

        if (Historico_[2] == 0)
        {

        }
        else
        {
            score2.text = Historico_[2].ToString();
        }

        if (Historico_[3] == 0)
        {

        }
        else
        {
            score3.text = Historico_[3].ToString();
        }

        if (Historico_[4] == 0)
        {

        }
        else
        {
            score4.text = Historico_[4].ToString();
        }

    }


}
