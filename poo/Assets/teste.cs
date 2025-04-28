using UnityEngine;

public class Teste : MonoBehaviour
{
    Carro Fusca = new Carro(); 
    Carro Gol = new Carro();

    private Caminhão caminhão = new Caminhão();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fusca.AtribuirNome(" olavo ");
        Fusca.AtribuirCor(" azul ");
        Fusca.AtribuirNumero_de_rodas(4);
        Fusca.AtribuirPreço(2050.90f);

        Debug.Log("0 " + Fusca.AtribuirNome() + " é " + Fusca.AtribuirCor() + " tem " + Fusca.Numero_de_rodas() + " rodas " + " e custa R$ " + Fusca.Preço());
        
        Gol.AtribuirNome(" Olaf ");
        Gol.AtribuirCor(" Amarelo ");
        Gol.AtribuirNumero_de_rodas(4);
        Gol.AtribuirPreço(3050.90f);
        Debug.Log("0" + Gol.AtribuirNome() + "é " + Gol.AtribuirCor() + "tem  " + Gol.Numero_de_rodas() + " rodas " + " e custa R$ " + Gol.Preço());

        if (Fusca.ComparePreço(Gol))
        {
            Debug.Log("O carro " + Fusca.AtribuirNome() + " é mais caro do que o carro " + Gol.AtribuirNome());
        }
        else
        {
            Debug.Log("O carro " + Fusca.AtribuirNome() + " é mais barato do que o carro " + Gol.AtribuirNome());
        }
        
       
        caminhão.AtribuirTipoDeCarroceria("Larga");

        caminhão.AtribuirNumero_de_rodas(8);

        caminhão.AtribuirPreço(6000.00f);

        caminhão.AtribuirCor("Azul");

        caminhão.AtribuirNome("Caminhão do Falstão");

        if (Fusca.ComparePreço(caminhão))
        {
            Debug.Log("0 Carro " +  Fusca.AtribuirNome() + "é mais caro do que o " + caminhão.AtribuirNome());
        }

        else

        {
            Debug.Log("0 Carro " + Fusca.AtribuirNome() + "é mais barato do que o" + caminhão.AtribuirNome());
        } 



    }
    
    
    //====================================
   joao.Atribuirnome;
   joao.Atribuirenergia;
   joao.Atribuirforca_ataque;
   joao.Atribuirforca_do_pulo;
   joao.Atribuirvelocidade;
   joao.Atribuirnumero_de_pes;
   joao.Atribuirnumero_de_maos;



}