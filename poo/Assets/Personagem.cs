using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string nome;
    private int energia;
    private int forca_ataque;
    private float forca_do_pulo;
    private float velocidade;
    private int numero_de_pes;
    private int numero_de_maos;
    
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string AtribuirNome()
    {
        return this.nome;
    }

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }


}








{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
