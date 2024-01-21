using DAL.Models;
using Service.Common.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Rep
{
    public class SubscribeRep
    {
        private CDBContext db;
        //public SubscribeRep(CDBContext _db)
        //{
        //    db = _db;

        //}

        public void AddSubscribe(SubscribeDto subscribeDto)
        {

            //using (CDBContext db = new CDBContext())
            //{
            string cs = ConfigurationManager.ConnectionStrings["newDatabaseContext"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(cs))
            {


                Subscribe subscribe = new Subscribe
                {
                    EventId = subscribeDto.EventId,
                    UserId = subscribeDto.UserId,
                    Is_Like = subscribeDto.Is_Like,
                    Is_Subscribe = subscribeDto.Is_Subscribe
                };

                //var d = db.Subscribes.Where(a => a.EventId == subscribeDto.EventId && a.UserId == subscribeDto.UserId).SingleOrDefault();
                //db.
                using (SqlCommand command = new SqlCommand("SELECT  * FROM  Subscribes WHERE UserId = UserId AND EventId= @EventId  AND Is_Subscribe=@Is_Subscribe ", connection))
                {
                    command.Parameters.AddWithValue("@UserId", subscribe.UserId);
                    command.Parameters.AddWithValue("@EventId", subscribe.EventId);
                    command.Parameters.AddWithValue("@Is_Subscribe", subscribe.Is_Subscribe);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {


                        if (reader.HasRows)
                        {
                            // If the user has already liked the post, unlike it
                            using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Subscribes WHERE UserId = @UserId AND EventId = @EventId AND Is_Subscribe=@Is_Subscribe ", connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@UserId", subscribe.UserId);
                                deleteCommand.Parameters.AddWithValue("@EventId", subscribe.EventId);
                                deleteCommand.Parameters.AddWithValue("@Is_Subscribe", subscribe.Is_Subscribe);
                                deleteCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // If the user has not liked the post, like it
                            using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Subscribes (UserId, EventId , Is_Subscribe) VALUES ( @UserId, @EventId ,@Is_Subscribe)", connection))
                            {
                                insertCommand.Parameters.AddWithValue("@UserId", subscribe.UserId);
                                insertCommand.Parameters.AddWithValue("@EventId", subscribe.EventId);
                                insertCommand.Parameters.AddWithValue("@Is_Subscribe", subscribe.Is_Subscribe);
                                insertCommand.ExecuteNonQuery();
                            }
                        }

                    }
                    // var RES = "SELECT  * FROM  Subscribes WHERE UserId = @subscribe.UserId AND EventId= @subscribe.EventId  ";


                    //     if (subscribe.Is_Like==true)
                    //{

                    //}
                }

            }
        }

        public bool AddComment(SubscribeDto subscribeDto)
        {
            using (CDBContext db = new CDBContext())
            {

                Subscribe subscribe = new Subscribe
                {
                    EventId = subscribeDto.EventId,
                    UserId = subscribeDto.UserId,
                    Is_Like = subscribeDto.Is_Like,
                    Comment = subscribeDto.Comment,

                };


                db.Subscribes.Add(subscribe);
                db.SaveChanges();

            }
            return true;
        }
        public void IsLike(SubscribeDto subscribeDto)
        {
            using (CDBContext db = new CDBContext())
            {

                var sub = db.Subscribes.Where(x => x.EventId == subscribeDto.EventId && x.UserId == subscribeDto.UserId).FirstOrDefault();
                if (sub != null)
                {
                    sub.Is_Like = !sub.Is_Like;
                    db.SaveChanges();
                }
                else
                {
                    var SUBSCRIBE = new Subscribe
                    {
                        EventId= subscribeDto.EventId,
                        UserId= subscribeDto.UserId,
                        Is_Like= subscribeDto.Is_Like
                    };
                    db.Subscribes.Add(SUBSCRIBE);
                    db.SaveChanges();
                }
            }
        }
        //string cs = ConfigurationManager.ConnectionStrings["newDatabaseContext"].ConnectionString;

        // using (SqlConnection connection = new SqlConnection(cs))
        //{


        //    Subscribe subscribe = new Subscribe
        //    {
        //        EventId = subscribeDto.EventId,
        //        UserId = subscribeDto.UserId,
        //        Is_Like = subscribeDto.Is_Like
        //    };

        //    //var d = db.Subscribes.Where(a => a.EventId == subscribeDto.EventId && a.UserId == subscribeDto.UserId).SingleOrDefault();
        //    //db.
        //    using (SqlCommand command = new SqlCommand("SELECT  * FROM  Subscribes WHERE UserId = UserId AND EventId= @EventId AND Is_Like =@Is_Like  ", connection))
        //    {
        //        command.Parameters.AddWithValue("@UserId", subscribe.UserId);
        //        command.Parameters.AddWithValue("@EventId", subscribe.EventId);
        //        command.Parameters.AddWithValue("@Is_Like", subscribe.Is_Like);
        //        connection.Open();
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {


        //            if (reader.HasRows)
        //            {
        //                // If the user has already liked the post, unlike it
        //                using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM Subscribes WHERE UserId = @UserId AND EventId = @EventId AND Is_Like =@Is_Like", connection))
        //                {
        //                    deleteCommand.Parameters.AddWithValue("@UserId", subscribe.UserId);
        //                    deleteCommand.Parameters.AddWithValue("@EventId", subscribe.EventId);
        //                    deleteCommand.Parameters.AddWithValue("@Is_Like", subscribe.Is_Like);
        //                    deleteCommand.ExecuteNonQuery();
        //                }
        //            }
        //            else
        //            {
        //                // If the user has not liked the post, like it
        //                using (SqlCommand insertCommand = new SqlCommand("INSERT INTO Subscribes (UserId, EventId , Is_Like) VALUES (@UserId, @EventId ,@Is_Like)", connection))
        //                {
        //                    insertCommand.Parameters.AddWithValue("@UserId", subscribe.UserId);
        //                    insertCommand.Parameters.AddWithValue("@EventId", subscribe.EventId);
        //                    insertCommand.Parameters.AddWithValue("@Is_Like", subscribe.Is_Like);
        //                    insertCommand.ExecuteNonQuery();
        //                }
        //            }

        //        }
        //        // var RES = "SELECT  * FROM  Subscribes WHERE UserId = @subscribe.UserId AND EventId= @subscribe.EventId  ";


        //        //     if (subscribe.Is_Like==true)
        //        //{

        //        //}
        //    }

        //}
        //}
        public List<SubscribeDto> GetAllSubscribers()
        {
            var L = new List<SubscribeDto>();
            using (CDBContext DB = new CDBContext())
            {
                var Listdb = DB.Subscribes.ToList();
                if (Listdb != null)
                {
                    foreach (var item in Listdb)
                    {
                        SubscribeDto dto = new SubscribeDto
                        {
                            Id = item.subscribeId,
                            UserId = item.UserId,
                            EventId = item.EventId,
                            //    EventName = item.EventName,
                            Is_Like = item.Is_Like
                            //      Email= item.Email,


                        };
                        if (item.User != null)
                        {
                            dto.Email = DB.Users.Where(x => x.UserId == item.UserId).Select(x => x.Email).FirstOrDefault();
                        }
                        if (item.EventFK != null)
                        {
                            dto.EventName = DB.Events.Where(x => x.EventId == item.EventId).Select(x => x.EventName).FirstOrDefault();
                        }
                        L.Add(dto);
                    }
                }
            }
            return L;
        }
    }
}
