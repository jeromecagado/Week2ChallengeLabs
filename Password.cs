public class Password
{
    public string UserId { get; set; }
    public string UserPassword { get; set; }

    public void EnterLogin()
    {
        int attempts = 0;

        while (attempts < 3)
        {
            Console.WriteLine("Please enter your userID:");
            string userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("UserId cannot be empty!");
                attempts++;
                continue;
            }

            if (userName != UserId)
            {
                Console.WriteLine("UserId not found. Try again!");
                attempts++;
                continue;
            }

            // Valid userID; now check password
            Console.WriteLine("Please enter your password:");
            string passwordInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(passwordInput))
            {
                Console.WriteLine("Password cannot be empty!");
                attempts++;
                continue;
            }

            if (passwordInput != UserPassword)
            {
                Console.WriteLine("Incorrect password. Try again!");
                attempts++;
                continue;
            }

            // Successful login
            Console.WriteLine($"Correct password, welcome {UserId}!");
            break;
        }

        if (attempts == 3)
        {
            Console.WriteLine("You have reached the max attempts. You are locked out Goodbye!");
        }
    }
}
