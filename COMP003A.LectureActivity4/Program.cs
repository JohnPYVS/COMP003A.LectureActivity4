namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 3
            int taskNumber = 1;

            // This loop just repeats task 1 through task 5, and each one is marked as finished
            while (taskNumber <= 5)
            {
                Console.WriteLine("Task " + taskNumber + " completed");
                taskNumber++;
            }

            Console.WriteLine();

            // Step 4
            int attempt = 1;

            /* Why this loop executes at least once is because
             * it checked the condition after the inside the do block gets executed.
             */
            do
            {
                Console.WriteLine("Attempt " + attempt);
                attempt++;
            } while (attempt <= 3);

            Console.WriteLine();

            // Step 5

            // A for loop is appropriate for this task so we can know exactly how many steps 1 to 4, need to repeat.
            for (int X = 1; X <= 4;)
            {
                Console.WriteLine("Step " + X);
                X++;
            }

            Console.WriteLine();

            // Step 6

            int number = 1;

            Console.WriteLine(number);

            while (number <= 6)
            {
                number++;

                // continue is to skip printing when the number is 4
                if (number == 4)
                {
                    continue;
                }

                // break is to stop the loop when the number reaches 6

                if (number == 6)
                {
                    break;
                }

                Console.WriteLine(number);
            }
            /* Step 7
             * The loop type that was the easiest for me to understand was the for loop because it can clearly show the start, stop, and it can update in one place.
             * The loop that required the most careful tracing is the while loop with the break and continue flow statements because it can skips parts or stop early.
             * Comments helped me understand my loops because it helped remined me what each section is supposed to do, and why they are being used.
             */ 
        }
    }
}
        
