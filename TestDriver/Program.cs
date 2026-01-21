namespace MonsterLlama.Leetcode.TestDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var problem746 = new Problem746();

            var result746c  = problem746.Test3();
            var result746c1 = problem746.Test3();
            var result746a  = problem746.Test1();
            var result746a1 = problem746.Test1();
            var result746b  = problem746.Test2();
            var result746b1 = problem746.Test2();


            var problem806 = new Problem806();

            var now = DateTime.Now;
            for (int i = 0; i < 100; i++)
            {
                var result806 = problem806.Test1();
            }
            var runtime = DateTime.Now - now;
            Console.WriteLine($"problem806.Test1()\t\t Run Time: {runtime / 100}");
        }
    }
}
