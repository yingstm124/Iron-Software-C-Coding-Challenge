using challenge;

while(true) {
    Console.Write("Enter: ");
    string input = Convert.ToString(Console.ReadLine());
    Phone phone = new Phone();
    Console.WriteLine(phone.OldPhonePad(input));
}
