using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L05_Task04
{
    class Store
    {
        private Article[] articles = null;

        public Store(int size)
        {
            // Проверяем на позитив массива
            articles = new Article[Math.Abs(size)];
        }

        // Индексатор
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index].Show();
                return string.Format($"Товар с данным номером {index} - не существует в базе!\nВсего товаров в магазине {articles.Length}");
            }
        }

        // Индексатор - перегрузка
        public string this[string index]
        {
            get
            {
                foreach (Article article in articles)
                    if (article.Name == index)
                        return article.Show();

                return string.Format($"Товар с данным названием {index} - не существует в базе!");
            }
        }

        // Добавление товара в магазин по индексу
        public void AddArticleToStore(Article article, int index)
        {
            if (index <= 0 && index > articles.Length)
                Console.WriteLine("Извините, но магазин переполнен!");
            articles[index] = article as Article;
        }
    }
}
