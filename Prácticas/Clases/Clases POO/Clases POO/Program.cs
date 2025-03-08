using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creación primer objeto
            Circulo miCirculo; //Creación de objeto de tipo círculo. Variable de tipo círculo.
            miCirculo = new Circulo(); //Iniciación de variable objeto de tipo Circulo. Instanciar una clase. NEW = INSTANCIA
            Console.WriteLine(miCirculo.calculoArea(2));

            //Creación segundo objeto
            Circulo miCirculo2 = new Circulo();
            Console.WriteLine(miCirculo2.calculoArea(5));

            //miCirculo.pi = 50.32; //Se pueden editar porque son PUBLIC, si lo dejamos CONS en la clase principal, no se puede editar.

        }
    }
    class Circulo
    {
        const double pi = 3.1416; //propiedad de la clase Circulo. Campos de clase.
        public double calculoArea(int radio) //método de clase. ¿Qué pueden hacer los objetos círculos?
        {
            return pi * radio * radio;
        }
    }

}