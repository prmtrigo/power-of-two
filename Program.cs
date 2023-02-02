namespace power_of_two;
class Program
{
    static bool PowerOfTwo(int numero){

        //verificar se o número é uma potência de 2
        if(numero == 0){
            return false;
        }

        while(numero != 1){
            //se o número/2 não tem resto 0, é falso
            if(numero %2 !=0){
                return false;
            }
            //vamos dividir esse número por 2
            numero = numero/2;
        }

        return true;
    }
    static void Main(string[] args)
    {
        Program verifica= new Program();

        Console.WriteLine("Coloque um número: ");
        int numero;
        numero = Convert.ToInt32(Console.ReadLine());

        //retornando a função
        bool verificador = PowerOfTwo(numero);
        Console.WriteLine(verificador);
    }
}
