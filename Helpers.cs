using System;
using System.IO;
class H
{
    public static void Write(string text)
    {
        Console.WriteLine(":::> " + text);
    }

    public static void Write(int number)
    {
        Write(number.ToString());
    }

    public static string Read()
    {
        return Console.ReadLine();
    }

    public static int ReadInt()
    {
        return int.Parse(Console.ReadLine());
    }

    public static double ReadDouble()
    {
        return double.Parse(Console.ReadLine());
    }

    public static int Random(int first, int end)
    {
        var random = new Random();
        return random.Next(first, end + 1);
    }
    public static void SalvarValor(string nomeVariavel, object valor)
    {
        //string caminhoArquivo = $"{nomeVariavel}.txt";

        try
        {
            File.WriteAllText(nomeVariavel, valor.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar o valor: {ex.Message}");
        }
    }

    public static T CarregarValor<T>(string nomeVariavel)
    {
        //string caminhoArquivo = $"{nomeVariavel}.txt";

        try
        {
            if (File.Exists(nomeVariavel))
            {
                string conteudo = File.ReadAllText(nomeVariavel);

                if (typeof(T) == typeof(int) && int.TryParse(conteudo, out int valorInt))
                {
                    return (T)(object)valorInt;
                }
                else if (typeof(T) == typeof(string))
                {
                    return (T)(object)conteudo;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar o valor: {ex.Message}");
        }

        // Retorna valores padrão
        if (typeof(T) == typeof(int))
        {
            return (T)(object)0;
        }
        else if (typeof(T) == typeof(string))
        {
            return (T)(object)"";
        }

        throw new InvalidOperationException("Tipo não suportado.");
    }
}
