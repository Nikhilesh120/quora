namespace quora.Entities
{
    public class AnswerEntity
    {
        private int Id;
        private int QuestionId;
        private string Description;
        private string CreatedBy;
        private DateTime CreatedDateTime;
        private string ModifiedBy;
        private DateTime ModifiedDateTime;
        public int AId
        {
            get { return Id; }
            set { Id = value; }
        }
        public int AQuestionId
        {
            get { return QuestionId; }
            set { QuestionId = value; }
        }
        public string ADescription
        {
            get { return Description; }
            set
            {
                Description = value;
            }
        }
        public string  ACreatedBy
        {
            get { return CreatedBy; }
            set
            {
                CreatedBy = value;
            }
        }
        public DateTime ACreatedDateTime
        {
            get { return CreatedDateTime; }
            set
            {
                CreatedDateTime = value;
            }
        }
        public string AModifiedBy
        {
            get { return ModifiedBy; }  
            set { ModifiedBy = value; }
        }
        public DateTime AModifiedDateTime
        {
            get { return ModifiedDateTime; }
            set
            {
                ModifiedDateTime = value;
            }
        }
        
    }
}
