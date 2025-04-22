using UnityEngine;

public class Caminhão : Carro
{
    public string AtribuirTipodeCarroceria;

    public void AtribuirTipoDeCarroceria(string tipo_de_carroceria)

    {
        this.AtribuirTipodeCarroceria = tipo_de_carroceria;
    }

    public string TipoDeCarroceria()

    {
        return this. AtribuirTipodeCarroceria;
    }
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
