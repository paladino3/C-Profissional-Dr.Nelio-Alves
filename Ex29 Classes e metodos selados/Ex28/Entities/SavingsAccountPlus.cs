using System;
using System.Collections.Generic;
using System.Text;

namespace Ex28.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {

        // nao vou poder herdar essa calsse porque a classe SavingsAccount é uma classe Selada! "sealed"



        //isso serve para herdar classes e metodos tambem que sobrescritos

        /*
                public sealed override void Withdraw(double amount) (o sealed) impede que outra classe sobrescreva esse metodo! ou seja sela o conteudo
                {
                    base.Withdraw(amount); // o base, repete as regras da funcao da classe principal 
                    Balance -= amount; //alem de repetir a regra de negocio da classe mae, posso implementar novas regras na classe local!
                }

            */
    }
}
