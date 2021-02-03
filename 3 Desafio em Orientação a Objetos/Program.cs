using System;
using System.Collections.Generic;

namespace maquinabebidas
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine maquina = new VendingMachine();
            List<Bebida> estoqueBebidas = new List<Bebida>();

            estoqueBebidas.Add(new Bebida(0, "Coca-cola", 4.5, 5));
            estoqueBebidas.Add(new Bebida(1, "Chá Mate", 4, 5));
            estoqueBebidas.Add(new Bebida(2, "Suco", 3, 5));

            bool flag=false;
            while(!flag){
                System.Console.WriteLine("Bem vindo a Máquina de Bebida!\n\n");
                System.Console.WriteLine("1. Comprar bebida");
                System.Console.WriteLine("2. Estoque de bebidas");
                System.Console.WriteLine("3. Valor total de vendas");
                System.Console.WriteLine("4. Sair");

                int opçao = Convert.ToInt32(Console.ReadLine());

                switch(opçao){
                    case 1:
                        maquina.mostrarBebidas(estoqueBebidas);
                        bool flag1 = false;
                        while(!flag1){
                            opçao = Convert.ToInt32(Console.ReadLine());
                            switch(opçao){
                                case 0:
                                    System.Console.WriteLine("Deposite um valor: ");
                                    maquina.setValor_Depositado(Convert.ToDouble(Console.ReadLine()));
                                    maquina.verificaValorDepositado(0, estoqueBebidas);
                                    
                                    flag1=true;         
                                    break;   
                                case 1:
                                    System.Console.WriteLine("Deposite um valor: ");
                                    maquina.setValor_Depositado(Convert.ToDouble(Console.ReadLine()));
                                    maquina.verificaValorDepositado(1, estoqueBebidas);

                                    flag1=true;         
                                    break;
                                case 2: 
                                    System.Console.WriteLine("Deposite um valor: ");
                                    maquina.setValor_Depositado(Convert.ToDouble(Console.ReadLine()));
                                    maquina.verificaValorDepositado(2, estoqueBebidas);
                                    flag1=true;         
                                    break;
                                default:
                                    System.Console.WriteLine("Opçào inválida!\nEscolha novamente: ");
                                    flag1=false;         
                                    break;
                            }
                        }
                                
                        break;   
                    case 2: 
                        maquina.mostrarEstoque(estoqueBebidas);
                               
                        break;
                    case 3: 
                       System.Console.WriteLine("Valor total de Vendas: R${0}\n", maquina.getTotal_Vendas());
                                
                        break;
                    case 4: 
                        flag=true;         
                        break;
                    default:
                        System.Console.WriteLine("Opção inválida!\n");
                        flag=false;         
                        break;
                }
            }
            
        
        }
    }
}
