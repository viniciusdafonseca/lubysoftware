using System;
using System.Collections;

namespace c_
{
    class Program
    {
        static int CalcularFatorial(int n){
            
            int fat = 1;

            for(int i=1; i<=n; i++)
            {
                fat = fat*i;
            }

            return fat;

        }

        static double CalcularPremio(double valor, string tipo, double? multi=-1)
        {
            if(multi>0)
            {
                return valor*(double)multi;
            }else
            {
                switch(tipo)
                {
                    case "basic":
                        return valor;
                    case "vip":
                        return valor*1.2;
                    case "premium":
                        return valor*1.5;
                    case "deluxe":
                        return valor*1.8;
                    case "special":
                        return valor*2;
                    default:
                        break;
                }
            }
            return 0;
        }

        static int ContarNumerosPrimos(int n)
        {
            int nPrimos = 0;
            for(int i=2; i<n; i++)
            {
                for (int j=2; j<=(i/2); j++)
                {
                    if ((i%j)==0)
                    {
                    nPrimos++;
                    break;
                    }
                }
            }
            return nPrimos;
        }

        static int CalcularVogais(string String)
        {
            int n=0;

            for(int i=0; i<String.Length; i++)
            {
                if(String[i].Equals('a')||String[i].Equals('A')||
                String[i].Equals('e')||String[i].Equals('E')||
                String[i].Equals('i')||String[i].Equals('I')||
                String[i].Equals('o')||String[i].Equals('O')||
                String[i].Equals('u')||String[i].Equals('U'))
                {
                    n++;
                }
            }
            return n;
        }

        static string CalcularValorComDescontoFormatado(string valor, string desconto)
        {
            double valorF=0;
            string valorD = string.Empty;
            string descontoD = string.Empty;

            for(int i=0; i<valor.Length; i++)
            {
                if(Char.IsNumber(valor[i]))
                {
                    valorD += valor.Substring(i, 1);
                }
                
            }
            double valorDouble = double.Parse(valorD);
            valorDouble = valorDouble/100;

            for(int i=0; i<desconto.Length; i++)
            {
                if(Char.IsNumber(desconto[i]))
                {
                    descontoD += desconto.Substring(i, 1);
                }
                
            }
            double descontoDouble = double.Parse(descontoD);
            descontoDouble = descontoDouble/100;
    
            valorF = valorDouble-(valorDouble*descontoDouble);
            valor = String.Format("{0:C}", Convert.ToInt32(valorF));
            return valor;
        }

        static int CalcularDiferencaData(string data1, string data2)
        {
            string dia1 = data1.Substring(0,2), mes1 = data1.Substring(2,2), ano1 = data1.Substring(4,4);
            string dia2 = data2.Substring(0,2), mes2 = data2.Substring(2,2), ano2 = data2.Substring(4,4);

            

            DateTime data1F = new DateTime(int.Parse(ano1), int.Parse(mes1), int.Parse(dia1));
            DateTime data2F = new DateTime(int.Parse(ano2), int.Parse(mes2), int.Parse(dia2));

            return Math.Abs((int)data1F.Subtract(data2F).TotalDays);
        }

        static int[] ObterElementosPares( int[]vetor)
        {
           ArrayList lista = new ArrayList();


            for(int i=0; i<vetor.Length; i++)
            {
                if(vetor[i]%2==0)
                {
                   lista.Add(vetor[i]);
                }
            }
            
            int[] vetorF = (int[])lista.ToArray(typeof(int));
            return vetorF;
        }

        static string[] BuscarPessoas(string[] vetor, string valor)
        {
            ArrayList lista = new ArrayList();
            for(int i=0; i<vetor.Length; i++)
            {
                string[] subs = vetor[i].Split(' ');
                for(int j=0; j<subs.Length; j++)
                {
                    if(subs[j]==valor)
                    {
                        lista.Add(vetor[i]);
                    }
                }
            }  

            string[] resultado = (String[])lista.ToArray(typeof(string));
            return resultado;
        }

        static int[,] TransformarEmMatriz(string valores)
        {
            string[] subs = valores.Split(',');
            int [,] valoresM = new int[subs.Length/2, 2];
            int aux=0;

            for(int i=0; i<subs.Length/2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    valoresM[i, j] = int.Parse(subs[aux]);
                    aux++;
                }
            }
    
            return valoresM;
        }

        static int[] ObterElementosFaltantes(int[] vetor1, int[] vetor2)
        {
            int cont=0;
            ArrayList listaRepetidos = new ArrayList();
            var vetorConcatenados = new int[vetor1.Length + vetor2.Length];
            vetor1.CopyTo(vetorConcatenados, 0);
            vetor2.CopyTo(vetorConcatenados, vetor1.Length);

            for(int i=0; i<vetorConcatenados.Length; i++)
            {
                for(int j=0; j<vetorConcatenados.Length; j++)
                {
                    if(vetorConcatenados[i]==vetorConcatenados[j])
                    {
                        cont++;
                    }
                }
                if(cont<2)
                {
                    listaRepetidos.Add(vetorConcatenados[i]);
                }
                cont=0;
            }

            int[] elementosfaltantes = (int[])listaRepetidos.ToArray(typeof(int));
            return elementosfaltantes;
        }
        static void Main(string[] args)
        {
            
        
        }
    }
}
