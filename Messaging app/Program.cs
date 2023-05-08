using Messaging_app;
using Messaging_app.DAOs;
using Messaging_app.Models;

List<UserModel> contacts = new List<UserModel>();
List<MessageModel> history = new List<MessageModel>();
List<ConversationModel> groups = new List<ConversationModel>();
BusinessLogic logic = new BusinessLogic();
int choice = 0;

//UserModel dan = new UserModel("TheRealDan223", "DManMode223", "DanKenal223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);
//UserModel steve = new UserModel("TheRealsteve223", "SManMode223", "StevelDilberts223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);
//UserModel diana = new UserModel("TheRealDiana223", "DMode223", "DianaKofentisl223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);
//UserModel ken = new UserModel("TheRealKen223", "KManMode223", "KenKenal223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);


Console.WriteLine("Welcome to assemblage!");
Console.WriteLine("Log in with username and password");
Console.Write("Username: ");
string username = Console.ReadLine();
Console.Write("Password: ");
string password = Console.ReadLine();

UserModel user = logic.GetUser(username, password);

Console.WriteLine("Would you like to");
// this will get all conversations that are marked public in the future
// for now it will return all conversations
Console.WriteLine(1 + " Find a group");
// Here it will show conversations the user is apart of
Console.WriteLine(2 + " Chat in one of your groups");

choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("here are some groups to join");
        break;
    case 2:
        Console.WriteLine("here are your groups");
        foreach (var group in user.Groups)
        {
            Console.WriteLine(group.Title);
        }

        choice = int.Parse(Console.ReadLine());

        List<MessageModel> messages = logic.GetAllMessagesInGroup(user.Groups.ElementAt(choice -1));

        foreach (MessageModel message in messages)
        {
            Console.WriteLine(message.Content);
        }

        break;
    default:
        Console.WriteLine("select eather 1 or 2 none of this 3 or 4 nonsence");
        break;
}

choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("here are some groups to join");
        break;
    case 2:
        Console.WriteLine("here are your groups");
        foreach (var group in user.Groups)
        {
            Console.WriteLine(group.Title);
        }
        break;
    default:
        Console.WriteLine("select eather 1 or 2 none of this 3 or 4 nonsence");
        break;
}

Console.Read();
