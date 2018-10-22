using System;

namespace triangulo{
class Produto{

    private String name;
    private double preco;
    private int qtdEstoque;


    public Produto(String name, double preco, int qtdEstoque){
        this.name = name;
        this.preco = preco;
        this.qtdEstoque = qtdEstoque;
    }

    public Produto(String name, double preco){
        this.name = name;
        this.preco = preco;
        this.qtdEstoque = 0;
    }

    public override string ToString()
    {
        return "Produto: " + name + " Preço: " + preco;
    }

    public void realizarEntrada(){

    }

    public void realizarSaida(){

    }

    public double getqtdEStoque(){
        return this.qtdEstoque;
    }


    }
}