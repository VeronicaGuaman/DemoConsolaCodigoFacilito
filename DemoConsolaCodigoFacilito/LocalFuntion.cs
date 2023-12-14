namespace DemoConsolaCodigoFacilito;

public class LocalFuntion
{
    //Function local
    public int CalcularSuma(int a, int b)
    {
        //Llamamos a la función local
        return suma();
        // Función local
        int suma()
        {
            return a + b;
        }
    }

    //otro ejemplo
    public string Saludo(string nombre)
    {
        // Función local
        string MensajeSaludo()
        {
            string message = $"Hola, {nombre}!";
            return message;
        }

        // Llamamos a la función local
        return MensajeSaludo();
    }
}