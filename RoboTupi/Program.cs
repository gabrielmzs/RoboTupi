namespace RoboTupiniquim {
    internal class Program {
        static void Main(string[] args) {
                                                
            Console.Write("Digite o tamanho do Grid: ");
            string strGrid = Console.ReadLine();
            char [] gridChar = strGrid.ToCharArray();

            int[] gridInt = new int[2];
            gridInt[0] = (int)Char.GetNumericValue(gridChar[0]);
            gridInt[1] = (int)Char.GetNumericValue(gridChar[2]);

            string[] posicao = new string[2];
            string[] comandos = new string[2];

            Console.Write("Informe a posição inicial do Robo 1: ");
            posicao[0] = Console.ReadLine();

            Console.Write("Informe os comandos do Robo 1: ");
            comandos[0] = Console.ReadLine();

            Console.Write("Informe a posição inicial do Robo 2: ");
            posicao[1] = Console.ReadLine();

            Console.Write("Informe os comandos do Robo 2: ");
            comandos[1] = Console.ReadLine();


            for (int j = 0; j < comandos.Length; j++) {  

               
                string[] posicaoInicial = posicao[j].Split(" ");


                int xInicial = Convert.ToInt32(posicaoInicial[0]);
                int yInicial = Convert.ToInt32(posicaoInicial[1]);
                char orientacaoInicial = Convert.ToChar(posicaoInicial[2]);

                string comando = comandos[j];
                
                char[] comandosChar = comando.ToCharArray();


                if (xInicial > gridInt[0] || yInicial > gridInt[1]) {
                    Console.WriteLine("Fora da área!");
                }


                for (int i = 0; i < comandos[j].Length; i++) {
                    if (comandosChar[i] == 'M') {
                        if (orientacaoInicial == 'N') {
                            yInicial++;
                        } else if (orientacaoInicial == 'L') {
                            xInicial++;
                        } else if (orientacaoInicial == 'S') {
                            yInicial--;
                        } else if (orientacaoInicial == 'O') {
                            xInicial--;
                        }
                    } else if (comandosChar[i] == 'D') {
                        if (orientacaoInicial == 'N') {
                            orientacaoInicial = 'L';
                        } else if (orientacaoInicial == 'L') {
                            orientacaoInicial = 'S';
                        } else if (orientacaoInicial == 'S') {
                            orientacaoInicial = 'O';
                        } else if (orientacaoInicial == 'O') {
                            orientacaoInicial = 'N';
                        }
                    } else if (comandosChar[i] == 'E') {
                        if (orientacaoInicial == 'N') {
                            orientacaoInicial = 'O';
                        } else if (orientacaoInicial == 'L') {
                            orientacaoInicial = 'N';
                        } else if (orientacaoInicial == 'S') {
                            orientacaoInicial = 'L';
                        } else if (orientacaoInicial == 'O') {
                            orientacaoInicial = 'S';
                        }
                    }
                }    //Laço de repetição para percorrer um comando de cada vez e fazer as respectivas alterações


                Console.WriteLine($"\nRobo 1 - Fim:   X:{xInicial} Y:{yInicial} Orientação: {orientacaoInicial}");
            }

        }
    }
}