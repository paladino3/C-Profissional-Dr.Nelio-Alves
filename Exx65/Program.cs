using Exx65.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using static System.Net.Mime.MediaTypeNames;

namespace Exx65
{
    class Program
    {
        static void Main(string[] args)
        {

            Categoria c1 = new Categoria { Nome = "Animal", Tipo = 1 };
            Categoria c2 = new Categoria { Nome = "Cep", Tipo = 2 };
            Categoria c3 = new Categoria { Nome = "Carro", Tipo = 3 };
            Categoria c4 = new Categoria { Nome = "Objeto", Tipo = 4 };
            Categoria c5 = new Categoria { Nome = "Pais", Tipo = 5 };
            Categoria c6 = new Categoria { Nome = "Mse", Tipo = 6 };
            Categoria c7 = new Categoria { Nome = "Filme", Tipo = 7 };
            Categoria c8 = new Categoria { Nome = "DesenhoAnimado", Tipo = 8 };
            Categoria c9 = new Categoria { Nome = "Profissao", Tipo = 9 };
            Categoria c10 = new Categoria { Nome = "Cor", Tipo = 10 };

            List<Palavra> palavras = new List<Palavra>()
            {
             new Palavra() {Nome = "Anta, Boto, Cavalo, Dromedário, Elefante, Furão, Girafa, Hiena, Impala, Jumento, Kudu, Leão, Morcego, Naja, Ovelha, Pato, Quero-Quero, Rinoceronte, Sapo, Tamanduá, Urutau, Veado, Xaréu, Zebra", Categoria = c1},
             new Palavra() {Nome = "Argentina, Brasil, Chile, Dominica, Espanha, Finlândia, Grécia, Hungria, Índia, Japão, Kiribati, Lesoto, Marrocos, Nigéria, Omã, Portugal, Quênia, Rússia, Suíça, Tunísia, Uganda, Vietnã, Xangai, Zimbábue", Categoria = c2},
             new Palavra() {Nome="Astra, Belina, Corolla, Del Rey, Elba, Fusca, Gol, HB20, Ipanema, Jetta, Kingsway, Logus, Monza, Nardo, Omega, Parati, Qualis, Regata, Santana, Tempra, Uno, Vectra, Wish, Xsara, Yaris, Zafira" , Categoria = c3},
             new Palavra() {Nome = "Abajur, Boneca, Caneta, Diário, Escada, Faca, Gaita, Harpa, Isqueiro, Jarra, Kunai, Lanterna, Martelo, Navalha, Oculos, Pente, Quadro, Régua, Sanfona, Tesoura, Urinol, Vassoura, Webcam, Xícara, Yoyo (Ioiô), Zabumba", Categoria = c4 },
             new Palavra() {Nome = "Argentina, Brasil, Chile, Dominica, Espanha, Finlândia, Grécia, Hungria, Índia, Japão, Kiribati, Lesoto, Marrocos, Nigéria, Omã, Portugal, Quênia, Rússia, Suíça, Tunísia, Uganda, Vietnã, X??, Zimbábue", Categoria = c5},
             new Palavra() {Nome = "Antipática, Boa, Ciumenta, Doida, Elegante, Fraca, Gentil, Honesta, Ignorante, Jóia, Kardecista, Luxenta, Manhosa, Nojenta, Otária, Perfeita, Querida, Retardada, Sábia, Tímida, Útil, Vulgar, Wildiano, Xardoso, Zangada", Categoria = c6},
             new Palavra() {Nome = "Amélia, Bruno, Camilla, Desejo, Elektra, Felicidade, Gilda, Hulk, Infiel, Jezebel, Kedma, Lilith, Malícia, Nosferatu, Osama, Pânico, Quicksilver, Robôs, Sabrina, Tentação, Ultimate X, Vírus, Walesa, Xanadu, Yol (O Caminho), Zelig", Categoria = c7},
             new Palavra() {Nome = "Astro Boy, Ben 10, CatDog, Doug, Evangelion, Futurama, Garfield, He-Man, Inspetor Bugiganga, Johnny Bravo, Kid vs. Kat, Luluzinha, Marsupilami, Naruto, One Piece, Pica-Pau, Quarteto Fantástico, Riquinho, Scooby-Doo, Tom e Jerry, Ultra Maniac, Vandread, Will e Dewitt, X-Men, Yu-Gi-Oh!, Zé Colméia", Categoria = c8},
             new Palavra() {Nome = "Arquiteto, Bombeiro, Caminhoneiro, Detetive, Engenheiro, Ferreiro, Gerente, Historiador, Ilustrador, Jardineiro, Karateca, Lenhador, Mecânico, Neurocirurgião, Ombudsman, Professor, Químico, Relojoeiro, Sapateiro, Tapeceiro, Urologista, Vaqueiro, Ywyrájá, Xaropeiro", Categoria = c9},
             new Palavra() { Nome = "Azul, Bege, Cinza, Dourado, Esmeralda, Ferrugem, Gelo, Hortelã, Indigo, Jasmim, Laranja, Marrom, Neve, Oliva, Púrpura, Quartzo, Rosa, Sépia, Turquesa, Ube, Verde, Xanadu, Zaffre", Categoria = c10}
            };
            try
            {
                Console.Write("Letra: ");

                char valor1 = char.Parse(Console.ReadLine().ToUpper());

                List<string> consulta = new List<string>();

                foreach (var e in palavras)
                {
                    foreach (var item in e.Nome.Split(','))
                    {
                        if (item.Trim().StartsWith(valor1))
                        {
                            consulta.Add(e.Categoria.Nome + "\t\t\t\t\t" + item.TrimStart().Trim());
                        }
                    }
                }

                Console.WriteLine("\nCATEGORIA" + "\t\t\t\tNOME\n");
                foreach (var item in consulta)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e);
            }

            // Wait for the user to respond before closing.
            Console.Write("\n\nPress any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
