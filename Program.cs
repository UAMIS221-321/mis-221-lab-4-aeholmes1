﻿// start main

int userChoice = GetUserChoice();
do {
    RouteEm(userChoice);
    userChoice = GetUserChoice();
} while (userChoice != 3);

// end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display partial triangle\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput) {
    if (userInput == "1" || userInput == "2" || userInput == "3") {
        return true;
    }
    return false;
}

static void RouteEm(int menuChoice) {
    if (menuChoice == 1) {
        GetFull();
    }
    else if (menuChoice == 2) {
        GetPartial();
    }
    else if (menuChoice != 3) {
        SayInvalid();
    }
}

static void PauseAction() {
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

static void GetFull() {
    Random rand = new Random();
    int number = rand.Next(3, 10);
    for (int r = 1; r <= number; r++) {
        for (int s = 1; s <= r; s++) {
            if (s == 1 || s == r || r == number) {
                System.Console.Write("0 ");
            }
            else if (rand.Next(2) == 1 && int holes > 0) {
                System.Console.WriteLine("  ");
                holes--;
            }
            else {
                System.Console.WriteLine("0 ");
            }
        System.Console.WriteLine();
        }
    }
    PauseAction();
}

static void GetPartial() {
    Random rand = new Random();
    int number = rand.Next(3, 10);
    for (int r = 1; r <= number; r++) {
        for (int s = 1; s <=2 * r - 1; s++)
            System.Console.Write("0");
        System.Console.WriteLine();
    }
    PauseAction();
}

static void SayInvalid() {
    System.Console.WriteLine("Invalid input, please try again.");
    PauseAction();
}