using System.Data.Entity;
using TeeScoreService.Models;

namespace TeeScoreService
{
    public class TeeScoreInitializer : CreateDatabaseIfNotExists<TeeScoreContext>
    {
        protected override void Seed(TeeScoreContext context)
        {
            //List<TodoItem> todoItems = new List<TodoItem>
            //{
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false },
            //    new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false },
            //};

            //foreach (TodoItem todoItem in todoItems)
            //{
            //    context.Set<TodoItem>().Add(todoItem);
            //}

            base.Seed(context);
        }
    }
}

