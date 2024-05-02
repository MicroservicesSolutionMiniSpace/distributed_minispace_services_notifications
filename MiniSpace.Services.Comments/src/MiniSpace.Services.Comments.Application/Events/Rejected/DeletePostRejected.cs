using Convey.CQRS.Events;

namespace MiniSpace.Services.Comments.Application.Events.Rejected
{
    public class DeleteCommentRejected : IRejectedEvent
    {
        public Guid CommentId { get; }
        public string Reason { get; }
        public string Code { get; }

        public DeleteCommentRejected(Guid commentId, string reason, string code)
        {
            CommentId = commentId;
            Reason = reason;
            Code = code;
        }
    }    
}
