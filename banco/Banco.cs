 using System;

 namespace banco{
     class Banco{

         public int conta { get;private set; }
         public string nome {get; set;}

         private double saldo{ get; set; }

         public string getsaldo(){
            return $"Saldo atual: {this.saldo}";
         }

         public Banco(int conta, string nome, double deposito){
             this.conta = conta;
             this.nome = nome;
             this.saldo = 0;
             this.depositar(deposito);

         }

         public Banco(int conta, string nome){
             this.conta = conta;
             this.nome = nome;
             this.saldo = 0;
         }

         public void depositar(double deposito){
             this.saldo += deposito;
         }

         public void sacar(double valor){
             this.saldo -= (valor + 5.0);
         }

     }
 }