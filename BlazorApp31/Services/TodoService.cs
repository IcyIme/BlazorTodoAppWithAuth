using BlazorApp31.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp31.Services
{
    public class TodoService : ITodoService
    {
        ApplicationDbContext context;

        public TodoService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<TodoListModel>> GetAllTodosAsync()
        {
            return await context.TodoList.ToListAsync();
        }

        public async Task<TodoListModel> GetToDoByIdAsync(int id)
        {
            return await context.TodoList.FindAsync(id);
        }

        public async Task AddToDoAsync(TodoListModel item)
        {
            context.TodoList.Add(item);
            await context.SaveChangesAsync();
        }

        public async Task UpdateToDoAsync(TodoListModel item, int id)
        {
            var dbItem = await context.TodoList.FindAsync(id);
            if (dbItem != null)
            {
                dbItem.Title = item.Title;
                dbItem.Description = item.Description;
            }
        }

        public async Task DeleteToDoAsync(int id)
        {
            var dbItem = await context.TodoList.FindAsync(id);
            if (dbItem != null)
            {
                context.Remove(dbItem);
                await context.SaveChangesAsync();
            }
        }
    }
}
