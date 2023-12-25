
// Мы пишем простое чат-приложение способное передавать сообщения с компьютера на компьютер. Начнем с разработки модели сообщений для нашего чата. Договоримся что у каждого пользователя может быть свой ник-нейм - уникальное имя. Ему можно будет передать сообщение, состоящее из даты, никнейма отправителя  и текста сообщения.
// Добавим JSON сериализацию и десериализацию в наш класс. И протестируем его путем компоновки простого сообщения, сериализации и десериализации этого сообщения.

namespace Task1
{
    internal class Program
    {
        public void Client()
        {
            
        }
        static void Main(string[] args)
        {
            // 2
            /*Message some = new Message()
            {
                Name = "Test", Time = DateTime.Now, Text = "Test"
            };
            string str1 = some.ToJson();
            Console.WriteLine(str1);

            var some2 = Message.FromJson(str1);
            Console.WriteLine(some2.Name);*/
            //2

            //3
            
            if (args.Length == 0) 
            {
                Chat.Server();
            }
            else
            {
                Chat.Client(args[0]);
            }
        }
    }
}
