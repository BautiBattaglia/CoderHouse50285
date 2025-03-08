class ValidasPassChatGPT
{
    private const string PasswordCorrect = "123456";
    private const int MaxAttempts = 5;

    static void Main(string[] args)
    {
        bool isAccessGranted = TryAuthenticateUser();

        if (isAccessGranted)
        {
            WelcomeUser();
        }
        else
        {
            Console.WriteLine("Acceso bloqueado.");
        }
    }

    private static bool TryAuthenticateUser()
    {
        int attemptCount = 0;

        while (attemptCount < MaxAttempts)
        {
            string passwordEntered = PromptForPassword();
            if (passwordEntered == PasswordCorrect)
            {
                Console.WriteLine($"{PasswordCorrect} es correcta");
                return true;
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
                attemptCount++;
            }
        }

        return false;
    }

    private static string PromptForPassword()
    {
        Console.Write("Ingrese su contraseña: ");
        return Console.ReadLine();
    }

    private static void WelcomeUser()
    {
        Console.WriteLine("Bienvenido al sistema.");
    }
}
