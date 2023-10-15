using System.Threading;
// firts

Thread thread1 = new(p => NumberPluser(1, 100));
Thread thread2 = new(p => NumberPluser(100, 200));
thread1.Start();
thread2.Start();
// thread1.Join();
// thread2.Join();
void NumberPluser(int str, int number)
{
    int starter = str;
    int sum = str; 
    for(int i = str; i < number; i++)
    {
        sum ++;
        //Console.Write(sum + " ");
    }
}
//second
Thread thread3 = new(p => NumberDefinder(0, 100));
Thread thread4 = new(p => NumberDefinder(1, 100));
// thread3.Start();
// thread4.Start();
void NumberDefinder(int str, int number)
{
    int starter = str;
    int sum = str; 
    for(int i = str; i < number; i += 2)
    {
     //   Console.Write(sum + " ");
        sum += 2;
    }
}
//third 
Thread thread5 = new(p => ThirtyFor(1, 33));
Thread thread6 = new(p => ThirtyFor(33, 67));
Thread thread7 = new(p => ThirtyFor(67, 100));
 thread5.Start();
 thread6.Start();
 thread7.Start();
// thread1.Join();
// thread2.Join();
void ThirtyFor(int str, int number)
{
    int starter = str;
    int sum = str; 
    for(int i = str; i < number; i++)
    {
        sum ++;
       // Console.Write(sum + " ");
    }
}
//four
Thread thread8 = new(p => Charworker(0,13,'m'));
Thread thread9 = new(p => Charworker(13,25, 'z'));
 thread8.Start();
 thread9.Start();
void Charworker(int sip, int str, char number)
{
    char[] alphabet = {'a', 'b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

    for(int i = sip; i < str; i++ )
    {
     //   Console.WriteLine(alphabet[i]);
    }
    
}
 //five
Thread thread10 = new(p => Number35(3, 100));
Thread thread11 = new(p => Number35(5, 100 ));
thread10.Start();
thread11.Start();
// thread1.Join();
// thread2.Join();
void Number35(int str, int number)
{
    for(int i = 0; i < number; i += str)
    {

       // Console.Write(i + " ");
    }
}
//seven
Thread thread12 = new(p => Number100(0, 100));
Thread thread13 = new(p => Number101(0, 100));
thread12.Start();
thread13.Start();
// thread1.Join();
// thread2.Join();
void Number100(int str, int number)
{
    int sum= 0;
    for(int i = 0; i < number; i ++)
    {
        sum ++;   
       // Console.Write(i + " ");
    }
}
void Number101(int str, int number)
{
    int sum= 0;
    for(int i = 0; i < number; i ++)
    {
        sum *= i;   
       // Console.Write(i + " ");
    }
}
//eight 
// thread10.Start();
// thread11.Start();
Thread thread14 = new(p => Numbercelector(0, 100));
thread14.Start();
// thread1.Join();
// thread2.Join();
void Numbercelector(int str, int number)
{
    int sum= 0;
    for(int i = 0; i < number; i ++)
    {
        
        if (i % 5 != 0 && i %3 != 0) Console.Write(i + " ");
    }
}