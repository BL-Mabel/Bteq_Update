//using MongoDB.Bson.Serialization.Attributes;
//using MongoDB.Bson;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel;

//namespace UtilityLayer.RequestModel
//{
//    public class QuestionBankReq
//    {
//        [BsonId]
//        [BsonRepresentation(BsonType.ObjectId)]
//        public string Id { get; set; }
//        public string question { get; set; }
//        [ForeignKey("Topic")]
//        [BsonRepresentation(BsonType.ObjectId)]
//        public string topic_id { get; set; }
//        [ForeignKey("SubTopicArray")]
//        [BsonRepresentation(BsonType.ObjectId)]
//        public string sub_topic_id { get; set; }
//        public string type { get; set; }
//        public List<OptionArray> Options { get; set; }
//        public string difficulty_level { get; set; }
//        public List<AnswerArray> answers { get; set; }
//        public bool is_active { get; set; }
//        [DefaultValue(false)]
//        public bool is_deleted { get; set; }
//        public DateTime created_date { get; set; }
//        public DateTime modified_date { get; set; }
//    }
//    public class OptionArray
//    {
//        public string Option1 { get; set; }
//        public string Option2 { get; set; }
//        public string Option3 { get; set; }
//    }
//    public class AnswerArray
//    {
//        public string Option2 { get; set; }
//        public string Option3 { get; set; }
//    }

//}
