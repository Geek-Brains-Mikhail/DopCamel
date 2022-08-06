//В переменной string есть секретное сообщение, во второй есть пароль.
//Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

string SecretMessage = "Camel";
string SecretPassword = "1234";
int score = 1;
bool res = false;
while( score <= 3){
    Console.Write("Введите пароль: ");
    string PasswordUser = Console.ReadLine();
    res = PasswordUser == SecretPassword;
    if(res){
        Console.Write("Секретное слово: " + SecretMessage);
        score = 4;
    }
    else{
        Console.WriteLine("вы неправильно ввели пароль.");
    }
    score++;
}
if(res){

}
else{
    Console.WriteLine("Вы истратили все попытки и не сможете получить доступ к секретному слову(");
}