using System;
using System.Collections.Generic;

namespace quora.Models;

public partial class Answer
{
    public int Id { get; set; }

    public int? QuestionId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public string? Description { get; set; }

    public virtual Question? Question { get; set; }
}
