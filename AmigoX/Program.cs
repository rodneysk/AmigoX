using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<string> participantes = new List<string>
        {
            "Participante 1", "Participante 2", "Participante 3", "Participante 4", "Participante 5",
            "Participante 6", "Participante 7", "Participante 8", "Participante 9", "Participante 10",
            "Participante 11", "Participante 12", "Participante 13", "Participante 14", "Participante 15",
            "Participante 16", "Participante 17", "Participante 18", "Participante 19", "Participante 20"
        };

        // Dicionário para armazenar o resultado do sorteio
        Dictionary<string, string> sorteio = SortearAmigoSecreto(participantes);

        Console.WriteLine("Amigo Secreto Sorteado:");
        foreach (var participante in sorteio)
        {
            Console.WriteLine($"{participante.Key} tirou {participante.Value}");
        }

        GerarArquivoResultado(sorteio);

        Console.ReadKey();
    }

    // Função responsável por realizar o sorteio
    static Dictionary<string, string> SortearAmigoSecreto(List<string> participantes)
    {
        Random random = new Random();

        // Lista dos participantes restantes para o sorteio
        List<string> participantesRestantes = new List<string>(participantes);

        // Dicionário para armazenar o resultado do sorteio (participante > amigo secreto)
        Dictionary<string, string> resultado = new Dictionary<string, string>();

        foreach (var participante in participantes)
        {
            // Remove o próprio participante da lista de sorteio
            participantesRestantes.Remove(participante);

            // Sorteia um amigo secreto que não seja o próprio participante
            string amigoSecreto;
            do
            {   
                // Se não houver mais participantes disponíveis, reinicia o processo
                if (participantesRestantes.Count == 0)
                {
                    participantesRestantes = new List<string>(participantes);
                }

                // Sorteia um índice aleatório na lista de participantes restantes
                int indiceSorteado = random.Next(participantesRestantes.Count);
                amigoSecreto = participantesRestantes[indiceSorteado];
            } while (amigoSecreto == participante || resultado.ContainsValue(amigoSecreto));

            resultado.Add(participante, amigoSecreto);

            // Remove o participante sorteado da lista para evitar repetições
            participantesRestantes.Remove(amigoSecreto);
        }

        // Retorna o dicionário final com os resultados do sorteio
        return resultado;
    }

    // Função responsável por gerar um arquivo .txt com os resultados do sorteio
    static void GerarArquivoResultado(Dictionary<string, string> resultado)
    {
        using (StreamWriter writer = new StreamWriter("ResultadoAmigoSecreto.txt"))
        {
            foreach (var participante in resultado)
            {
                writer.WriteLine($"{participante.Key},{participante.Value}");
            }
        }

        Console.WriteLine("Arquivo de resultado gerado com sucesso.");
    }
}
