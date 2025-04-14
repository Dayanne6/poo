using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro Fusca = new Carro(); 
    Carro Gol = new Carro();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fusca.AtribuirNome("olavo");
        Fusca.AtribuirCor("azul");
        Fusca.AtribuirNumero_de_rodas(4);
        Fusca.AtribuirPreço(2050.90f);

        Debug.Log("0" + Fusca.AtribuirNome() + "é" + Fusca.AtribuirCor() + "tem" + Fusca.Numero_de_rodas() + " e custa R$ " + Fusca.Preço());
        
        Gol.AtribuirNome("Olavo");
        Gol.AtribuirCor("azul");
        Gol.AtribuirNumero_de_rodas(4);
        Gol.AtribuirPreço(2050.90f);
        Debug.Log("0" + Gol.Nome());
    }


// Update is called once per frame
    void Update()
    {

    }

}