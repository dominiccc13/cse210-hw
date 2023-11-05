class ReflectionActivity : Activity 
{
    public ReflectionActivity (string activityName, int descIndex) : base(activityName, descIndex) {
    }

    public void RunReflectionActivity() {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(this._duration);
        DateTime currentTime = DateTime.Now;

        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");

        Random rnd = new Random();
        int promptIndex = rnd.Next(0,4);
        
        System.Console.WriteLine();
        System.Console.WriteLine(prompts[promptIndex]);
        Thread.Sleep(2000);

        while (currentTime < endTime) {
            List<int> questionIndexes = new List<int>();

            int questionIndex = rnd.Next(0,9);
            
            foreach (int index in questionIndexes) {
                if (questionIndex == index) {
                    while (questionIndex == index) {
                        questionIndex = rnd.Next(0,9);
                    }
                }
            }
            questionIndexes.Add(questionIndex);

            System.Console.WriteLine();
            System.Console.WriteLine(questions[questionIndex]);
            ShowAnimation("spinner", 2);
            currentTime = DateTime.Now;
        }
    }

}