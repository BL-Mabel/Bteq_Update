//using MongoDB.Bson;
//using MongoDB.Bson.Serialization.Attributes;
//using MongoDB.Bson.Serialization.IdGenerators;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Text;

//namespace UtilityLayer.RequestModel
//{
//    public class QuestionTopicModel
//    {
//        [BsonId]
//        public ObjectId Id { get; set; }
//        public string main_topic { get; set; }
//        public List<SubTopicArray> sub_topic { get; set; }
//        public bool is_active { get; set; }
//        [DefaultValue(false)]
//        public bool is_deleted { get; set; }
//        public DateTime created_date { get; set; }
//        public DateTime modified_date { get; set;}
//    }
//    public class SubTopicArray
//    {
//        [BsonId]
//       // [BsonRepresentation(BsonType.ObjectId)]
//        //[BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
//        public ObjectId SId { get; set; }
//        public string name { get; set; }
//        public bool is_active { get; set; }
//        [DefaultValue(false)]
//        public bool is_deleted { get; set; }
//        public DateTime created_date { get; set; }
//        public DateTime modified_date { get; set; }
//    }
//}
