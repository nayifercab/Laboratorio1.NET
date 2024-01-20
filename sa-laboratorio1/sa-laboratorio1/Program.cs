namespace sa_laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int year = Convert.ToInt16("2024");
            double doble = 2.5;  //Aproxima
            string nombre = "Daniel";
            String apellidos = "Duran Acevedo";
            decimal decimals = 2.07M; //Valores exactos
            float flotante = 8.0F;
            
            Console.WriteLine(nombre + "{1} {0} {2}", year, doble, decimals);

            Calculadora calculadora = new Calculadora();
            double resultadoSuma = calculadora.EjecutarOperacion(2, 3, '+');
            Console.WriteLine($"2 + 3 = {resultadoSuma}"); //String Interpolado
        }
    }

    public class Calculadora
    {
        private double resultado;
        private char[] operadores = { '+', '-', '*', '/' };

        public Calculadora()
        {
            resultado = 0;
        }

        public double EjecutarOperacion(double num1, double num2, char operador)
        {
            switch (operador)
            {
                case '+':
                    resultado = Sumar(num1, num2);
                    break;
                case '-':
                    resultado = Restar(num1, num2);
                    break;
                case '*':
                    resultado = Multiplicar(num1, num2);
                    break;
                case '/':
                    resultado = Dividir(num1, num2);
                    break;
                default:
                    Console.WriteLine("Operador no válido");
                    break;
            }

            return resultado;
        }

        // Método para realizar la suma
        private double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        // Método para realizar la resta
        private double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        // Método para realizar la multiplicación
        private double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        // Método para realizar la división
        private double Dividir(double num1, double num2)
        {
            // Verificar si el denominador no es cero
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
                return double.NaN; // Representa "Not a Number" en este caso
            }
        }
    }
}
