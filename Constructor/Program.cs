using System;
namespace Constructor
{
    class emply
    {
        public int a;
        public int b;
        public int c;
      
        public emply(int a,int b,int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
          
        }

        public void Getdata()
        {
            c = a + b;
            Console.WriteLine("total=" + this.c);
            Console.WriteLine("total=" + c);
        }
    }
    class program
    {
       static void Main(string[] arg)
        {
            emply obj1 = new emply(10, 20, 30);
            obj1.Getdata();

        }
    }
}