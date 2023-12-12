namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 10;

            

            var response = "is less than nine";
            var anotherResponse = "is greater than or equal to nine";


            var lessThan = answer < 9 ? $"{answer} {response}" : $"{answer} {anotherResponse}";

            Console.WriteLine(lessThan);


            //if (answer < 9)
            //{
            //    Console.WriteLine($"{answer} {response}.");
            //}
            //else
            //{
            //     Console.WriteLine($"{answer} {anotherResponse}.");
            //}




            //var synSug = (answer < 9) ? response : anotherResponse;

            //Console.WriteLine($"{answer} {synSug});






            //Console.WriteLine(answer < 9 ? {answer}  {response} : )
            //if (answer < 9)
            //{
            //    Console.WriteLine($"{answer} is less than nine");
            //}
            //else
            //{
            //    Console.WriteLine($"{answer} is greater than or equal to nine");
            //}
        }
    }
}
