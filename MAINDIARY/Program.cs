namespace MAINDIARY
{
    class Program
    {

        private static void Main(string[] args)
        {
            Menu();
        }


        public static void structure(int index, int position, bool enter)
        {


            Day Day1 = new Day();
            Day1.Task = "  1. Убраться в квартире.";
            Day1.Description = "Пропылесосить затем помыть полы.\n Протереть везде быль. \n Разобрать старые вещи, ненужные выкинуть.";

            Day Day2 = new Day();
            Day2.Task = "  2. Продолжить занятия спортом";
            Day2.Description = "Лежебока вставай, сегодня ты будешь отрабатывь вчерашний сьеденный тобою тортик :3.\n Сделать тренировку на пресс,побегать на беговой дорожке,покачать попу";



            Day Day3 = new Day();
            Day3.Task = "  1. Посмотреть зимнюю куртрку";
            Day3.Description = "Наступают холода, и твоя жопка должна быть в тепле так что - \n Посмотри куртрку в разных магазинах. \n Сравни цены. \n Закажи куртрку цена=качество, да такая чтобы попу закрывала!";

            Day Day4 = new Day();
            Day4.Task = "  2. Купить продукты.";
            Day4.Description = "Сходить в пятерочку. \n Купить спаггети, фарш куриный и сыр. \n А так же по мелочи,туалетную бумагу, воду, хлеб, пивас...А и конечно же фруто няню!";



            Day Day5 = new Day();
            Day5.Task = "  1. Сходить к бабушке.";
            Day5.Description = "Позвонить узнать у бабушки, когда к ней можно придти. \n Купить всяких ей вкусностей. \n Придя к ней домой выслушать, как же ты исхудал. \n Убраться по квартире.";

            Day Day6 = new Day();
            Day6.Task = "  2. Отвезти машину на Т.О.";
            Day6.Description = "Твоя рухлять скоро развалиться скорее! \n Привезти машину на Тех Осмотр. \n Спросить о поломках и выслушать рекомендации. \n Купить нужные вещи для машины.";



            Day Day7 = new Day();
            Day7.Task = "  Планов нет,отдыхай :3";
            Day7.Description = "Я написал отдыхать, значит отдыхай. \n поехавший трудоголик..";

            Day Day8 = new Day();
            Day8.Task = "  Ну можешь бахнуть водочки для блатной походочки";
            Day8.Description = "Это шутка! А ну быстро за уроки :<";



            Day[,] Days = new Day[4, 8];

            Days[0, 0] = Day1;
            Days[0, 1] = Day2;  // первый 1

            Days[1, 0] = Day3;
            Days[1, 1] = Day4;  // первый 2

            Days[2, 0] = Day5;
            Days[2, 1] = Day6;  // первый 3

            Days[3, 0] = Day7;
            Days[3, 1] = Day8;  // первый 4

            if (enter == false)
            {
                Console.WriteLine(Days[index, 0].Task);
                Console.WriteLine(Days[index, 1].Task);
            }
            else
            {

                Console.WriteLine(Days[index, position - 1].Task);
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Описание: " + Days[index, position - 1].Description);
                Console.WriteLine("Выполнить до вечера.");
            }

        }


        public static void Menu()
        {


            bool enter = false;
            int index = 0;
            int position = 1;
            time(index);
            structure(index, position, enter);
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");

            while (true)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position = position - 1;

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position = position + 1;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    index = index + 1;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    index = index - 1;
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    if (enter == false)
                    {
                        enter = true;
                    }
                    else
                    {
                        enter = false;
                    }


                }


                Console.Clear();
                time(index);
                structure(index, position, enter);
                Console.SetCursorPosition(0, position);
                if (enter == false)
                {
                    Console.WriteLine("->");
                }

            }

        }

        public static void time(int index) // меню для вывода времени
        {

            DateTime[] dateTimes = new DateTime[]
            {
                new DateTime(2022, 10, 1),
                new DateTime(2022, 10, 2),
                new DateTime(2022, 10, 3),
                new DateTime(2022, 10, 4),
                new DateTime(2022, 10, 5),
                new DateTime(2022, 10, 6),
                new DateTime(2022, 10, 7),
                new DateTime(2022, 10, 8),
            };

            Console.WriteLine("Выбрана дата: " + dateTimes[index].ToShortDateString());
        }











    }
}