using Messaging_app;
using Messaging_app.Models;

List<UserModel> contacts = new List<UserModel>();
List<MessageModel> history = new List<MessageModel>();
List<ConversationModel> groups = new List<ConversationModel>();
BusinessLogic logic = new BusinessLogic();

UserModel dan = new UserModel("TheRealDan223", "DManMode223", "DanKenal223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);
UserModel steve = new UserModel("TheRealsteve223", "SManMode223", "StevelDilberts223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);
UserModel diana = new UserModel("TheRealDiana223", "DMode223", "DianaKofentisl223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);
UserModel ken = new UserModel("TheRealKen223", "KManMode223", "KenKenal223@gmail.com", "https://app.diagrams.net/#G1U3t9hyNj", true, contacts, "English", history, groups);


Console.WriteLine("Welcome to the group chat!");


Console.Read();
