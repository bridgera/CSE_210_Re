using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
    // EVENT 1: LECTURE 
        Console.WriteLine("\n____________________________\nEVENT 1: LECTURE\n____________________________");
        Lecture lecture = new Lecture("Photography Lecture", "An experienced photographer teaches up and coming studet photographers about balancing life and career as a photographer",
         "11/30/2023", "11:00 AM", "Victoria Will", 30);

        lecture.SetAddress("1125 N University Ave", "Provo", "Utah", "USA");
        lecture.GetShortDes();
        lecture.GetStandardDetails();
        lecture.GetFullDetails();

    // EVENT 2: RECEPTION
        Console.WriteLine("\n____________________________\nEVENT 2: RECEPTION\n____________________________");
        Reception reception = new Reception("Sam and Gretha's Wedding", "The wedding of Sam Yompi, son of Sam sr. and Thyri Yompi, and Gretha Pondran, daughter of Rogrthen and Proing Pondran ",
         "9/1/2024", "07:00 PM", "rsvpThrowway@yahoo.com");

        reception.SetAddress("1330 300 N", "Provo", "Utah", "USA");
        reception.GetShortDes();
        reception.GetStandardDetails();
        reception.GetFullDetails();

    // EVENT 3: OUTDOOR ACTIVITY
        Console.WriteLine("\n____________________________\nEVENT 3: OUTDOOR ACTIVITY\n____________________________");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Patriotic Party", "COME CELEBRATE AMERICAN FREEDOM & INDEPENDENCE",
         "7/4/2024", "01:00 PM", "Snowy");

        outdoorGathering.SetAddress("Main Street", "Rexburg", "Idaho", "USA");
        outdoorGathering.GetShortDes();
        outdoorGathering.GetStandardDetails();
        outdoorGathering.GetFullDetails();

    }
}