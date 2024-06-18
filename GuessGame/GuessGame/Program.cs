using GuessGame.Data;
using GuessGame.Data.Models;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace GuessGame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //AddWordList();
            Application.Run(new Forms.StartUp());
           
        }

        static void AddWordList()
        {
            try
            {

                using (var context = new AppDbContext())
                {

                    var wordList = new List<Word> {
                new Word {Value = "Медаль", Description = "Винагорода або відзнака, яку отримують за досягнення у різних сферах."},
                new Word {Value = "Лісник", Description = "Людина, яка працює у лісі, доглядає за деревами та веде господарську діяльність."},
                new Word {Value = "Медуза", Description = "Безхребетна тварина з довгими тентаклями, які вона використовує для полювання."},
                new Word {Value = "Шахрай", Description = "Людина, яка використовує обман або маніпуляції для отримання користі на шкоду іншим."},
                new Word {Value = "Фітнес", Description = "Фізичні вправи або тренування, спрямовані на підтримку здоров'я та фізичної форми."},
                new Word {Value = "Буквар", Description = "Навчальна книга для початкового навчання читання та письма."},
                new Word {Value = "Ялинка", Description = "Велике дерево з зеленими голочками, яке часто використовується як прикраса на Різдво."},
                new Word {Value = "Бублик", Description = "Кругла випічка з отвором посередині, зазвичай з великою кількістю насіння маку на поверхні."},
                new Word {Value = "Фізика", Description = "Наука, що вивчає природні явища та їх взаємодію."},
                new Word {Value = "Сирота", Description = "Дитина, яка втратила батьків або опікунів та залишилася без догляду."},
                new Word {Value = "Валіза", Description = "Предмет багажу для перенесення особистих речей під час подорожей."},
                new Word {Value = "Гранат", Description = "Фрукт з  численними насінинами,обгорнутими в соковиту м'якоть червоного кольору"},
                new Word {Value = "Космос", Description = "Нескінченний простір, що охоплює всесвіт, зірки, планети, галактики та ін."},
                new Word {Value = "Танець", Description = "Вид мистецтва, що виражається у ритмічних рухах тіла під музику."},
                new Word {Value = "Музика", Description = "Мистецтво, що включає мелодію, гармонію, ритм та тембр."},
                new Word {Value = "Футбол", Description = "Командний вид спорту, де дві команди, змагаються за забиття м'яча в ворота суперника."},
                new Word {Value = "Дружба", Description = "Jсобистісні стосунки між людьми, засновані на взаємній довірі, підтримці та спільних інтересах."},
                new Word {Value = "Знання", Description = "Інформація, уміння та досвід, які людина здобуває через навчання, дослідження або практику."},
                new Word {Value = "Четвер", Description = "День тижня, що слідує за середою і передує п'ятниці, четвертий день у звичайному поділі тижня."},
                new Word {Value = "Година", Description = "Одиниця часу, що дорівнює шістдесяти хвилинам або одній двадцять четвертій частині сонячної доби."}

                };
                    foreach (var word in wordList)
                    {
                        context.Words.Add(word);
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні слова: {ex.Message}");
            }

        }
    }
}