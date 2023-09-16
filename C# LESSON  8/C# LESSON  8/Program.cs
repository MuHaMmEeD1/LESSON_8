using C__LESSON__8;
using C__LESSON_8;
class Program
{
    static List<User> users = new List<User>() { new User("hesen", "hesenli", new Card("1 Bank", "1 Banka", "1234567812345678", "1111", "123", new DateTime(2010, 2, 23), 100.8m)), new User("kenan", "kenanli", new Card("1 Bank", "1 Banka", "1234567812345678", "2222", "122", new DateTime(2020, 4, 13), 450.8m)), new User("samir", "samirli", new Card("1 Bank", "1 Banka", "1234567812344444", "3333", "111", new DateTime(2015, 2, 16), 200m)), new User("tahir", "tahirli", new Card("1 Bank", "1 Banka", "1234567812345670", "4444", "100", new DateTime(2014, 11, 9), 1290.80m)), new User("osman", "osmali", new Card("1 Bank", "1 Banka", "1234567812345671", "5555", "121", new DateTime(2021, 3, 21), 208m)) };
    
    



    static int piniYoxla() {

        Console.Write("PINi daxil edin: ");
        string sec = Console.ReadLine();
        
        for (int i = 0; i<users.Count; i++)
        {
            if (sec == users[i].CreditCard.PIN) {return i; }
        }

        return -1;
    }

    static void start()
    {
        
        int index = piniYoxla();

        try
        {
            if (index == -1) { throw new YanlisPINException(); }
        }
        catch (YanlisPINException ex) { Console.WriteLine(ex.Message); start(); }


        if (index > -1)
        {
            Console.WriteLine("(1). Balans\n(2). Nagd pul\n(3). Karta pul kocur");
            Console.Write("\ncesim edin: ");
            string sec = Console.ReadLine();

            if (sec == "1")
            {
                Console.WriteLine($"Balans {users[index].CreditCard.Balans}");
            }
            
            else if (sec == "2") {
         
                Console.WriteLine("1. 10 AZN");
                Console.WriteLine("2. 20 AZN");
                Console.WriteLine("3. 50 AZN");
                Console.WriteLine("4. 100 AZN");
                Console.WriteLine("5. LIMITSIZ AZN\n");

                Console.Write("secim edin: ");

                sec = Console.ReadLine();   

                if(sec == "1" && users[index].CreditCard.Balans >= 10) { users[index].CreditCard.Balans -= 10; }
                else if(sec == "2" && users[index].CreditCard.Balans >= 20) { users[index].CreditCard.Balans -= 20; }
                else if(sec == "3" && users[index].CreditCard.Balans >= 50) { users[index].CreditCard.Balans -= 50; }
                else if(sec == "4" && users[index].CreditCard.Balans >= 100) { users[index].CreditCard.Balans -= 100; }
                else if(sec == "5") {

                    Console.Write("miqdar daxil edin: ");
                    decimal pul = 0;

                    try {  
                        pul = decimal.Parse(Console.ReadLine());
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    try
                    {
                        if (users[index].CreditCard.Balans >= pul)
                        {
                            users[index].CreditCard.Balans -= pul;
                        }
                        else { throw new BalansException(); }
                    }
                    catch(BalansException ex) { Console.WriteLine(ex.Message); }
                }
                else if (sec == "1" || sec == "2" || sec == "3" || sec == "4" || sec == "5")
                {
                    try { throw new BalansException(); }
                    catch(BalansException ex) { Console.WriteLine(ex.Message); }
                }
                else
                {
                    try { throw new SecimException(); }
                    catch (SecimException ex) { Console.WriteLine(ex.Message); }
                }
            }
            else if (sec == "3") {

                Console.Write("Card in PİN ini daxil edin: ");
                string _pin = Console.ReadLine();

                int pinIndex = -1; 

                for (int i = 0; i < users.Count; i++)
                {
                    if (_pin == users[i].CreditCard.PIN) { pinIndex = i; break; }
                }

                try
                {
                    if(pinIndex == -1) { throw new YanlisPINException();}
                }
                catch (YanlisPINException ex)
                {
                    Console.WriteLine(ex.Message);
                   
                }

                if (pinIndex >= 0) {

                    Console.Write("pulu daxil edin: ");
                    decimal pul = 0;
                    bool yoxla = true;

                    try
                    {
                        pul = decimal.Parse(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        yoxla = false;
                        Console.WriteLine(ex.Message);
                    }

                    if (yoxla)
                    {

                        try
                        {
                            if (users[index].CreditCard.Balans < pul) { yoxla = false; throw new BalansException(); }
                        }
                        catch (BalansException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        if (yoxla) { users[pinIndex].CreditCard.Balans += pul; users[index].CreditCard.Balans -= pul; }



                    }


                }






            }

            else
            {
                try { throw new SecimException(); }
                catch (SecimException ex) { Console.WriteLine(ex.Message); }
            }
        }
        start();
    }
    
    
    
    
    
    
    static void Main(string[] args)
    {


        start();



    }

}