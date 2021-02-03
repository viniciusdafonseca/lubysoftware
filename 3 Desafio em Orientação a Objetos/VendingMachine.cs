using System.Collections.Generic;
using System;

namespace maquinabebidas
{
    public class VendingMachine
    {
        public double valor_depositado{ get; set;}

        public void setValor_Depositado(double valor_depositado){
            this.valor_depositado = valor_depositado;
        }
        public double caixa_maquina=0;
        public double total_vendas=0;

        public double getTotal_Vendas(){
            return total_vendas;
        }

        public double troco;

        public VendingMachine(){}

        public void verificaValorDepositado(int id, List<Bebida> estoqueBebidas){
            for(int i = 0; i<3; i++){
                if(estoqueBebidas[i].bebidaID == id && estoqueBebidas[i].qtd == 0){
                   System.Console.WriteLine("Estoque Indisponivel!");
                   break;
                }else{
                    if(estoqueBebidas[i].bebidaID == id && valor_depositado >= estoqueBebidas[i].custo){
                        System.Console.WriteLine("Seu troco: R${0}\n", trocoCliente(id, estoqueBebidas));
                        depositarCaixa();
                        atualizarEstoque(id, estoqueBebidas);
                        totalVendas(id, estoqueBebidas);
                        break;
                    }
                    if(estoqueBebidas[i].bebidaID == id && valor_depositado <= estoqueBebidas[i].custo){
                        System.Console.WriteLine("Valor insuficiente! Faltam: R${0}\n", estoqueBebidas[i].custo - valor_depositado);
                        System.Console.WriteLine("Deposite o valor restante: ");
                        double valor_aux = Convert.ToDouble(Console.ReadLine());;
                        valor_depositado += valor_aux;
                        verificaValorDepositado(id, estoqueBebidas);
                        break;
                    }
                }
            }
        }
        public void depositarCaixa(){
            caixa_maquina += valor_depositado;
        }

        public double trocoCliente(int id, List<Bebida> estoqueBebidas){
            for(int i = 0; i<3; i++){
                if(estoqueBebidas[i].bebidaID == id){
                    troco = valor_depositado - estoqueBebidas[i].custo;
                }
            }
            caixa_maquina -= troco;
            return troco;
        }

        public void atualizarEstoque(int id, List<Bebida> estoqueBebidas){
            for(int i = 0; i<3; i++){
                if(estoqueBebidas[i].bebidaID == id){
                    estoqueBebidas[i].qtd -= 1;
                    break;
                }
            }
        }

        public double totalVendas(int id, List<Bebida> estoqueBebidas){
            for(int i = 0; i<3; i++){
                if(estoqueBebidas[i].bebidaID == id){
                    total_vendas += estoqueBebidas[i].custo;
                    break;
                }
            }
            return total_vendas;
        }

        public void mostrarEstoque(List<Bebida> estoqueBebidas){
            for(int i = 0; i<3; i++){
                System.Console.WriteLine("Nome: {0}\nID: {1}\nValor: R${2}\nQuantidade: {3}\n\n",
                estoqueBebidas[i].nome, estoqueBebidas[i].bebidaID, estoqueBebidas[i].custo, estoqueBebidas[i].qtd);
            }
        }

        public void mostrarBebidas(List<Bebida> estoqueBebidas){
            for(int i = 0; i<3; i++){
                System.Console.WriteLine("{0}. {1} ---- R${2}\n",estoqueBebidas[i].bebidaID, estoqueBebidas[i].nome, estoqueBebidas[i].custo);
            }
        }
    }
}