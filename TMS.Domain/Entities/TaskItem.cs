﻿using TMS.Domain.Enums;

namespace TMS.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public TaskItemStatus Status { get; set; } = TaskItemStatus.Todo;
        public Guid AssignedToUserId { get; set; }
        public Guid CreatedByUserId { get; set; }
        public Guid TeamId { get; set; }
        public DateTime DueDate { get; set; }
        public User? AssignedToUser { get; set; }
        public User? CreatedByUser { get; set; }
        public Team? Team { get; set; }

    }
}
