using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTI20N
{
    class Model
    {
        //Area de Variavéis
        private double num1;
        private double num2;


        //Método Construtor = Instancia numa variáveis
        public Model()
        {
            ConsultarNum1 = 0;
            num2 = 0;
        }//Fim do Construtor

        //Método GET E SET
        public double ConsultarNum1
        {
            get { return num1; }

            set { num1 = value; }


        }//Fim do get set

        public double ConsultarNum2 
        {
            get { return num2; }
            set { num2 = value; }

        }//Fim do get set

        public double Somar() 
        {
            
            return ConsultarNum1 + ConsultarNum2;
        }//FIM DO SOMAR

        public double Subtrair() 
        {
            return ConsultarNum1 - ConsultarNum2;        
        
        }//Fim do Método Subtrair

        public double Multiplicar() 
        {
            return ConsultarNum1 * ConsultarNum2;
        
        }//Fim do Multiplicar

        public double Dividir() 
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return ConsultarNum1 / ConsultarNum2;
            }
        }//Fim do Dividir


    }//Fim da Classe
}//Fim do projeto
