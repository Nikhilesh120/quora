using quora.topics;
using quora.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System;
using quora.Models;

namespace quora.Service
{
    public class TopicService:ITopic
    {
		private readonly DevQuoraContext devQuoraContext;
        public TopicService()
        {
			string connection = Environment.GetEnvironmentVariable("SQL-CONNECTION-STRING");
			devQuoraContext = new(connection);
        }

		/// <summary>
		/// creates the question 
		/// </summary>
		/// <param name="question"></param>
        public async Task CreateQuestion(QuestionEntity question)
        {
			try
			{
				Question questionRepo = new()
				{
					TopicId = question.QTopicId,
					Description = question.QDescription,
					CreatedBy = question.QCreatedBy,
					CreatedDateTime = DateTime.Now,
					ModifiedBy = question.QModifiedBy,
					ModifiedDateTime = DateTime.Now
				};
				devQuoraContext.Questions.Add(questionRepo);
				await devQuoraContext.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				throw ex;
			}
        }

		/// <summary>
		/// updates the question 
		/// </summary>
		/// <param name="question"></param>
		public async Task UpdateQuestion(QuestionEntity question)
		{
			try
			{
				Question questionRepo = new()
				{
					TopicId = question.QTopicId,
					Description = question.QDescription,
					CreatedBy = question.QCreatedBy,
					CreatedDateTime = DateTime.Now,
					ModifiedBy = question.QModifiedBy,
					ModifiedDateTime = DateTime.Now
				};
				devQuoraContext.Questions.Update(questionRepo);
				await devQuoraContext.SaveChangesAsync();
			} 
			catch (Exception ex) 
			{

				throw ex;
			}
		}

		
		/// <summary>
		/// gets the question the by id
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public  List<QuestionEntity> GetQuestion(int TopicId)
		{
			try
			{
				List<Question> questions = devQuoraContext.Questions.Where(c=>c.TopicId == TopicId).ToList();
				List<QuestionEntity> questionEntites = questions.Select(c => new QuestionEntity
				{
					QId = c.Id,
					QTopicId = (int)c.TopicId,
					QDescription = c.Description,
					QCreatedBy = c.CreatedBy,
					QCreatedDateTime = (DateTime)c.CreatedDateTime,
					QModifiedBy = c.ModifiedBy,
					QModifiedDateTime = (DateTime)c.ModifiedDateTime
				}).ToList();
				return questionEntites;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        /// <summary>
        /// deletes the question by id
        /// </summary>
        /// <param name="Id"></param>
        public async Task DeleteQuestion(int Id)
        {
            try
            {
				devQuoraContext.Questions.Remove(devQuoraContext.Questions.Where(c => c.Id == Id).First());
				await devQuoraContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// creates the answer 
        /// </summary>
        /// <param name="answer"></param>
        public async Task  CreateAnswer(AnswerEntity answer)
		{
			try
			{
				Answer answerRepo = new()
				{
					QuestionId = answer.AQuestionId,
					CreatedBy = answer.ACreatedBy,
					CreatedDateTime = DateTime.Now,
					ModifiedBy = answer.AModifiedBy,
					ModifiedDateTime = DateTime.Now,
					Description = answer.ADescription
				};
				devQuoraContext.Answers.Add(answerRepo);
				await devQuoraContext.SaveChangesAsync();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        /// <summary>
        /// updates the answer
        /// </summary>
        /// <param name="answer"></param>
        public async Task UpdateAnswer(AnswerEntity answer)
        {
            try
            {
                Answer answerRepo = new()
                {
                    QuestionId = answer.AQuestionId,
                    Description = answer.ADescription,
                    CreatedBy = answer.ACreatedBy,
                    CreatedDateTime = DateTime.Now,
                    ModifiedBy = answer.AModifiedBy,
                    ModifiedDateTime = DateTime.Now
                };
                devQuoraContext.Answers.Update(answerRepo);
                await devQuoraContext.SaveChangesAsync();
            }
            catch (Exception ex )
            {
                throw ex;
            }
        }

        /// <summary>
        /// gets the answer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<AnswerEntity> GetAnswer(int QuestionId)
		{
			try
			{
				List<Answer> answers = devQuoraContext.Answers.Where(c=>c.QuestionId == QuestionId).ToList();
				List<AnswerEntity> answerEntities = answers.Select(c => new AnswerEntity
				{
					AQuestionId = (int)c.QuestionId,
					ADescription = c.Description,
					ACreatedBy = c.CreatedBy,
					ACreatedDateTime = (DateTime)c.CreatedDateTime,
					AModifiedBy = c.ModifiedBy,
					AModifiedDateTime = (DateTime)c.ModifiedDateTime,
				}).ToList();
				return answerEntities;
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
	
		/// <summary>
		/// deltes the answer by id
		/// </summary>
		/// <param name="Id"></param>
		public async Task  DeleteAnswer(int Id)
		{
			try
			{
				devQuoraContext.Answers.Remove(devQuoraContext.Answers.Where(c =>c.Id == Id).First());
				 await devQuoraContext.SaveChangesAsync();
			}
			catch(Exception ex)
			{
				throw ex ;
			}
		}

		/// <summary>
		/// creates a new topic
		/// </summary>
		/// <param name="topic"></param>
		/// <returns></returns>
		public async Task CreateTopic(TopicEntity topic)
		{
			try
			{
				Topic topicRepo = new()
				{
					TopicName = topic.TName,
					TopicDescription = topic.TDescription,
					TopicCreatedBy = topic.TCreatedBy,
					TopicCreatedDateTime = DateTime.Now,
                    TopicModifiedBy = topic.TDescription,
					TopicModifiedDateTime = DateTime.Now,
                };
				devQuoraContext.Topics.Add(topicRepo);
				await devQuoraContext.SaveChangesAsync();	
			}
			catch(Exception  ex)
			{
				throw ex ;
			}
		}
		/// <summary>
		/// updates the topic
		/// </summary>
		/// <param name="topic"></param>
		/// <returns></returns>
		 public async Task UpdateTopic(TopicEntity topic)
		{
			try
			{
				Topic topicRepo = new()
				{
					TopicName = topic.TName,
					TopicDescription = topic.TDescription,
					TopicCreatedBy = topic.TCreatedBy,
					TopicCreatedDateTime = DateTime.Now,
					TopicModifiedBy = topic.TModifiedBy,
					TopicModifiedDateTime = DateTime.Now,
				};
				devQuoraContext.Topics.Update(topicRepo);
				await devQuoraContext.SaveChangesAsync();
			}
			catch (Exception ex) 
			{
				throw ex;
			}
		}
		/// <summary>
		/// returns the topic 
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public List<TopicEntity> GetTopic()
		{
			try
			{
				List<TopicEntity> topicsEntities = devQuoraContext.Topics.Select(c => new TopicEntity
				{
					TId = (int)c.TopicId,
					TName = c.TopicName,
					TDescription = c.TopicDescription,
					TCreatedBy = c.TopicCreatedBy,
					TCreatedDateTime = (DateTime)c.TopicCreatedDateTime,
					TModifiedBy = c.TopicModifiedBy,
					TModifiedDateTime = (DateTime)c.TopicModifiedDateTime
				}).ToList();
				return topicsEntities;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		/// <summary>
		/// deletes the topic
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public async Task DeleteTopic(int Id)
		{
			try
			{
				devQuoraContext.Topics.Remove(devQuoraContext.Topics.Where(c => c.TopicId == Id).First());
				await devQuoraContext.SaveChangesAsync();
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}
    }
}
