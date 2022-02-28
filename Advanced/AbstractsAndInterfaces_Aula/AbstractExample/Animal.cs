using System;

namespace PooExamples.AbstractExample
{
    abstract class Animal
    {
        public void Andar()
        {
            Console.WriteLine("Animal a andar");
        }

        // Abstract → Define um contrato em que o método deve ser implementado em todas as classes derivadas
        public abstract void Respirar();         
    }
}
