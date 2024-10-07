namespace ConsoleEstudos
{

    public class LeetCodeTwoSum
    {
        public static void Main(String[] args)
        {

            //Two Sum
            int[] Nums = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int Target;
            int exit = 0;

            do
            {

                Console.WriteLine("Whats the target?: ");
                string targetstring = Console.ReadLine();
                Target = int.Parse(targetstring);





                int Posicao1 = 0;
                int Posicao2 = 0;
                
               


                for (int i = 0; i < 9; i++)
                {
                    int Loop = 0;
                    int count = 0;
                    

                   


                    while (Loop == 0)
                    {
                       


                        int res = Nums[i] + Nums[count];
                        if (res.Equals(Target))
                        {
                            Posicao1 = i;
                            Posicao2 = count;
                            break;
                        }

                        if (Nums[count].Equals(9))
                        {
                            Loop = 10;
                        }

                        

                        count++;
                    }
                }


                Console.WriteLine($"Postion: [{Posicao1}] [{Posicao2}]");

               

                Console.WriteLine("\nDeseja sair:\n1.Não\n2.Sim: ");
                string stringexit = Console.ReadLine();
                exit = int.Parse(stringexit);

            } while (exit == 1);
           

           
                   
        }
    }
}