using System.ComponentModel.DataAnnotations;

namespace Topicos_especiais.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class TaskModel
    {
        public int TaskId { get; set; }

        [Required(ErrorMessage = "O nome da tarefa é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome da tarefa não pode ter mais de 100 caracteres.")]
        public string? TaskName { get; set; }

        public bool IsCompleted { get; set; }
    }
}
