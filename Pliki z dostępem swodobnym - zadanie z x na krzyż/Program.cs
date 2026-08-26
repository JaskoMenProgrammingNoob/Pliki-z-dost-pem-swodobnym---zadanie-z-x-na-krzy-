using System.IO;
class X
{
    FileStream F;
    char iks = 'X';

    public void czytaj_i_zapisz_dane()
    {
        F = new FileStream("X.txt", FileMode.Create);
        
        for(int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (i == 0 || i == 8 || i == j || j == 9 - 1 - i)
                {
                    F.WriteByte((byte)'X');
                }
                else
                {
                    F.WriteByte((byte)' ');
                    
                }
            }
            F.WriteByte((byte)'\n');
        }
        F.Close();
        F = new FileStream("X.txt", FileMode.Open);
       
                
                 
        
        Console.WriteLine();
        
       
        F.Seek(0, SeekOrigin.Begin);
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char znak = (char)F.ReadByte();
                if(i == 0 || i == 4 || i == 8)
                {
                    Console.Write(znak);
                    
                }
                
            }
            F.ReadByte();
            Console.WriteLine();
        }
        


        F.Close();
    }



    static void Main(string[] args)
    {
        X x = new X();
        x.czytaj_i_zapisz_dane();
    }   
}