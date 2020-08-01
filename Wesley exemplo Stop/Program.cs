using Exx65.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
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
            Categoria c11 = new Categoria { Nome = "Verbo", Tipo = 11 };
            Categoria c12 = new Categoria { Nome = "Esporte", Tipo = 12 };
            Categoria c13 = new Categoria { Nome = "Time", Tipo = 13 };
            Categoria c14 = new Categoria { Nome = "Marca", Tipo = 14 };
            Categoria c15 = new Categoria { Nome = "Frutas", Tipo = 15 };

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
             new Palavra() { Nome = "Azul, Bege, Cinza, Dourado, Esmeralda, Ferrugem, Gelo, Hortelã, Indigo, Jasmim, Laranja, Marrom, Neve, Oliva, Púrpura, Quartzo, Rosa, Sépia, Turquesa, Ube, Verde, Xanadu, Zaffre", Categoria = c10},
             new Palavra() { Nome = "Amar, Beber, Cantar, Dançar, Educar, Falar, Gostar, Herdar, Ingerir, Jogar, Lavar, Morar, Negar, Olhar, Pensar, Quebrar, Rir, Ser, Ter, Usar, Ver, Warrantar, Xavecar, Zelar", Categoria = c11},
             new Palavra() { Nome="Atletismo, Basquetebol, Corrida, Decatlo, Esgrima, Futebol, Ginástica, Hipismo, Iatismo, Judô, Karate, Luta, Maratona, Natação, Orientação, Patinação, Queimada, Rugby, Surfe, Tênis, Ultimate Frisbee, Voleibol, Wakeboard, Xadrez, Zarabatana", Categoria =c12 },
             new Palavra() {Nome = "Arsenal, Barcelona, Corinthians, Dínamo, Estudiante, Fiorentina, Genoa, Huracán, Internazionale, Juventus, Kashima Antlers, Lazio, Milan, Nacional, Once Caldas, Porto, Querétaro, Real Madrid, Sevilla, Tijuana, Universitario, Verona, Watford, Xerez, Yokohama, Zamora", Categoria = c13},
             new Palavra() {Nome = "Amafil, Bombril, Cral, Danone, Eletrolux, Ferrari, Gillette, Havaianas, Isopor, Joma, Kappa, Lycra, Miojo, Nintendo, Orient, Polo, Q-Boa, Racco, Samsung, Toddy, Unilever, Viagra, Wilson, Xadrez, Ypê, Zoomp" , Categoria =c14},
             new Palavra() { Nome = "Amora, Butiá, Cereja, Damasco,  Embaúba, Figo, Guaraná, Humiria, Itu, Jabuticaba, Kiwi, Laranja, Manga, Noz, Olho-de-boi, Pera, Quina, Rambutan, Sapucaia, Tangerina, Umbu, Vergamota, Wampi, Xixá, Yuzu, Zitrone", Categoria = c15}
 
            };
            string resp = "";

            while( resp != "NO")
            {

         
            try
            {
                Console.Write("\nLetra: ");

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
                string p = "palavra";

                Console.WriteLine("\nCATEGORIA" + "\t\t\t\tNOME\n");
                foreach (var item in consulta)
                {
                    //Console.SetCursorPosition(50, 12);
                   // string p1 = item.Split(',')[0].Trim();
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e);
            }

                Console.Write("\nAgain? write (no): ");
                 resp = Console.ReadLine().ToUpper();

            }
            // Wait for the user to respond before closing.
            Console.Write("\n\nPress any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
