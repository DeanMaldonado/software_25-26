// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string sender;
string reciever;
string subject;
string task;
string date;
Console.WriteLine("What is your name?");
sender = Console.ReadLine();
Console.WriteLine("Who are you sending this to?");
reciever = Console.ReadLine();
Console.WriteLine("What is the subject of the letter?");
subject = Console.ReadLine();
Console.WriteLine("What is the task that needs to be complewted");
task = Console.ReadLine();
Console.WriteLine("When is the follow up period");
date = Console.ReadLine();
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Generating your letter");
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine($"To: {reciever}");
Console.WriteLine($"Dear {reciever},");
Console.WriteLine($"Subject: {subject}");
Console.WriteLine($"I am writing you today regarding {task}. I wanted to provide a quick update on its progress.");
Console.WriteLine($"We anticipate to be finished by {date}.");
Console.WriteLine("Please reach out to me if you have any further questions.");
Console.WriteLine("Sincerely,");
Console.WriteLine($"{sender}");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Letter generated successfully. Press any key to exit.");



