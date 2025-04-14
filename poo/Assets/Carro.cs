using Unity.VisualScripting;
using UnityEngine;

public class Carro
{
    private string nome;
    private int numero_de_rodas;
    private string cor;
    private float preço;

    public string AtribuirNome()
    {
        return nome;
    }

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string AtribuirCor()
    {
        return this.cor;
    }

    public void AtribuirCor(string cor)
    {
        this.cor = cor;
    }

    public void AtribuirNumero_de_rodas(int numero_de_rodas)
    {
        this.numero_de_rodas = numero_de_rodas;
    }

    public int Numero_de_rodas()
    {
        return this.numero_de_rodas;
    }

    public void AtribuirPreço(float preço)
    {
        this.preço = preço;
    }

    public float Preço()
    {
        return this.preço;
    }

    public bool ComparePreço(Carro carro)
    {
        if (this.preço > carro.Preço())
        {
            return true;
        }
        return false;
    }
}
