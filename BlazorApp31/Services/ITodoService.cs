using BlazorApp31.Data;

namespace BlazorApp31.Services
{
    public interface ITodoService
    {
        Task<List<TodoListModel>> GetAllTodosAsync();
        Task<TodoListModel> GetToDoByIdAsync(int id);
        Task AddToDoAsync(TodoListModel item);
        Task UpdateToDoAsync(TodoListModel item, int id);
        Task DeleteToDoAsync(int id);
    }
}
