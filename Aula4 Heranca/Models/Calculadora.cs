using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//aula 5 parte 2
namespace Aula4_Heranca.Models
{
    public class Calculadora
    {
        public int Soma(int num1, int num2)
        {
            return num1 + num2; //return é necessário quando não é uma função void, pois existem parâmetros.
        }

        public int Soma(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}