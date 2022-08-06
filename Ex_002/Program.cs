//2. Есть программа с бесконечным циклом. Когда пользователь вводит exit программа заканчивается

bool boolean = true;
string decision;
while(boolean){
    Console.Write("Может быть закончим этот беспредел?(Если согласен, то напиши - 'Exit'): ");
    decision = Console.ReadLine();
    if( decision.ToLower() == "exit"){
        boolean = false;
    }
}
Console.WriteLine("Ура!");