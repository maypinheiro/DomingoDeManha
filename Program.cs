using System;
namespace DomingoDeManha
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Diguite a hora de saida: ");
                var tempo = Console.ReadLine();

                TimeSpan horarioDeSaida = TimeSpan.Parse(tempo);
                TimeSpan percurso = TimeSpan.Parse("01:00");
                TimeSpan horaDoEncontro = TimeSpan.Parse("08:00");
                TimeSpan horarioDeChegada = (horarioDeSaida + percurso);
                TimeSpan chegada = horarioDeChegada - horaDoEncontro;
                Console.WriteLine(Resultado(chegada));
            }
        }

        public static string Resultado(TimeSpan chegada)
        {
            if (chegada.Hours < 0) return ($"Atraso máximo: {chegada.Minutes} minutos");
            else if (chegada.Hours > 0) return ($"Atraso máximo: {chegada.Hours}:{chegada.Minutes}");
            else return ($" Atraso máximo: {chegada.Minutes}");
        }
    }
}
